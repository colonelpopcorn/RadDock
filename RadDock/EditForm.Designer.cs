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
			this.SuspendLayout();
			// 
			// Submit
			// 
			this.Submit.Cursor = System.Windows.Forms.Cursors.Default;
			this.Submit.Location = new System.Drawing.Point(672, 282);
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
			this.RadDockMenu.Size = new System.Drawing.Size(153, 26);
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(759, 317);
			this.Controls.Add(this.Submit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditForm";
			this.ShowInTaskbar = false;
			this.Text = "RadDock - Edit";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Submit;
		private System.Windows.Forms.ContextMenuStrip RadDockMenu;
		private System.Windows.Forms.NotifyIcon RadDock;
	}
}

