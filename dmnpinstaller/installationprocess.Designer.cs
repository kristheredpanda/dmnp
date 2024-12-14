namespace dmnpinstaller
{
    partial class installationprocess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(installationprocess));
            this.topbarpnl = new System.Windows.Forms.Panel();
            this.formtitlelbl = new System.Windows.Forms.Label();
            this.formiconpb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topbarpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formiconpb)).BeginInit();
            this.SuspendLayout();
            // 
            // topbarpnl
            // 
            this.topbarpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.topbarpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topbarpnl.Controls.Add(this.formtitlelbl);
            this.topbarpnl.Controls.Add(this.formiconpb);
            this.topbarpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbarpnl.Location = new System.Drawing.Point(0, 0);
            this.topbarpnl.Name = "topbarpnl";
            this.topbarpnl.Size = new System.Drawing.Size(539, 26);
            this.topbarpnl.TabIndex = 5;
            this.topbarpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbarpnl_MouseDown);
            // 
            // formtitlelbl
            // 
            this.formtitlelbl.AutoSize = true;
            this.formtitlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formtitlelbl.ForeColor = System.Drawing.Color.White;
            this.formtitlelbl.Location = new System.Drawing.Point(26, 5);
            this.formtitlelbl.Name = "formtitlelbl";
            this.formtitlelbl.Size = new System.Drawing.Size(41, 15);
            this.formtitlelbl.TabIndex = 1;
            this.formtitlelbl.Text = "label1";
            // 
            // formiconpb
            // 
            this.formiconpb.Location = new System.Drawing.Point(4, 4);
            this.formiconpb.Name = "formiconpb";
            this.formiconpb.Size = new System.Drawing.Size(19, 19);
            this.formiconpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.formiconpb.TabIndex = 0;
            this.formiconpb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Installing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 79);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(515, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Copying (file) to (directory)";
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // installationprocess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(539, 128);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topbarpnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "installationprocess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installing \'DarkMODE Notepad\' 0%";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.installationprocess_Load);
            this.topbarpnl.ResumeLayout(false);
            this.topbarpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formiconpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topbarpnl;
        private System.Windows.Forms.Label formtitlelbl;
        private System.Windows.Forms.PictureBox formiconpb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer progressBarTimer;
        private System.Windows.Forms.Timer timer1;
    }
}