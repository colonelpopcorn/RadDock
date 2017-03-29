using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RadDock
{
	public partial class EditForm : Form
	{
        private UIBuilder ui;
        private string selectedValue;

        public EditForm()
		{
			
			InitializeComponent();
			InitializeDynamicForm();
			this.Opacity = 0;
			this.Hide();
		}

        public EditForm(string selectedValue):base()
        {
            ui = new UIBuilder(selectedValue);
            InitializeComponent();
            InitializeDynamicForm();
            this.Opacity = 0;
            this.Hide();
        }

        private void InitializeDynamicForm()
		{
            reset();
            insertArgs();
            insertPrograms();			
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				this.Opacity = 0;
				this.Hide();
				this.ShowInTaskbar = false;
				e.Cancel = true;
			}
			else
			{
				Application.Exit();
			}
		}

        private void reset()
        {
            this.RadDockMenu.Items.Clear();
            this.Browser.Items.Clear();
            this.ArgTableView.Rows.Clear();
            this.ProgramTableView.Rows.Clear();
        }

        private void insertArgs()
        {
            foreach (RadDockComboBoxItem item in ui.buildComboOptions())
            {
                this.Browser.Items.Add(item.argName);
                ArgTableView.Rows.Add(item.argName, item.argPath);
            }
        }

        private void insertPrograms()
        {
            int i = 0;
            foreach (RadDockMenuItem item in ui.buildMenuOptions(Dynamic_Click))
			{
                RadDockMenu.Items.Add(item);
				ProgramTableView.Rows.Add(item.Name, item.path);
                ProgramTableView.Rows[i].Cells["Browser"].Value = item.browser;
                i++;
            }
            ToolStripMenuItem edit = new ToolStripMenuItem("Edit");
			ToolStripMenuItem exit = new ToolStripMenuItem("Exit");
			edit.Click += new EventHandler(Edit_Click);
			exit.Click += new EventHandler(Exit_Click);
			RadDockMenu.Items.Add(new ToolStripSeparator());
			RadDockMenu.Items.Add(edit);
			RadDockMenu.Items.Add(exit);
        }

		private void Edit_Click(object sender, EventArgs e)
		{
			this.Opacity = 100;
			this.Show();
			this.ShowInTaskbar = true;
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Dynamic_Click(object sender, EventArgs e)
		{
			RadDockMenuItem item = (RadDockMenuItem)sender;
			try
			{
                if (item.browserPath == "false" || item.browserPath == "")
					Process.Start(item.path);
				else
					Process.Start(item.browserPath, item.path);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void Update_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ArgTableView.Rows.Count; i++)
            {
                ui.writeArgRow(ArgTableView.Rows[i].Cells["ArgName"].FormattedValue.ToString(), ArgTableView.Rows[i].Cells["ArgPath"].FormattedValue.ToString());
            }
            for (int i = 0; i < ProgramTableView.Rows.Count; i++)
            {
                int id = i + 1;
                ui.writeProgramRow(id, ProgramTableView.Rows[i].Cells["ProgName"].FormattedValue.ToString(), ProgramTableView.Rows[i].Cells["Browser"].FormattedValue.ToString(), ProgramTableView.Rows[i].Cells["Path"].FormattedValue.ToString());
            }
            DialogResult dr = MessageBox.Show("This form needs to restart for your changes to be applied. Continue?", "Confirm App Restart", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }

}
