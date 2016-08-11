using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadDock
{
    class RadDockComboBoxItem : ComboBox
    {
        public string argName;
        public string argPath;

        public RadDockComboBoxItem(string argName, string argPath)
        {
            this.argName = argName;
            this.argPath = argPath;
        }
    }
}
