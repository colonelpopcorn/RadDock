using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            //RadDock with ERP8 functionality assembled by Jonathan Ling, StartCRM() and StartVDI() methods authored by Brian PTestSuiteett.
            
        }
        private void KillTestSuite()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("TestSuite"))
                {
                    proc.Kill();
                }

                foreach (Process proc0 in Process.GetProcessesByName("adb"))
                {
                    proc0.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void StartTestSuitefacility() 
        {
            KillTestSuite();
            try
            {
                Process.Start(@"C:\TestSuite_REPOS\facility_TestSuite\New TestSuite\TestSuite.exe -Build Test.lnk");
            }
            catch
            {
                MessageBox.Show("Please select a valid version");
            }
        }
        private void StartTestSuiteGuinea()
        {
                KillTestSuite();
                try
                {
                    Process.Start(@"C:\TestSuite_REPOS\GUINEA_TestSuite\New TestSuite\TestSuite.exe -Build Test.lnk");
                }
                catch {
                    MessageBox.Show("Please select a valid version");
                }
          
        }
        private void StartCRM()
        {
            try
            {
                Process.Start(@"C:\TestSuite_REPOS\GUINEA_TestSuite\OptionalShortcuts\CRM.rdp");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"C:\WINDOWS\system32\mstsc.exe";
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.EnableRaisingEvents = true;
            proc.Start();
            //this.Close();*/
        }
        private void StartERP()
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "chrome.exe",
                Arguments = " \"https://ERP.domain.company.com/web"
            });
        }
        private void StartVDI()
        {
            try
            {
                Process.Start(@"C:\Program Files\VMware\VMware View\Client\bin\wswc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"C:\Program Files\VMware\VMware View\Client\bin\wswc.exe";
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.EnableRaisingEvents = true;
            proc.Start();
            //this.Close();*/
        }
        private void StartUpdatefacility()
        {
            try
            {
                Process.Start(@"C:\TestSuite_REPOS\facility_TestSuite\Scripts\SVNUpdate.exe");
            }
            catch
            {
                MessageBox.Show("Please select a valid version");
            }
            /*
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"C:\TestSuite_REPOS\facility_TestSuite\Scripts\SVNUpdate.exe";
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.EnableRaisingEvents = true;
            proc.Start();
            //this.Close(); 
            */
        }
        private void StartUpdateGuinea()
        {
            try
            {
                Process.Start(@"C:\TestSuite_REPOS\GUINEA_TestSuite\Scripts\SVNUpdate.exe");
            }
            catch
            {
                MessageBox.Show("Please select a valid version");
            }
           
           /*
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"C:\TestSuite_REPOS\GUINEA_TestSuite\Scripts\SVNUpdate.exe";
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.EnableRaisingEvents = true;
            proc.Start();
            //this.Close();
            */
        }
        private void StartSharepoint()
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "iexplore.exe",
                Arguments = " \"http://sharepoint.company.com/sites/hsrservices/Repair%20Depot%20Documentation/Forms/AllItems.aspx\""
            });
        }
        private void StartCheckoutGuinea()
        {
            try
            {
                var dir = new DirectoryInfo(@"C:\TestSuite_REPOS\GUINEA_TestSuite");
                dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                dir.Delete(true);
            }
            catch (IOException ex)
            {
            }
            try
            {
                Process.Start(@"\\share.domain.company.com\appdir\SVN Installation\Documentation and Tools\scripts\checkoutGUINEA.bat");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"\\share.domain.company.com\appdir\SVN Installation\Documentation and Tools\scripts\checkoutGUINEA.bat";
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.EnableRaisingEvents = true;
            proc.Start();
            //this.Close(); 
            */
        }
        private void StartCheckoutfacility()
        {
            try
            {
                var dir = new DirectoryInfo(@"C:\TestSuite_REPOS\facility_TestSuite");
                dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                dir.Delete(true);
            }
            catch (IOException ex)
            {
            }
            try
            {
                Process.Start(@"\\share.domain.company.com\appdir\SVN Installation\Documentation and Tools\scripts\checkoutfacility.bat");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           /*System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"\\share.domain.company.com\appdir\SVN Installation\Documentation and Tools\scripts\checkoutfacility.bat";
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.EnableRaisingEvents = true;
            proc.Start();
            //this.Close();*/
        }
        private void NuclearOption()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("TestSuite"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                var dir = new DirectoryInfo(@"C:\TestSuite_REPOS\");
                dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                dir.Delete(true);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                Process.Start(@"\\share.domain.company.com\appdir\SVN Installation\Documentation and Tools\scripts\checkoutGUINEA_facility.bat");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          /*System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"\\share.domain.company.com\appdir\SVN Installation\Documentation and Tools\scripts\checkoutGUINEA_facility.bat";
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.EnableRaisingEvents = true;
            proc.Start();
            //this.Close();*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);        
        }        
        private void button2_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip2.Show(ptLowerLeft); 
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StartERP();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            StartCRM();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            StartVDI();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            StartSharepoint();
        }
        private void Form1_Load(object s, EventArgs e)
        {
        }
        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KillTestSuite();
        }
        private void updateBuildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartUpdateGuinea();
        }
        private void updateGetBOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartUpdatefacility();
        }
        private void nuclearOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuclearOption();
        }
        private void launchBuildEditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartTestSuiteGuinea();
        }
        private void launchGetBOMEditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartTestSuitefacility();
        }
        private void Form1_Resize(object sender, System.EventArgs e)
         {
             if (FormWindowState.Minimized == this.WindowState)
             {
                 this.Hide();
                 notifyIcon1.Visible = true;
             }
         }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Opacity = 100;
            this.Show();
            WindowState = FormWindowState.Normal;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
            this.Opacity = 0;
            this.Hide();
            notifyIcon1.Visible = true;
            e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 100;
            this.Show();
            WindowState = FormWindowState.Normal;
        }
        private void sharepointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartSharepoint();
        }
        private void vDIPortalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartVDI();
        }
        private void CRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCRM();
        }
        private void ERPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartERP();
        }
        private void launchBuildEditionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartTestSuiteGuinea();
        }
        private void launchGetBOMEditionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartTestSuitefacility();
        }
        private void killToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KillTestSuite();
        }
        private void updateBuildEditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartUpdateGuinea();
        }
        private void updateGetBOMEditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartUpdatefacility();
        }
        private void nuclearOptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuclearOption();
        }
    }
}