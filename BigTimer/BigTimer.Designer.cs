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
            this.u_start = new System.Windows.Forms.Button();
            this.u_stop = new System.Windows.Forms.Button();
            this.u_zero = new System.Windows.Forms.Button();
            this.u_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // u_start
            // 
            this.u_start.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.u_start.Location = new System.Drawing.Point(12, 84);
            this.u_start.Name = "u_start";
            this.u_start.Size = new System.Drawing.Size(355, 52);
            this.u_start.TabIndex = 0;
            this.u_start.Text = "開始";
            this.u_start.UseVisualStyleBackColor = true;
            this.u_start.Click += new System.EventHandler(this.u_start_Click);
            // 
            // u_stop
            // 
            this.u_stop.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.u_stop.Location = new System.Drawing.Point(12, 142);
            this.u_stop.Name = "u_stop";
            this.u_stop.Size = new System.Drawing.Size(355, 52);
            this.u_stop.TabIndex = 1;
            this.u_stop.Text = "停止";
            this.u_stop.UseVisualStyleBackColor = true;
            this.u_stop.Click += new System.EventHandler(this.u_stop_Click);
            // 
            // u_zero
            // 
            this.u_zero.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.u_zero.Location = new System.Drawing.Point(12, 200);
            this.u_zero.Name = "u_zero";
            this.u_zero.Size = new System.Drawing.Size(355, 52);
            this.u_zero.TabIndex = 2;
            this.u_zero.Text = "歸零";
            this.u_zero.UseVisualStyleBackColor = true;
            this.u_zero.Click += new System.EventHandler(this.u_zero_Click);
            // 
            // u_show
            // 
            this.u_show.AutoSize = true;
            this.u_show.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_show.Location = new System.Drawing.Point(12, 9);
            this.u_show.Name = "u_show";
            this.u_show.Size = new System.Drawing.Size(372, 72);
            this.u_show.TabIndex = 3;
            this.u_show.Text = "00:00:00.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 269);
            this.Controls.Add(this.u_show);
            this.Controls.Add(this.u_zero);
            this.Controls.Add(this.u_stop);
            this.Controls.Add(this.u_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "大計時器";
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

