using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YesEscape
{
    public partial class Dorito : Form
    {
        public Dorito()
        {
            InitializeComponent();
            Icon = SystemIcons.Warning;
            Font = SystemFonts.MessageBoxFont;
        }

        private void Dorito_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void check_Click(object sender, EventArgs e)
        {
            check.Enabled = false;
            icon.Image = SystemIcons.Information.ToBitmap();
            status_label.Text = "Checking...";
            progressBar.Visible = true;

            icon.Refresh();
            status_label.Refresh();
            progressBar.Refresh();

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.PerformStep();
            }
            else
            {
                timer.Stop();

                progressBar.Visible = false;
                progressBar.Value = 0;
                icon.Image = SystemIcons.Warning.ToBitmap();
                status_label.Text = "Dorito not found";
                check.Enabled = true;
            }
        }
    }
}
