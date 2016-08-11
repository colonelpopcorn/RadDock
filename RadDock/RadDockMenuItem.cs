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
		public string browserPath;

		public RadDockMenuItem(string name, string path, string browser, string browserPath)
		{
			this.path = path;
			this.browser = browser;
			this.browserPath = browserPath;
			this.Name = name;
			this.Text = name;
		}
	}
}
