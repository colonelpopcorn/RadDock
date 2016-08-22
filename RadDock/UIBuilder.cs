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
		private List<RadDockMenuItem> info;
		public List<RadDockComboBoxItem> combo;

		public UIBuilder()
		{
			this.info = db.getInfoObject();
            this.combo = new List<RadDockComboBoxItem>();
		}

		public List<RadDockMenuItem> buildMenuOptions(EventHandler e)
		{
			foreach (RadDockMenuItem obj in this.info)
			{
				obj.Click += e;
			}
			return this.info;
		}

        public List<RadDockComboBoxItem> buildComboOptions()
        {
            this.combo = db.getComboObject();
            return this.combo;
        }

		public void writeProgramRow(int id, string name, string arg, string path)
		{
            db.writeProgramRow(id, name, arg, path);
        }
        public void writeArgRow(string id, string path)
        {
            db.writeArgRow(id, path);
        }
	}
}
