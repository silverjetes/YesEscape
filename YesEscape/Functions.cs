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
    internal class Functions
    {
        [STAThread]
        public static void MessageBoxThread(string text, string caption = "", MessageBoxButtons buttons = 0, MessageBoxIcon icons = 0, MessageBoxDefaultButton defaultButton = 0)
        {
            new Thread(() => MessageBox.Show(text, caption, buttons, icons, defaultButton)).Start();
        }

        public static void CMD(string command)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c " + command,
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }
    }
}
