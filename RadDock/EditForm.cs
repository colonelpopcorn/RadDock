﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RadDock
{
	public partial class EditForm : Form
	{
		private UIBuilder ui = new UIBuilder();

		public EditForm()
		{
			
			InitializeComponent();
			InitializeDynamicForm();
			this.Opacity = 0;
			this.Hide();
		}

		private void InitializeDynamicForm()
		{
            foreach (RadDockComboBoxItem item in ui.buildComboOptions())
            {
                this.Browser.Items.Add(item.argName);
            }
            int i = 0;
			foreach (RadDockMenuItem item in ui.buildMenuOptions(Dynamic_Click))
			{
                RadDockMenu.Items.Add(item);
				TableFormView.Rows.Add(item.Name, item.path);
                TableFormView.Rows[i].Cells["Browser"].Value = item.browser;
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
	}

}
