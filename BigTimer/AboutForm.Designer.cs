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
			this.u_okButton = new System.Windows.Forms.Button();
			this.u_titleLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// u_okButton
			// 
			this.u_okButton.Location = new System.Drawing.Point(173, 99);
			this.u_okButton.Name = "u_okButton";
			this.u_okButton.Size = new System.Drawing.Size(75, 23);
			this.u_okButton.TabIndex = 0;
			this.u_okButton.Text = "OK";
			this.u_okButton.UseVisualStyleBackColor = true;
			this.u_okButton.Click += new System.EventHandler(this.Close);
			// 
			// u_titleLabel
			// 
			this.u_titleLabel.AutoSize = true;
			this.u_titleLabel.Location = new System.Drawing.Point(13, 13);
			this.u_titleLabel.Name = "u_titleLabel";
			this.u_titleLabel.Size = new System.Drawing.Size(48, 13);
			this.u_titleLabel.TabIndex = 1;
			this.u_titleLabel.Text = "BigTimer";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "by Weizhong Yang";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 134);
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
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button u_okButton;
		private System.Windows.Forms.Label u_titleLabel;
		private System.Windows.Forms.Label label1;
	}
}