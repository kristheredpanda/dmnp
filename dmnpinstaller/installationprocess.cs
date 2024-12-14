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
    public partial class installationprocess : Form
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

        public installationprocess()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        string installdirectory = "C:\\Program Files\\DarkMODE Notepad";
        private void installationprocess_Load(object sender, EventArgs e)
        {
            formiconpb.Image = this.Icon.ToBitmap();
            formtitlelbl.Text = this.Text;
            label3.Text = "";
            progressBarTimer.Start();

            File.WriteAllBytes(installdirectory + "\\FastColoredTextBox.dll", Properties.Resources.FastColoredTextBox);
            File.WriteAllBytes(installdirectory + "\\app.exe", Properties.Resources.darkmodenotepad);

            label3.Text = "Copying FastColoredTextBox.dll to C:\\Program Files\\DarkMODE Notepad\\FastColoredTextBox.dll";
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

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
                this.Text = "Installing 'DarkMODE Notepad' " + progressBar1.Value + "%";
                formtitlelbl.Text = this.Text;
                label2.Text = progressBar1.Value + "%";
            }
            else if (progressBar1.Value == 100)
            {
                timer1.Start();
                progressBarTimer.Stop();
            }

            if (progressBar1.Value > 37)
            {
                label3.Text = "Copying app.exe to C:\\Program Files\\DarkMODE Notepad\\app.exe";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();

            Form1 f1 = new Form1();
            f1.Hide();
            
            installationfinished i = new installationfinished();
            i.Show();

            timer1.Stop();
        }
    }
}
