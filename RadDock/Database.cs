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
		public LinkedList<string> names = new LinkedList<string>();
		public LinkedList<string> browsers = new LinkedList<string>();
		public LinkedList<string> paths = new LinkedList<string>();

		public Database()
		{
			XElement localFile = XElement.Load(@".\path.xml");
			this.path = localFile.Value;
			file = XElement.Load(this.path);
		}
		private IEnumerable<XElement> getRows()
		{
			IEnumerable<XElement> rows = from el in file.Elements()
										 select el;
			return rows;
		}
		public LinkedList<string> getNames()
		{
			foreach (XElement element in this.getRows())
			{
				string name = element.Attribute("name").Value.ToString();
				this.names.AddFirst(name);
			}
			return this.names;
		}
		public LinkedList<string> getBrowsers()
		{
			foreach (XElement element in this.getRows())
			{
				string browser = element.Attribute("browser").Value.ToString();
				this.browsers.AddFirst(browser);
			}
			return this.browsers;
		}
		public LinkedList<string> getPaths()
		{
			foreach (XElement element in this.getRows())
			{
				string path = @element.Attribute("path").Value.ToString();
				this.paths.AddFirst(path);
			}
			return this.paths;
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
