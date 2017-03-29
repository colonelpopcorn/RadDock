using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

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

        private void ProgramSelection_Load(object sender, EventArgs e)
        {
            string cwd = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            foreach (string item in Directory.GetFiles(cwd, "*.xml"))
            {
                configFileBox.Items.Add(item);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm(configFileBox.SelectedItem.ToString());
            this.Hide();
            form.ShowDialog();            
        }
    }
}
