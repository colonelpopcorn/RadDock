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
		public Form finalForm = new Form();

		public UIBuilder()
		{
			this.info = db.getInfoObject();
            this.combo = new List<RadDockComboBoxItem>();
            db.write(2, "soemthing", "something.exe", "Chrome");
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

		public void write()
		{
		}
	}
}
