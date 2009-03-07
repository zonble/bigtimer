namespace BigTimer
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.u_okButton = new System.Windows.Forms.Button();
			this.u_titleLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// u_okButton
			// 
			this.u_okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.u_okButton, "u_okButton");
			this.u_okButton.Name = "u_okButton";
			this.u_okButton.UseVisualStyleBackColor = true;
			this.u_okButton.Click += new System.EventHandler(this.Close);
			// 
			// u_titleLabel
			// 
			resources.ApplyResources(this.u_titleLabel, "u_titleLabel");
			this.u_titleLabel.Name = "u_titleLabel";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// AboutForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.u_okButton;
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.u_titleLabel);
			this.Controls.Add(this.u_okButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button u_okButton;
		private System.Windows.Forms.Label u_titleLabel;
		private System.Windows.Forms.Label label1;
	}
}