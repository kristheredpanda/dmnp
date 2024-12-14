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
using System.Windows.Forms.VisualStyles;

namespace test1
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
            fastColoredTextBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, fastColoredTextBox1.Width, fastColoredTextBox1.Height, 10, 10));
            settingsbtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, settingsbtn.Width, settingsbtn.Height, 10, 10));
            clearbtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, clearbtn.Width, clearbtn.Height, 10, 10));
            ofbtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ofbtn.Width, ofbtn.Height, 10, 10));
            sfbtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, sfbtn.Width, sfbtn.Height, 10, 10));
            abtbtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, abtbtn.Width, abtbtn.Height, 10, 10));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formiconpb.Image = this.Icon.ToBitmap();
            formtitlelbl.Text = this.Text + " - Untitled";
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

        private void clearbtn_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
            formtitlelbl.Text = this.Text + " - Untitled";
        }

        private void ofbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.DefaultExt = "txt";
            ofd.RestoreDirectory = true;
            ofd.Title = this.Text + " - Open File";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Text = File.ReadAllText(ofd.FileName);
                formtitlelbl.Text = this.Text + " - " + ofd.FileName;
            }
        }

        private void sfbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = this.Text + " - Save File";
            sfd.CheckPathExists = true;
            sfd.DefaultExt = "txt";
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);

                sw.Write(fastColoredTextBox1.Text);
                sw.Close();

                formtitlelbl.Text = this.Text + " - " + sfd.FileName;
            }
        }

        private void abtbtn_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            //settings s = new settings();
            //s.Show();

            MessageBox.Show("Settings currently disabled due to not being finished.\nShould be enabled in the next update.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
