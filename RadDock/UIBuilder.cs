using System;
using System.Collections.Generic;

namespace RadDock
{
    class UIBuilder
	{
		private int i = 1;
		private Database db = new Database(@".\example.xml");
		private IList<RadDockMenuItem> info;
		public IList<RadDockComboBoxItem> combo;

		public UIBuilder()
		{
			this.info = db.getInfoObject();
            this.combo = new List<RadDockComboBoxItem>();
		}

        //TODO: Find some way to automatically test this method!
        public IList<RadDockMenuItem> buildMenuOptions(EventHandler e)
		{
			foreach (RadDockMenuItem obj in this.info)
			{
				obj.Click += e;
			}
			return this.info;
		}

        public IList<RadDockComboBoxItem> buildComboOptions()
        {
            this.combo = db.getComboObject();
            return this.combo;
        }

        //TODO: Clean this up so it takes an object and a path instead of four primitives.
		public void writeProgramRow(int id, string name, string arg, string pathToExe)
		{
            db.writeProgramRow(id, name, arg, pathToExe);
        }
        public void writeArgRow(string id, string pathToExe)
        {
            db.writeArgRow(id, pathToExe);
        }
	}
}
