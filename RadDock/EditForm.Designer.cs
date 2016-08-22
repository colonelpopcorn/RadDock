namespace RadDock
{
	partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.RadDock = new System.Windows.Forms.NotifyIcon(this.components);
            this.RadDockMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Update = new System.Windows.Forms.Button();
            this.ProgramTableView = new System.Windows.Forms.DataGridView();
            this.ProgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Browser = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ArgTableView = new System.Windows.Forms.DataGridView();
            this.ArgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArgPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramLabel = new System.Windows.Forms.Label();
            this.ArgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArgTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // RadDock
            // 
            this.RadDock.ContextMenuStrip = this.RadDockMenu;
            this.RadDock.Icon = ((System.Drawing.Icon)(resources.GetObject("RadDock.Icon")));
            this.RadDock.Text = "RadDock";
            this.RadDock.Visible = true;
            // 
            // RadDockMenu
            // 
            this.RadDockMenu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.RadDockMenu.Name = "contextMenuStrip1";
            this.RadDockMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(12, 311);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(72, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ProgramTableView
            // 
            this.ProgramTableView.AllowUserToDeleteRows = false;
            this.ProgramTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProgramTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgName,
            this.Path,
            this.Browser});
            this.ProgramTableView.Location = new System.Drawing.Point(14, 41);
            this.ProgramTableView.Name = "ProgramTableView";
            this.ProgramTableView.Size = new System.Drawing.Size(734, 264);
            this.ProgramTableView.TabIndex = 2;
            // 
            // ProgName
            // 
            this.ProgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProgName.HeaderText = "Program Name";
            this.ProgName.Name = "ProgName";
            this.ProgName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProgName.Width = 94;
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Path.HeaderText = "Resource Path or Parameters";
            this.Path.MinimumWidth = 15;
            this.Path.Name = "Path";
            // 
            // Browser
            // 
            this.Browser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Browser.HeaderText = "Open With...";
            this.Browser.Name = "Browser";
            this.Browser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Browser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Browser.Width = 85;
            // 
            // ArgTableView
            // 
            this.ArgTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArgTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArgName,
            this.ArgPath});
            this.ArgTableView.Location = new System.Drawing.Point(754, 41);
            this.ArgTableView.Name = "ArgTableView";
            this.ArgTableView.Size = new System.Drawing.Size(354, 263);
            this.ArgTableView.TabIndex = 3;
            // 
            // ArgName
            // 
            this.ArgName.HeaderText = "Name of App";
            this.ArgName.Name = "ArgName";
            // 
            // ArgPath
            // 
            this.ArgPath.HeaderText = "Path to App";
            this.ArgPath.Name = "ArgPath";
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = true;
            this.ProgramLabel.Location = new System.Drawing.Point(14, 13);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.Size = new System.Drawing.Size(116, 13);
            this.ProgramLabel.TabIndex = 4;
            this.ProgramLabel.Text = "Programs or Arguments";
            // 
            // ArgLabel
            // 
            this.ArgLabel.AutoSize = true;
            this.ArgLabel.Location = new System.Drawing.Point(754, 12);
            this.ArgLabel.Name = "ArgLabel";
            this.ArgLabel.Size = new System.Drawing.Size(130, 13);
            this.ArgLabel.TabIndex = 5;
            this.ArgLabel.Text = "Argument Accepting Apps";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1134, 346);
            this.Controls.Add(this.ArgLabel);
            this.Controls.Add(this.ProgramLabel);
            this.Controls.Add(this.ArgTableView);
            this.Controls.Add(this.ProgramTableView);
            this.Controls.Add(this.Update);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.ShowInTaskbar = false;
            this.Text = "RadDock - Edit";
            ((System.ComponentModel.ISupportInitialize)(this.ProgramTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArgTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip RadDockMenu;
		private System.Windows.Forms.NotifyIcon RadDock;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.DataGridView ProgramTableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewComboBoxColumn Browser;
        private System.Windows.Forms.DataGridView ArgTableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArgPath;
        private System.Windows.Forms.Label ProgramLabel;
        private System.Windows.Forms.Label ArgLabel;
    }
}

