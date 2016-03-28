using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadDock
{
	class UIBuilder
	{
		private int i = 1;
		private Database db = new Database();
		private LinkedList<string> names;
		private LinkedList<string> paths;
		private LinkedList<string> browsers;

		private void setNames()
		{
			this.names = db.getNames();
		}

		private void setPaths()
		{
			this.paths = db.getPaths();
		}

		private void setBrowsers()
		{
			this.browsers = db.getBrowsers();
		}

		private void nameBoxes()
		{
			foreach (string name in this.names)
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(75, 25 * i);
				labelForSomething.Location = new Point(25, 25 * i);
				something.Text = name;
				labelForSomething.Text = "Name:";
				something.Name = "DynamicName" + i.ToString();
				//this.Controls.Add(something);
				//this.Controls.Add(labelForSomething);
				i++;
			}
			i = 1;
		}

		private void pathBoxes()
		{
			foreach (string path in this.paths)
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
				//this.Controls.Add(something);
				//this.Controls.Add(labelForSomething);
				i++;
			}
			i = 1;
		}

		private void browserBoxes()
		{
			foreach (string browser in this.browsers)
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(650, 25 * i);
				labelForSomething.Location = new Point(590, 25 * i);
				something.Text = browser;
				labelForSomething.Text = "Browser:";
				something.Name = "DynamicBrowser" + i.ToString();
				//this.Controls.Add(something);
				//this.Controls.Add(labelForSomething);
				i++;
			}
			i = 1;
		}

		private void buildMenuOptions()
		{
			LinkedList<ToolStripMenuItem> items = new LinkedList<ToolStripMenuItem>();

			foreach (string name in this.names)
			{
				ToolStripMenuItem item = new ToolStripMenuItem();
				item.Name = name;
				item.Text = name;
				//item.Click += new EventHandler(Dynamic_Click);
				items.AddFirst(item);
				i++;
			}
			i = 1;

			foreach (ToolStripMenuItem item in items)
			{
				//RadDockMenu.Items.Add(item);
			}

			ToolStripMenuItem edit = new ToolStripMenuItem("Edit");
			ToolStripMenuItem exit = new ToolStripMenuItem("Exit");
			//edit.Click += new EventHandler(Edit_Click);
			//exit.Click += new EventHandler(Exit_Click);
			//RadDockMenu.Items.Add(new ToolStripSeparator());
			//RadDockMenu.Items.Add(edit);
			//RadDockMenu.Items.Add(exit);

		}
	}
}
