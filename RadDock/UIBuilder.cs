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
		private LinkedList<Info> info;
		public Form finalForm = new Form();

		public UIBuilder()
		{
			this.info = db.getInfoObject();
		}

		public LinkedList<Control> nameBoxes()
		{
			LinkedList<Control> boxes = new LinkedList<Control>();
			i = 1;
			foreach (Info obj in this.info)
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(75, 25 * i);
				labelForSomething.Location = new Point(25, 25 * i);
				something.Text = obj.name;
				labelForSomething.Text = "Name:";
				something.Name = "DynamicName" + i.ToString();
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
			i = -1;
			foreach (Info obj in this.info)
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(250, 25 * i);
				labelForSomething.Location = new Point(190, 25 * i);
				something.Text = obj.path;
				labelForSomething.Text = "Path:";
				something.Name = "DynamicPath" + i.ToString();
				something.AutoSize = false;
				something.Size = new System.Drawing.Size(300, 20);
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
			foreach (Info obj in this.info)
			{
				TextBox something = new TextBox();
				Label labelForSomething = new Label();
				something.Location = new Point(650, 25 * i);
				labelForSomething.Location = new Point(590, 25 * i);
				something.Text = obj.browser;
				labelForSomething.Text = "Browser:";
				something.Name = "DynamicBrowser" + i.ToString();
				boxes.AddFirst(something);
				boxes.AddFirst(labelForSomething);
				i++;
			}
			i = 1;
			return boxes;
		}

		public LinkedList<object> buildMenuOptions(EventHandler e)
		{
			LinkedList<object> items = new LinkedList<object>();
			foreach (Info obj in this.info)
			{
				RadDockMenuItem item = new RadDockMenuItem();
				item.Name = obj.name;
				item.Text = obj.name;
				item.path = obj.path;
				item.browser = obj.browser;
				item.Click += e;
				items.AddFirst(item);
				i++;
			}
			i = 1;
			return items;
		}	
	}
}
