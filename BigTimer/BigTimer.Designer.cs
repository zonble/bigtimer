namespace BigTimer
{
    partial class BigTimer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigTimer));
			this.u_start = new System.Windows.Forms.Button();
			this.u_stop = new System.Windows.Forms.Button();
			this.u_zero = new System.Windows.Forms.Button();
			this.u_show = new System.Windows.Forms.Label();
			this.u_menuStrip = new System.Windows.Forms.MenuStrip();
			this.u_fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.u_exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.u_editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.u_copyCurrentTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.u_helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.u_homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.u_aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.u_menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// u_start
			// 
			resources.ApplyResources(this.u_start, "u_start");
			this.u_start.Name = "u_start";
			this.u_start.UseVisualStyleBackColor = true;
			this.u_start.Click += new System.EventHandler(this.u_start_Click);
			// 
			// u_stop
			// 
			resources.ApplyResources(this.u_stop, "u_stop");
			this.u_stop.Name = "u_stop";
			this.u_stop.UseVisualStyleBackColor = true;
			this.u_stop.Click += new System.EventHandler(this.u_stop_Click);
			// 
			// u_zero
			// 
			resources.ApplyResources(this.u_zero, "u_zero");
			this.u_zero.Name = "u_zero";
			this.u_zero.UseVisualStyleBackColor = true;
			this.u_zero.Click += new System.EventHandler(this.u_zero_Click);
			// 
			// u_show
			// 
			resources.ApplyResources(this.u_show, "u_show");
			this.u_show.Name = "u_show";
			// 
			// u_menuStrip
			// 
			this.u_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.u_fileToolStripMenuItem,
            this.u_editToolStripMenuItem,
            this.u_helpToolStripMenuItem});
			resources.ApplyResources(this.u_menuStrip, "u_menuStrip");
			this.u_menuStrip.Name = "u_menuStrip";
			this.u_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			// 
			// u_fileToolStripMenuItem
			// 
			this.u_fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.u_exitToolStripMenuItem});
			this.u_fileToolStripMenuItem.Name = "u_fileToolStripMenuItem";
			resources.ApplyResources(this.u_fileToolStripMenuItem, "u_fileToolStripMenuItem");
			// 
			// u_exitToolStripMenuItem
			// 
			this.u_exitToolStripMenuItem.Name = "u_exitToolStripMenuItem";
			resources.ApplyResources(this.u_exitToolStripMenuItem, "u_exitToolStripMenuItem");
			this.u_exitToolStripMenuItem.Click += new System.EventHandler(this.ExitApplication);
			// 
			// u_editToolStripMenuItem
			// 
			this.u_editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.u_copyCurrentTimeToolStripMenuItem});
			this.u_editToolStripMenuItem.Name = "u_editToolStripMenuItem";
			resources.ApplyResources(this.u_editToolStripMenuItem, "u_editToolStripMenuItem");
			// 
			// u_copyCurrentTimeToolStripMenuItem
			// 
			this.u_copyCurrentTimeToolStripMenuItem.Name = "u_copyCurrentTimeToolStripMenuItem";
			resources.ApplyResources(this.u_copyCurrentTimeToolStripMenuItem, "u_copyCurrentTimeToolStripMenuItem");
			// 
			// u_helpToolStripMenuItem
			// 
			this.u_helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.u_homepageToolStripMenuItem,
            this.u_aboutToolStripMenuItem});
			this.u_helpToolStripMenuItem.Name = "u_helpToolStripMenuItem";
			resources.ApplyResources(this.u_helpToolStripMenuItem, "u_helpToolStripMenuItem");
			// 
			// u_homepageToolStripMenuItem
			// 
			this.u_homepageToolStripMenuItem.Name = "u_homepageToolStripMenuItem";
			resources.ApplyResources(this.u_homepageToolStripMenuItem, "u_homepageToolStripMenuItem");
			this.u_homepageToolStripMenuItem.Click += new System.EventHandler(this.OpenHomepage);
			// 
			// u_aboutToolStripMenuItem
			// 
			this.u_aboutToolStripMenuItem.Name = "u_aboutToolStripMenuItem";
			resources.ApplyResources(this.u_aboutToolStripMenuItem, "u_aboutToolStripMenuItem");
			// 
			// BigTimer
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.u_menuStrip);
			this.Controls.Add(this.u_show);
			this.Controls.Add(this.u_zero);
			this.Controls.Add(this.u_stop);
			this.Controls.Add(this.u_start);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.u_menuStrip;
			this.MaximizeBox = false;
			this.Name = "BigTimer";
			this.u_menuStrip.ResumeLayout(false);
			this.u_menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button u_start;
        private System.Windows.Forms.Button u_stop;
        private System.Windows.Forms.Button u_zero;
        private System.Windows.Forms.Label u_show;
		private System.Windows.Forms.MenuStrip u_menuStrip;
		private System.Windows.Forms.ToolStripMenuItem u_fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem u_exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem u_editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem u_copyCurrentTimeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem u_helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem u_homepageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem u_aboutToolStripMenuItem;
    }
}

