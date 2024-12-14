using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dmnpinstaller
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public class NativeMethods
        {
            [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
            public static extern bool ReleaseCapture();

            [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            startbtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, startbtn.Width, startbtn.Height, 10, 10));
            creditsbtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, creditsbtn.Width, creditsbtn.Height, 10, 10));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formiconpb.Image = this.Icon.ToBitmap();
            formtitlelbl.Text = this.Text;
        }

        #region TopPanel

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void topbarpnl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void appexitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void appminimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void creditsbtn_Click(object sender, EventArgs e)
        {
            credits c = new credits();
            c.Show();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\Program Files\\DarkMODE Notepad");

            installationprocess ip = new installationprocess();
            ip.Show();

            startbtn.Enabled = false;
            creditsbtn.Enabled = false;
            appexitbtn.Enabled = false;
            appminimizebtn.Enabled = false;
        }
    }
}
