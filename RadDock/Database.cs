using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RadDock
{
	class Database
	{
		private string path { get; set; }
		private bool _isWebApp { get; set; }
		private XElement file;
		private LinkedList<string> names = new LinkedList<string>();
		private LinkedList<string> browsers = new LinkedList<string>();
		private LinkedList<string> paths = new LinkedList<string>();

		public Database()
		{
			XElement localFile = XElement.Load(@".\path.xml");
			this.path = localFile.Value;
			file = XElement.Load(this.path);
			setNames();
			setPaths();
			setBrowsers();
		}

		private IEnumerable<XElement> getRows()
		{
			IEnumerable<XElement> rows = from el in file.Elements()
										 select el;
			return rows;
		}

		private LinkedList<string> setNames()
		{
			foreach (XElement element in this.getRows())
			{
				string name = element.Attribute("name").Value.ToString();
				this.names.AddFirst(name);
			}
			return this.names;
		}

		private LinkedList<string> setBrowsers()
		{
			foreach (XElement element in this.getRows())
			{
				string browser = element.Attribute("browser").Value.ToString();
				this.browsers.AddFirst(browser);
			}
			return this.browsers;
		}

		private LinkedList<string> setPaths()
		{
			foreach (XElement element in this.getRows())
			{
				string path = @element.Attribute("path").Value.ToString();
				this.paths.AddFirst(path);
			}
			return this.paths;
		}

		public LinkedList<RadDockMenuItem> getInfoObject()
		{
			LinkedList<RadDockMenuItem> info = new LinkedList<RadDockMenuItem>();
			using (var names = this.names.GetEnumerator())
			using (var paths = this.paths.GetEnumerator())
			using(var browsers = this.browsers.GetEnumerator())
			{
				while (names.MoveNext() && paths.MoveNext() && browsers.MoveNext())
				{
					info.AddFirst(new RadDockMenuItem(names.Current, paths.Current, browsers.Current));
				}
			}
				return info;
		}

		public bool write(string name, string path, string browser)
		{
			setName(name);
			setPath(path);
			setBrowser(browser);
			return true;
		}

		private void setName(string name)
		{

		}

		private void setPath(string path)
		{

		}

        private void setBrowser(string browser)
        {

        }

    }
}
