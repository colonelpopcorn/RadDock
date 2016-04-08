using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RadDock
{
	class UIBuilder
	{
		private int i = 1;
		private Database db = new Database();
		private LinkedList<RadDockMenuItem> info;
		public LinkedList<string> combo;
		public Form finalForm = new Form();

		public UIBuilder()
		{
			this.info = db.getInfoObject();
			this.combo = db.getCLIAndBrowserKeys();
		}

		public LinkedList<Control> nameBoxes()
		{
			LinkedList<Control> boxes = new LinkedList<Control>();
			foreach (RadDockMenuItem obj in this.info)
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(75, 25 * i);
				labelForSomething.Location = new Point(25, 25 * i);
				something.Text = obj.Name;
				labelForSomething.Text = "Name " + i.ToString() + ":";
				something.Name = "DynamicName" + i.ToString();
				labelForSomething.AutoSize = true;
				boxes.AddFirst(something);
				boxes.AddFirst(labelForSomething);
				i++;
			}
			i = 1;
			return boxes;
		}

		public LinkedList<Control> pathBoxes()
		{
			LinkedList<Control> boxes = new LinkedList<Control>();
			foreach (RadDockMenuItem obj in this.info)
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(250, 25 * i);
				labelForSomething.Location = new Point(190, 25 * i);
				something.Text = obj.path;
				labelForSomething.Text = "Path " + i.ToString() +":";
				something.Name = "DynamicPath" + i.ToString();
				something.AutoSize = false;
				something.Size = new Size(300, 20);
				labelForSomething.AutoSize = true;
				boxes.AddFirst(something);
				boxes.AddFirst(labelForSomething);
				i++;
			}
			i = 1;
			return boxes;
		}

		public LinkedList<Control> browserBoxes()
		{
			LinkedList<Control> boxes = new LinkedList<Control>();
			foreach (RadDockMenuItem obj in this.info)
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(650, 25 * i);
				labelForSomething.Location = new Point(590, 25 * i);
				something.Text = obj.browser;
				labelForSomething.Text = "Browser " + i.ToString() + ":";
				something.Name = "DynamicBrowser" + i.ToString();
				labelForSomething.AutoSize = true;
				boxes.AddFirst(something);
				boxes.AddFirst(labelForSomething);
				i++;
			}
			i = 1;
			return boxes;
		}

		public LinkedList<RadDockMenuItem> buildMenuOptions(EventHandler e)
		{
			foreach (RadDockMenuItem obj in this.info)
			{
				obj.Click += e;
			}
			return this.info;
		}

		public void write(LinkedList<string> names, LinkedList<string> paths, LinkedList<string> browsers)
		{
			db.write(names, paths, browsers);
		}
	}
}
