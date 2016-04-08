using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadDock
{
	public partial class EditForm : Form
	{
		private UIBuilder ui = new UIBuilder();
		private LinkedList<string> names;
		private LinkedList<string> paths;
		private LinkedList<string> browsers;

		public EditForm()
		{
			
			InitializeComponent();
			InitializeDynamicForm();
			this.names = new LinkedList<string>();
			this.paths = new LinkedList<string>();
			this.browsers = new LinkedList<string>();
			foreach (DataGridViewRow dr in this.TableFormView.Rows)
			{
				try {
					this.names.AddFirst(dr.Cells["ProgName"].Value.ToString());
					this.paths.AddFirst(dr.Cells["Path"].Value.ToString());
					this.browsers.AddFirst(dr.Cells["Browser"].Value.ToString());
				}
				catch (Exception exc)
				{
					continue;
				}
			}
			this.Opacity = 0;
			this.Hide();
		}

		private void InitializeDynamicForm()
		{
			foreach (RadDockMenuItem item in ui.buildMenuOptions(Dynamic_Click))
			{
				RadDockMenu.Items.Add(item);
				TableFormView.Rows.Add(item.Name, item.path);
			}
			foreach (string key in ui.combo) { this.Browser.Items.Add(key); }
			ToolStripMenuItem edit = new ToolStripMenuItem("Edit");
			ToolStripMenuItem exit = new ToolStripMenuItem("Exit");
			edit.Click += new EventHandler(Edit_Click);
			exit.Click += new EventHandler(Exit_Click);
			RadDockMenu.Items.Add(new ToolStripSeparator());
			RadDockMenu.Items.Add(edit);
			RadDockMenu.Items.Add(exit);
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

		private void Submit_Click(object sender, EventArgs e)
		{
			//TODO: write code to write strings to XML database for each dynamic text box.
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
				if (item.browser == "false")
					Process.Start(item.path);
				else
					Process.Start(item.browser, item.path);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}

}
