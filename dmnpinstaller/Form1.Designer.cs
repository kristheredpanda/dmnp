namespace dmnpinstaller
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topbarpnl = new System.Windows.Forms.Panel();
            this.appminimizebtn = new System.Windows.Forms.Button();
            this.appexitbtn = new System.Windows.Forms.Button();
            this.formtitlelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.creditsbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formiconpb = new System.Windows.Forms.PictureBox();
            this.topbarpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formiconpb)).BeginInit();
            this.SuspendLayout();
            // 
            // topbarpnl
            // 
            this.topbarpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.topbarpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topbarpnl.Controls.Add(this.appminimizebtn);
            this.topbarpnl.Controls.Add(this.appexitbtn);
            this.topbarpnl.Controls.Add(this.formtitlelbl);
            this.topbarpnl.Controls.Add(this.formiconpb);
            this.topbarpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbarpnl.Location = new System.Drawing.Point(0, 0);
            this.topbarpnl.Name = "topbarpnl";
            this.topbarpnl.Size = new System.Drawing.Size(690, 26);
            this.topbarpnl.TabIndex = 3;
            this.topbarpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbarpnl_MouseDown);
            // 
            // appminimizebtn
            // 
            this.appminimizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.appminimizebtn.FlatAppearance.BorderSize = 0;
            this.appminimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appminimizebtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appminimizebtn.ForeColor = System.Drawing.Color.White;
            this.appminimizebtn.Location = new System.Drawing.Point(634, 0);
            this.appminimizebtn.Name = "appminimizebtn";
            this.appminimizebtn.Size = new System.Drawing.Size(27, 24);
            this.appminimizebtn.TabIndex = 3;
            this.appminimizebtn.Text = "-";
            this.appminimizebtn.UseVisualStyleBackColor = true;
            this.appminimizebtn.Click += new System.EventHandler(this.appminimizebtn_Click);
            // 
            // appexitbtn
            // 
            this.appexitbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.appexitbtn.FlatAppearance.BorderSize = 0;
            this.appexitbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.appexitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.appexitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appexitbtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appexitbtn.ForeColor = System.Drawing.Color.White;
            this.appexitbtn.Location = new System.Drawing.Point(661, 0);
            this.appexitbtn.Name = "appexitbtn";
            this.appexitbtn.Size = new System.Drawing.Size(27, 24);
            this.appexitbtn.TabIndex = 2;
            this.appexitbtn.Text = "X";
            this.appexitbtn.UseVisualStyleBackColor = true;
            this.appexitbtn.Click += new System.EventHandler(this.appexitbtn_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "DarkMODE Notepad Installer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "This will install Version 1.0 of the program";
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.startbtn.FlatAppearance.BorderSize = 0;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.ForeColor = System.Drawing.Color.White;
            this.startbtn.Location = new System.Drawing.Point(572, 549);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(106, 34);
            this.startbtn.TabIndex = 7;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // creditsbtn
            // 
            this.creditsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.creditsbtn.FlatAppearance.BorderSize = 0;
            this.creditsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditsbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsbtn.ForeColor = System.Drawing.Color.White;
            this.creditsbtn.Location = new System.Drawing.Point(202, 550);
            this.creditsbtn.Name = "creditsbtn";
            this.creditsbtn.Size = new System.Drawing.Size(106, 34);
            this.creditsbtn.TabIndex = 8;
            this.creditsbtn.Text = "Credits";
            this.creditsbtn.UseVisualStyleBackColor = false;
            this.creditsbtn.Click += new System.EventHandler(this.creditsbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::dmnpinstaller.Properties.Resources.Notepad_DarkMode;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(690, 596);
            this.Controls.Add(this.creditsbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topbarpnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DarkMODE Notepad Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topbarpnl.ResumeLayout(false);
            this.topbarpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formiconpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topbarpnl;
        private System.Windows.Forms.Button appminimizebtn;
        private System.Windows.Forms.Button appexitbtn;
        private System.Windows.Forms.Label formtitlelbl;
        private System.Windows.Forms.PictureBox formiconpb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button creditsbtn;
    }
}

