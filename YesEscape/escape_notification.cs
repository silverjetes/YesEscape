using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Diagnostics;

namespace YesEscape
{
    public partial class escape_notification : Form
    {
        static int timeLeft = 60;
        public escape_notification()
        {
            InitializeComponent();
            SystemSounds.Exclamation.Play();
            Font = SystemFonts.MessageBoxFont;
            icon.Image = SystemIcons.Exclamation.ToBitmap();
            Icon = SystemIcons.Warning;
            timer.Start();
        }

        private void escape_notification_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void alt_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Dorito())).Start();
            alt.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            Text = "Time left: " + timeLeft.ToString() + "s";

            if (timeLeft == 0)
            {
                timer.Stop();
                new Thread((() => Application.Run(new FakeBSoD()))).Start();
                Hide();
            }
        }
    }
}
