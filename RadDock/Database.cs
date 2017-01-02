using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System;

namespace RadDock
{
    class Database
    {
        private XDocument file;
        private List<KeyValuePair<string, infoObject>> programRows;
        private List<KeyValuePair<string, string>> argProgramRows;
        private int initalProgramRowNum;
        private int initalArgRowNum;
        private struct infoObject
        {
            public string name;
            public string path;
            public string args;
        };

        public Database(string path)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            this.file = XDocument.Load(dir + path);
            this.programRows = setProgramRows();
            this.argProgramRows = setArgumentRows();
            this.initalProgramRowNum = programRows.Count;
            this.initalArgRowNum = argProgramRows.Count;
        }

        public IList<RadDockMenuItem> getInfoObject()
        {
            List<RadDockMenuItem> info = new List<RadDockMenuItem>();
            string argPath = "";
            foreach (KeyValuePair<string, infoObject> row in this.programRows)
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

        public IList<RadDockComboBoxItem> getComboObject()
        {
            List<RadDockComboBoxItem> combo = new List<RadDockComboBoxItem>();
            foreach (KeyValuePair<string, string> row in this.argProgramRows)
            {
                combo.Add(new RadDockComboBoxItem(row.Key, row.Value));
            }
            return combo;
        }

        public void writeProgramRow(int id, string name, string arg, string path)
        {
            XElement target;
            target = file
                .Element("container")
                .Element("programs")
                .Elements("program")
                .SingleOrDefault(x => int.Parse(x.FirstAttribute.Value) == id);

            if (target != null)
            {
                target.Attribute("id").Value = id.ToString();
                target.Attribute("name").Value = name;
                target.Attribute("arg").Value = arg;
                target.Value = path;
            }
            else
            {
                if (name != "" && arg != "" && path != "")
                {
                    target = new XElement("program", new XAttribute("id", id.ToString()),
                    new XAttribute("name", name),
                    new XAttribute("arg", arg));
                    target.Value = path;
                    file
                        .Element("container")
                        .Element("programs")
                        .Add(target);
                }
            }
            file.Save("info.xml");

        }

        public void writeArgRow(string id, string path)
        {
            XElement target;
            target = file
                .Element("container")
                .Element("args")
                .Elements("arg")
                .SingleOrDefault(x => x.FirstAttribute.Value == id);

            if (target != null)
            {
                target.Attribute("id").Value = id;
                target.Value = path;
            }
            else
            {
                if (id != "" && path != "")
                {
                    target = new XElement("arg", new XAttribute("id", id));
                    target.Value = path;
                    file
                        .Element("container")
                        .Element("args")
                        .Add(target);
                }

            }
            file.Save("info.xml");
        }

        private IEnumerable<XElement> getProgramRows()
        {
            IEnumerable<XElement> rows = from all in file.Descendants("program")
                                         select all;
            return rows;
        }

        private IEnumerable<XNode> getArgumentRows()
        {
            IEnumerable<XElement> rows = from all in file.Descendants("arg")
                                         select all;

            return rows;
        }

        private List<KeyValuePair<string, infoObject>> setProgramRows()
        {
            List<KeyValuePair<string, infoObject>> progRows = new List<KeyValuePair<string, infoObject>>();
            foreach (XElement element in this.getProgramRows())
            {
                string name = element.Attribute("name").Value.ToString();
                string path = @element.Value.ToString();
                string browser = element.Attribute("arg").Value.ToString();
                infoObject programRow = new infoObject();
                programRow.name = name;
                programRow.path = path;
                programRow.args = browser;
                KeyValuePair<string, infoObject> finalRow = new KeyValuePair<string, infoObject>(name, programRow);
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


    }
}
