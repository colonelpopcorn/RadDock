using System;
using System.Windows.Forms;

namespace RadDock
{
    public partial class ProgramSelection : Form
    {
        public ProgramSelection()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
