using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BigTimer
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void Close(object sender, EventArgs e)
		{
			this.Close();
			this.Invalidate();
		}
	}
}