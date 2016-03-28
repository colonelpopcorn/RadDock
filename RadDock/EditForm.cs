using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadDock
{
	public partial class EditForm : Form
	{
		UIBuilder ui = new UIBuilder();

		public EditForm()
		{
			InitializeComponent();
			InitializeItems();
			this.Opacity = 0;
			this.Hide();
		}

		private void InitializeItems()
		{
			//setAll();
			//nameBoxes();
			//pathBoxes();
			//browserBoxes();
			//buildMenuOptions();
		}

		private void setAll()
		{
			//setNames();
			//setPaths();
			//setBrowsers();
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

		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Edit_Click(object sender, EventArgs e)
		{
			this.Opacity = 100;
			this.Show();
			this.ShowInTaskbar = true;
		}

		private void Dynamic_Click(object sender, EventArgs e)
		{
			//TODO: write code to open an application based on what's in the path definition.
			MessageBox.Show("HI!");
		}
	}

}
