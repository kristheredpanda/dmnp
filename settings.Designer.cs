namespace test1
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.topbarpnl = new System.Windows.Forms.Panel();
            this.appminimizebtn = new System.Windows.Forms.Button();
            this.appexitbtn = new System.Windows.Forms.Button();
            this.formtitlelbl = new System.Windows.Forms.Label();
            this.scbtn = new System.Windows.Forms.Button();
            this.formiconpb = new System.Windows.Forms.PictureBox();
            this.topbarpnl.SuspendLayout();
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
            this.topbarpnl.Size = new System.Drawing.Size(330, 26);
            this.topbarpnl.TabIndex = 2;
            this.topbarpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbarpnl_MouseDown);
            // 
            // appminimizebtn
            // 
            this.appminimizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.appminimizebtn.FlatAppearance.BorderSize = 0;
            this.appminimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appminimizebtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appminimizebtn.ForeColor = System.Drawing.Color.White;
            this.appminimizebtn.Location = new System.Drawing.Point(274, 0);
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
            this.appexitbtn.Location = new System.Drawing.Point(301, 0);
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
            // scbtn
            // 
            this.scbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.scbtn.FlatAppearance.BorderSize = 0;
            this.scbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scbtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scbtn.ForeColor = System.Drawing.Color.White;
            this.scbtn.Location = new System.Drawing.Point(13, 436);
            this.scbtn.Name = "scbtn";
            this.scbtn.Size = new System.Drawing.Size(305, 30);
            this.scbtn.TabIndex = 4;
            this.scbtn.Text = "Save changes";
            this.scbtn.UseVisualStyleBackColor = false;
            this.scbtn.Click += new System.EventHandler(this.scbtn_Click);
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
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(330, 478);
            this.Controls.Add(this.scbtn);
            this.Controls.Add(this.topbarpnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.topbarpnl.ResumeLayout(false);
            this.topbarpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formiconpb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topbarpnl;
        private System.Windows.Forms.Button appminimizebtn;
        private System.Windows.Forms.Button appexitbtn;
        private System.Windows.Forms.Label formtitlelbl;
        private System.Windows.Forms.PictureBox formiconpb;
        private System.Windows.Forms.Button scbtn;
    }
}