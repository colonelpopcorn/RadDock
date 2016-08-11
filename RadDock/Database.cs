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
        private List<KeyValuePair<string, temporaryObject>> programRows;
		private List<KeyValuePair<string, string>> argProgramRows;
        private struct temporaryObject
        {
            public string name;
            public string path;
            public string args;
        };

		public Database()
		{
			this.localFile = XElement.Load(@".\path.xml");
			this.path = localFile.Attribute("path").Value;
			this.file = XElement.Load(this.path);
			this.writer = XmlWriter.Create(this.path);
            this.programRows = setProgramRows();
            this.argProgramRows = setArgumentRows();
		}

		private IEnumerable<XElement> getProgramRows()
		{
			IEnumerable<XElement> rows = from all in file.Elements()
										 select all;
			return rows;
		}

		private IEnumerable<XNode> getArgumentRows()
		{
			IEnumerable<XElement> rows = from all in localFile.Elements()
										 select all;

			return rows;
		}

		private List<KeyValuePair<string, temporaryObject>> setProgramRows()
		{
            List<KeyValuePair<string, temporaryObject>> progRows = new List<KeyValuePair<string, temporaryObject>>();
			foreach (XElement element in this.getProgramRows())
			{
                string name = element.Attribute("name").Value.ToString();
                string path = @element.Attribute("path").Value.ToString();
				string browser = element.Attribute("browser").Value.ToString();
                temporaryObject programRow = new temporaryObject();
                programRow.name = name;
                programRow.path = path;
                programRow.args = browser;
                KeyValuePair<string, temporaryObject> finalRow = new KeyValuePair<string, temporaryObject>(name, programRow);
                progRows.Add(finalRow);
			}

            return progRows;
		}

		private List<KeyValuePair<string, string>> setArgumentRows()
		{
            List<KeyValuePair<string, string>> argProgRows = new List<KeyValuePair<string, string>>();
			foreach (XElement element in this.getArgumentRows())
			{
				string path = @element.Value;
                string name = @element.Attribute("id").Value.ToString();
                argProgRows.Add(new KeyValuePair<string, string>(name, path));
			}
            return argProgRows;
		}

		public List<RadDockMenuItem> getInfoObject()
		{
			List<RadDockMenuItem> info = new List<RadDockMenuItem>();
            string argPath = "";
			foreach (KeyValuePair<string, temporaryObject> row in this.programRows)
			{
                foreach (KeyValuePair<string, string> arg in argProgramRows)
                {
                    if (arg.Key == row.Value.args)
                    {
                        argPath = arg.Value;
                    }
                }
                info.Add(new RadDockMenuItem(row.Key, row.Value.path, row.Value.args, argPath));
			}
			return info;
		}

        public List<RadDockComboBoxItem> getComboObject()
        {
            List<RadDockComboBoxItem> combo = new List<RadDockComboBoxItem>();
            foreach (KeyValuePair<string, string> row in this.argProgramRows)
            {
                combo.Add(new RadDockComboBoxItem(row.Key, row.Value));
            }
            return combo;
        }

		public void write(int index, string name, string path, string arg)
		{
            var query = from all in file.Elements()
                        select all;
            foreach (XElement obj in query)
            {
                int indexNum = (int)obj.Attribute("index").Value;
                if (obj.Attribute("index").Value.Equals(index))
                {
                    obj.Attribute("name").Value = name;
                    obj.Attribute("path").Value = path;
                    obj.Attribute("browser").Value = arg;
                }
                
            }
            file.Save("something.xml");
		}

    }
}
