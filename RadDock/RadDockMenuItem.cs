using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadDock
{
	class RadDockMenuItem : ToolStripMenuItem
	{
		public string path;
		public string browser;

		public RadDockMenuItem(string name, string path, string browser)
		{
			this.path = path;
			this.browser = browser;
			this.Name = name;
			this.Text = name;
		}
	}
}
