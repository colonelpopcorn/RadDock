namespace WindowsFormsApplication1
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.TestSuite = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.ERP = new System.Windows.Forms.Button();
            this.Gay = new System.Windows.Forms.Button();
            this.VDIPortal = new System.Windows.Forms.Button();
            this.Sharepoint = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.launchBuildEditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchGetBOMEditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateGetBOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuclearOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TestSuiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ERPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vDIPortalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharepointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchBuildEditionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.launchGetBOMEditionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBuildEditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateGetBOMEditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuclearOptionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestSuite
            // 
            this.TestSuite.Image = global::RadDock.Properties.Resources._1downarrow;
            this.TestSuite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TestSuite.Location = new System.Drawing.Point(12, 12);
            this.TestSuite.Name = "TestSuite";
            this.TestSuite.Size = new System.Drawing.Size(75, 23);
            this.TestSuite.TabIndex = 0;
            this.TestSuite.Text = "TestSuite";
            this.TestSuite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestSuite.UseVisualStyleBackColor = true;
            this.TestSuite.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.Update.Image = global::RadDock.Properties.Resources._1downarrow;
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Update.Location = new System.Drawing.Point(93, 12);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button2_Click);
            // 
            // ERP
            // 
            this.ERP.Location = new System.Drawing.Point(174, 13);
            this.ERP.Name = "ERP";
            this.ERP.Size = new System.Drawing.Size(75, 23);
            this.ERP.TabIndex = 2;
            this.ERP.Text = "ERP";
            this.ERP.UseVisualStyleBackColor = true;
            this.ERP.Click += new System.EventHandler(this.button3_Click);
            // 
            // Gay
            // 
            this.Gay.Location = new System.Drawing.Point(255, 13);
            this.Gay.Name = "Gay";
            this.Gay.Size = new System.Drawing.Size(75, 23);
            this.Gay.TabIndex = 3;
            this.Gay.Text = "CRM";
            this.Gay.UseVisualStyleBackColor = true;
            this.Gay.Click += new System.EventHandler(this.button4_Click);
            // 
            // VDIPortal
            // 
            this.VDIPortal.Location = new System.Drawing.Point(336, 13);
            this.VDIPortal.Name = "VDIPortal";
            this.VDIPortal.Size = new System.Drawing.Size(75, 23);
            this.VDIPortal.TabIndex = 4;
            this.VDIPortal.Text = "VDI Portal";
            this.VDIPortal.UseVisualStyleBackColor = true;
            this.VDIPortal.Click += new System.EventHandler(this.button5_Click);
            // 
            // Sharepoint
            // 
            this.Sharepoint.Location = new System.Drawing.Point(417, 13);
            this.Sharepoint.Name = "Sharepoint";
            this.Sharepoint.Size = new System.Drawing.Size(75, 23);
            this.Sharepoint.TabIndex = 6;
            this.Sharepoint.Text = "Sharepoint";
            this.Sharepoint.UseVisualStyleBackColor = true;
            this.Sharepoint.Click += new System.EventHandler(this.button6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchBuildEditionToolStripMenuItem,
            this.launchGetBOMEditionToolStripMenuItem,
            this.killToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 70);
            // 
            // launchBuildEditionToolStripMenuItem
            // 
            this.launchBuildEditionToolStripMenuItem.Name = "launchBuildEditionToolStripMenuItem";
            this.launchBuildEditionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.launchBuildEditionToolStripMenuItem.Text = "Launch Build Edition";
            this.launchBuildEditionToolStripMenuItem.Click += new System.EventHandler(this.launchBuildEditionToolStripMenuItem_Click);
            // 
            // launchGetBOMEditionToolStripMenuItem
            // 
            this.launchGetBOMEditionToolStripMenuItem.Name = "launchGetBOMEditionToolStripMenuItem";
            this.launchGetBOMEditionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.launchGetBOMEditionToolStripMenuItem.Text = "Launch GetBOM Edition";
            this.launchGetBOMEditionToolStripMenuItem.Click += new System.EventHandler(this.launchGetBOMEditionToolStripMenuItem_Click);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.killToolStripMenuItem.Text = "Kill";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateBuildToolStripMenuItem,
            this.updateGetBOMToolStripMenuItem,
            this.nuclearOptionToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(201, 70);
            // 
            // updateBuildToolStripMenuItem
            // 
            this.updateBuildToolStripMenuItem.Name = "updateBuildToolStripMenuItem";
            this.updateBuildToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.updateBuildToolStripMenuItem.Text = "Update Build Edition";
            this.updateBuildToolStripMenuItem.Click += new System.EventHandler(this.updateBuildToolStripMenuItem_Click);
            // 
            // updateGetBOMToolStripMenuItem
            // 
            this.updateGetBOMToolStripMenuItem.Name = "updateGetBOMToolStripMenuItem";
            this.updateGetBOMToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.updateGetBOMToolStripMenuItem.Text = "Update GetBOM Edition";
            this.updateGetBOMToolStripMenuItem.Click += new System.EventHandler(this.updateGetBOMToolStripMenuItem_Click);
            // 
            // nuclearOptionToolStripMenuItem
            // 
            this.nuclearOptionToolStripMenuItem.Name = "nuclearOptionToolStripMenuItem";
            this.nuclearOptionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.nuclearOptionToolStripMenuItem.Text = "Nuclear Option";
            this.nuclearOptionToolStripMenuItem.Click += new System.EventHandler(this.nuclearOptionToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip3;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RadDock";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestSuiteToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.ERPToolStripMenuItem,
            this.CRMToolStripMenuItem,
            this.vDIPortalToolStripMenuItem,
            this.sharepointToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(153, 208);
            // 
            // TestSuiteToolStripMenuItem
            // 
            this.TestSuiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchBuildEditionToolStripMenuItem1,
            this.launchGetBOMEditionToolStripMenuItem1,
            this.killToolStripMenuItem1});
            this.TestSuiteToolStripMenuItem.Name = "TestSuiteToolStripMenuItem";
            this.TestSuiteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.TestSuiteToolStripMenuItem.Text = "TestSuite";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateBuildEditionToolStripMenuItem,
            this.updateGetBOMEditionToolStripMenuItem,
            this.nuclearOptionToolStripMenuItem1});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // ERPToolStripMenuItem
            // 
            this.ERPToolStripMenuItem.Name = "ERPToolStripMenuItem";
            this.ERPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ERPToolStripMenuItem.Text = "ERP";
            this.ERPToolStripMenuItem.Click += new System.EventHandler(this.ERPToolStripMenuItem_Click);
            // 
            // CRMToolStripMenuItem
            // 
            this.CRMToolStripMenuItem.Name = "CRMToolStripMenuItem";
            this.CRMToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CRMToolStripMenuItem.Text = "CRM";
            this.CRMToolStripMenuItem.Click += new System.EventHandler(this.CRMToolStripMenuItem_Click);
            // 
            // vDIPortalToolStripMenuItem
            // 
            this.vDIPortalToolStripMenuItem.Name = "vDIPortalToolStripMenuItem";
            this.vDIPortalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vDIPortalToolStripMenuItem.Text = "VDI Portal";
            this.vDIPortalToolStripMenuItem.Click += new System.EventHandler(this.vDIPortalToolStripMenuItem_Click);
            // 
            // sharepointToolStripMenuItem
            // 
            this.sharepointToolStripMenuItem.Name = "sharepointToolStripMenuItem";
            this.sharepointToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sharepointToolStripMenuItem.Text = "Sharepoint";
            this.sharepointToolStripMenuItem.Click += new System.EventHandler(this.sharepointToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // launchBuildEditionToolStripMenuItem1
            // 
            this.launchBuildEditionToolStripMenuItem1.Name = "launchBuildEditionToolStripMenuItem1";
            this.launchBuildEditionToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.launchBuildEditionToolStripMenuItem1.Text = "Launch Build Edition";
            this.launchBuildEditionToolStripMenuItem1.Click += new System.EventHandler(this.launchBuildEditionToolStripMenuItem1_Click);
            // 
            // launchGetBOMEditionToolStripMenuItem1
            // 
            this.launchGetBOMEditionToolStripMenuItem1.Name = "launchGetBOMEditionToolStripMenuItem1";
            this.launchGetBOMEditionToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.launchGetBOMEditionToolStripMenuItem1.Text = "Launch GetBOM Edition";
            this.launchGetBOMEditionToolStripMenuItem1.Click += new System.EventHandler(this.launchGetBOMEditionToolStripMenuItem1_Click);
            // 
            // killToolStripMenuItem1
            // 
            this.killToolStripMenuItem1.Name = "killToolStripMenuItem1";
            this.killToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.killToolStripMenuItem1.Text = "Kill";
            this.killToolStripMenuItem1.Click += new System.EventHandler(this.killToolStripMenuItem1_Click);
            // 
            // updateBuildEditionToolStripMenuItem
            // 
            this.updateBuildEditionToolStripMenuItem.Name = "updateBuildEditionToolStripMenuItem";
            this.updateBuildEditionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.updateBuildEditionToolStripMenuItem.Text = "Update Build Edition";
            this.updateBuildEditionToolStripMenuItem.Click += new System.EventHandler(this.updateBuildEditionToolStripMenuItem_Click);
            // 
            // updateGetBOMEditionToolStripMenuItem
            // 
            this.updateGetBOMEditionToolStripMenuItem.Name = "updateGetBOMEditionToolStripMenuItem";
            this.updateGetBOMEditionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.updateGetBOMEditionToolStripMenuItem.Text = "Update GetBOM Edition";
            this.updateGetBOMEditionToolStripMenuItem.Click += new System.EventHandler(this.updateGetBOMEditionToolStripMenuItem_Click);
            // 
            // nuclearOptionToolStripMenuItem1
            // 
            this.nuclearOptionToolStripMenuItem1.Name = "nuclearOptionToolStripMenuItem1";
            this.nuclearOptionToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.nuclearOptionToolStripMenuItem1.Text = "Nuclear Option";
            this.nuclearOptionToolStripMenuItem1.Click += new System.EventHandler(this.nuclearOptionToolStripMenuItem1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 44);
            this.Controls.Add(this.Sharepoint);
            this.Controls.Add(this.VDIPortal);
            this.Controls.Add(this.Gay);
            this.Controls.Add(this.ERP);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.TestSuite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RadDock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestSuite;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button ERP;
        private System.Windows.Forms.Button Gay;
        private System.Windows.Forms.Button VDIPortal;
        private System.Windows.Forms.Button Sharepoint;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchBuildEditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchGetBOMEditionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem updateBuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateGetBOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuclearOptionToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem TestSuiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchBuildEditionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem launchGetBOMEditionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBuildEditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateGetBOMEditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuclearOptionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ERPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CRMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vDIPortalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharepointToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

