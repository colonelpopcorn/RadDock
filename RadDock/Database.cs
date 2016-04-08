using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace RadDock
{
	class Database
	{
		private string path { get; set; }
		private XElement localFile;
		private XElement file;
		private XmlWriter writer;
		private LinkedList<string> names = new LinkedList<string>();
		private LinkedList<string> browsers = new LinkedList<string>();
		private LinkedList<string> paths = new LinkedList<string>();
		private LinkedList<string> CLIAndBrowserPaths = new LinkedList<string>();
		private LinkedList<string> CLIAndBrowserKeys = new LinkedList<string>();


		public Database()
		{
			this.localFile = XElement.Load(@".\path.xml");
			this.path = localFile.Attribute("path").Value;
			this.file = XElement.Load(this.path);
			this.writer = XmlWriter.Create(this.path);
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

		private IEnumerable<XNode> getBrowsersAndCLI()
		{
			IEnumerable<XElement> rows = from el in localFile.Elements()
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

		private LinkedList<string> setCLIAndBrowserPaths()
		{
			foreach (XElement element in this.getBrowsersAndCLI())
			{
				string path = @element.Value;
				this.CLIAndBrowserPaths.AddFirst(path);
			}
			return this.CLIAndBrowserPaths;
		}

		public LinkedList<string> getCLIAndBrowserKeys()
		{
			foreach (XElement element in this.getBrowsersAndCLI())
			{
				string key = @element.Attribute("id").Value;
				this.CLIAndBrowserKeys.AddFirst(key);
			}
			return this.CLIAndBrowserKeys;
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

		public void write(LinkedList<string> names, LinkedList<string> paths, LinkedList<string> browsers)
		{
			this.file.RemoveAll();
			this.file.Add(new XElement("Objects"));	
			using (var namesList = names.GetEnumerator())
			using (var pathsList = paths.GetEnumerator())
			using (var browsersList = browsers.GetEnumerator())
			{
				while (namesList.MoveNext() && pathsList.MoveNext() && browsersList.MoveNext())
				{
					XElement element = new XElement("object");
					element.ReplaceAttributes(new XAttribute("name", namesList.Current), new XAttribute("path", pathsList.Current), new XAttribute("browser", browsersList.Current));
					this.file.Add(element);
				}
			}
			this.file.WriteTo(this.writer);
		}

    }
}
