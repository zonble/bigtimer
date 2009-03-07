using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BigTimer
{
    public partial class BigTimer : Form
    {
        DateTime m_begin;
		TimeSpan m_totalDuration;
        Timer m_timer = new Timer();
        
        public BigTimer()
        {
            InitializeComponent();
            u_stop.Enabled = false;
            u_zero.Enabled = false;
            m_timer = new Timer();
            m_timer.Interval = 100;
            m_timer.Tick += new EventHandler(m_timer_Tick);
        }

        void m_timer_Tick(object sender, EventArgs e)
        {
            // throw new Exception("The method or operation is not implemented.");
            DateTime now = DateTime.Now;
            TimeSpan duration = now - m_begin;
			m_begin = now;
			m_totalDuration += duration;

            string h;
			if (m_totalDuration.Hours < 10)
				h = "0" + m_totalDuration.Hours;
            else
				h = "" + m_totalDuration.Hours;

            string m;
			if (m_totalDuration.Minutes < 10)
				m = "0" + m_totalDuration.Minutes;
            else
				m = "" + m_totalDuration.Minutes;

            string s;
			if (m_totalDuration.Seconds < 10)
				s = "0" + m_totalDuration.Seconds;
            else
				s = "" + m_totalDuration.Seconds;

            string ms;
			int msInt = m_totalDuration.Milliseconds / 10;
            if (msInt < 10)
                ms = "0" + msInt;
            else
                ms = "" + msInt;

            u_show.Text = h + ":" + m + ":" + s + "." + ms;
        }

        private void u_start_Click(object sender, EventArgs e)
        {
            m_begin = DateTime.Now;
            m_timer.Start();
            u_stop.Enabled = true;
            u_start.Enabled = false;
            u_zero.Enabled = false;
        }

        private void u_stop_Click(object sender, EventArgs e)
        {
            m_timer.Stop();
            u_stop.Enabled = false;
            u_start.Enabled = true;
            u_zero.Enabled = true;
        }

        private void u_zero_Click(object sender, EventArgs e)
        {
            u_show.Text = "00:00:00.00";
			m_totalDuration = TimeSpan.Zero;
            u_zero.Enabled = false;
        }

		private void ExitApplication(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void OpenHomepage(object sender, EventArgs e)
		{
			Process process = new Process();
			process.StartInfo.FileName = "http://github.com/zonble/bigtimer/tree/master";
			process.Start();
		}

		private void u_aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.ShowDialog();
		}
    }
}