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
		int i = 1;
		Database db = new Database(@"C:\Users\jling\Documents\raddock\RadDock\bin\debug\info.xml");
		public EditForm()
		{
			InitializeComponent();
			InitializeTextBoxes();
			this.Opacity = 0;
			this.Hide();
		}

		private void InitializeTextBoxes()
		{
			nameBoxes();
			pathBoxes();
			browserBoxes();
			buildMenuOptions();
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

		private void nameBoxes()
		{
			foreach (string name in db.getNames())
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(75, 25 * i);
				labelForSomething.Location = new Point(25, 25 * i);
				something.Text = name;
				labelForSomething.Text = "Name:";
				something.Name = "DynamicName" + i.ToString();
				this.Controls.Add(something);
				this.Controls.Add(labelForSomething);
				i++;
			}
			i = 1;
		}

		private void pathBoxes()
		{
			foreach (string path in db.getPaths())
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(250, 25 * i);
				labelForSomething.Location = new Point(190, 25 * i);
				something.Text = path;
				labelForSomething.Text = "Path:";
				something.Name = "DynamicPath" + i.ToString();
				something.AutoSize = false;
				something.Size = new System.Drawing.Size(300, 20);
				this.Controls.Add(something);
				this.Controls.Add(labelForSomething);
				i++;
			}
			i = 1;
		}

		private void browserBoxes()
		{
			foreach (string browser in db.getBrowsers())
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(650, 25 * i);
				labelForSomething.Location = new Point(590, 25 * i);
				something.Text = browser;
				labelForSomething.Text = "Browser:";
				something.Name = "DynamicBrowser" + i.ToString();
				this.Controls.Add(something);
				this.Controls.Add(labelForSomething);
				i++;
			}
			i = 1;
		}

		private void buildMenuOptions()
		{
			LinkedList<string> names = db.getNames();
			LinkedList<string> paths = db.getPaths();
			LinkedList<string> browsers = db.getBrowsers();
			LinkedList<ToolStripMenuItem> items = new LinkedList<ToolStripMenuItem>();

			foreach (string name in names)
			{
				ToolStripMenuItem item = new ToolStripMenuItem();
				item.Name = name;
				item.Text = name;
				item.Click += new EventHandler(Dynamic_Click);
				items.AddFirst(item);
				i++;
			}
			i = 1;
			foreach (ToolStripMenuItem item in items)
			{
				RadDockMenu.Items.Add(item);
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
