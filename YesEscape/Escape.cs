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
using System.IO;

namespace YesEscape
{
    public partial class Escape : Form
    {
        static Random r = new Random();

        public Escape()
        {
            InitializeComponent();

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            Location = new Point(r.Next(w), r.Next(h));
        }

        private void esc_MouseEnter(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            Location = new Point(r.Next(w), r.Next(h));
        }

        private void esc_MouseClick(object sender, MouseEventArgs e)
        {
            new Thread(box).Start();
            void box()
            {
                MessageBox.Show("YOU WERE HACKING\nTHAT DOESN'T COUNT", ".i.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
