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
            this.Submit = new System.Windows.Forms.Button();
            this.RadDock = new System.Windows.Forms.NotifyIcon(this.components);
            this.RadDockMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Update = new System.Windows.Forms.Button();
            this.TableFormView = new System.Windows.Forms.DataGridView();
            this.ProgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Browser = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableFormView)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Submit.Location = new System.Drawing.Point(91, 282);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
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
            this.Update.Location = new System.Drawing.Point(13, 282);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(72, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // TableFormView
            // 
            this.TableFormView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableFormView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgName,
            this.Path,
            this.Browser});
            this.TableFormView.Location = new System.Drawing.Point(13, 12);
            this.TableFormView.Name = "TableFormView";
            this.TableFormView.Size = new System.Drawing.Size(734, 264);
            this.TableFormView.TabIndex = 2;
            // 
            // ProgName
            // 
            this.ProgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProgName.HeaderText = "Program Name";
            this.ProgName.Name = "ProgName";
            this.ProgName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProgName.Width = 102;
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Path.HeaderText = "Program Path";
            this.Path.MinimumWidth = 15;
            this.Path.Name = "Path";
            // 
            // Browser
            // 
            this.Browser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Browser.HeaderText = "Browser";
            this.Browser.Name = "Browser";
            this.Browser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Browser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Browser.Width = 70;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(759, 317);
            this.Controls.Add(this.TableFormView);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Submit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.ShowInTaskbar = false;
            this.Text = "RadDock - Edit";
            ((System.ComponentModel.ISupportInitialize)(this.TableFormView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Submit;
		private System.Windows.Forms.ContextMenuStrip RadDockMenu;
		private System.Windows.Forms.NotifyIcon RadDock;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.DataGridView TableFormView;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProgName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Path;
		private System.Windows.Forms.DataGridViewComboBoxColumn Browser;
	}
}

