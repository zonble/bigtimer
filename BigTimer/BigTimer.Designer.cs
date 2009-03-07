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
			this.SuspendLayout();
			// 
			// u_start
			// 
			this.u_start.AccessibleDescription = null;
			this.u_start.AccessibleName = null;
			resources.ApplyResources(this.u_start, "u_start");
			this.u_start.BackgroundImage = null;
			this.u_start.Name = "u_start";
			this.u_start.UseVisualStyleBackColor = true;
			this.u_start.Click += new System.EventHandler(this.u_start_Click);
			// 
			// u_stop
			// 
			this.u_stop.AccessibleDescription = null;
			this.u_stop.AccessibleName = null;
			resources.ApplyResources(this.u_stop, "u_stop");
			this.u_stop.BackgroundImage = null;
			this.u_stop.Name = "u_stop";
			this.u_stop.UseVisualStyleBackColor = true;
			this.u_stop.Click += new System.EventHandler(this.u_stop_Click);
			// 
			// u_zero
			// 
			this.u_zero.AccessibleDescription = null;
			this.u_zero.AccessibleName = null;
			resources.ApplyResources(this.u_zero, "u_zero");
			this.u_zero.BackgroundImage = null;
			this.u_zero.Name = "u_zero";
			this.u_zero.UseVisualStyleBackColor = true;
			this.u_zero.Click += new System.EventHandler(this.u_zero_Click);
			// 
			// u_show
			// 
			this.u_show.AccessibleDescription = null;
			this.u_show.AccessibleName = null;
			resources.ApplyResources(this.u_show, "u_show");
			this.u_show.Name = "u_show";
			// 
			// BigTimer
			// 
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.Controls.Add(this.u_show);
			this.Controls.Add(this.u_zero);
			this.Controls.Add(this.u_stop);
			this.Controls.Add(this.u_start);
			this.Font = null;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = null;
			this.MaximizeBox = false;
			this.Name = "BigTimer";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button u_start;
        private System.Windows.Forms.Button u_stop;
        private System.Windows.Forms.Button u_zero;
        private System.Windows.Forms.Label u_show;
    }
}

