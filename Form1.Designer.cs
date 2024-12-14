namespace test1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topbarpnl = new System.Windows.Forms.Panel();
            this.appminimizebtn = new System.Windows.Forms.Button();
            this.appexitbtn = new System.Windows.Forms.Button();
            this.formtitlelbl = new System.Windows.Forms.Label();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.ofbtn = new System.Windows.Forms.Button();
            this.sfbtn = new System.Windows.Forms.Button();
            this.abtbtn = new System.Windows.Forms.Button();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.formiconpb = new System.Windows.Forms.PictureBox();
            this.topbarpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
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
            this.topbarpnl.Size = new System.Drawing.Size(1234, 26);
            this.topbarpnl.TabIndex = 0;
            this.topbarpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbarpnl_MouseDown);
            // 
            // appminimizebtn
            // 
            this.appminimizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.appminimizebtn.FlatAppearance.BorderSize = 0;
            this.appminimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appminimizebtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appminimizebtn.ForeColor = System.Drawing.Color.White;
            this.appminimizebtn.Location = new System.Drawing.Point(1178, 0);
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
            this.appexitbtn.Location = new System.Drawing.Point(1205, 0);
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
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fastColoredTextBox1.CaretColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.Silver;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(14, 41);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(1208, 569);
            this.fastColoredTextBox1.TabIndex = 1;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.clearbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.clearbtn.FlatAppearance.BorderSize = 0;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Location = new System.Drawing.Point(14, 623);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(82, 50);
            this.clearbtn.TabIndex = 3;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // ofbtn
            // 
            this.ofbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ofbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ofbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.ofbtn.FlatAppearance.BorderSize = 0;
            this.ofbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ofbtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ofbtn.ForeColor = System.Drawing.Color.White;
            this.ofbtn.Location = new System.Drawing.Point(108, 623);
            this.ofbtn.Name = "ofbtn";
            this.ofbtn.Size = new System.Drawing.Size(125, 50);
            this.ofbtn.TabIndex = 4;
            this.ofbtn.Text = "Open File";
            this.ofbtn.UseVisualStyleBackColor = false;
            this.ofbtn.Click += new System.EventHandler(this.ofbtn_Click);
            // 
            // sfbtn
            // 
            this.sfbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.sfbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sfbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.sfbtn.FlatAppearance.BorderSize = 0;
            this.sfbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfbtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfbtn.ForeColor = System.Drawing.Color.White;
            this.sfbtn.Location = new System.Drawing.Point(244, 623);
            this.sfbtn.Name = "sfbtn";
            this.sfbtn.Size = new System.Drawing.Size(120, 50);
            this.sfbtn.TabIndex = 5;
            this.sfbtn.Text = "Save File";
            this.sfbtn.UseVisualStyleBackColor = false;
            this.sfbtn.Click += new System.EventHandler(this.sfbtn_Click);
            // 
            // abtbtn
            // 
            this.abtbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.abtbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.abtbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.abtbtn.FlatAppearance.BorderSize = 0;
            this.abtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtbtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtbtn.ForeColor = System.Drawing.Color.White;
            this.abtbtn.Location = new System.Drawing.Point(1066, 623);
            this.abtbtn.Name = "abtbtn";
            this.abtbtn.Size = new System.Drawing.Size(95, 50);
            this.abtbtn.TabIndex = 6;
            this.abtbtn.Text = "About";
            this.abtbtn.UseVisualStyleBackColor = false;
            this.abtbtn.Click += new System.EventHandler(this.abtbtn_Click);
            // 
            // settingsbtn
            // 
            this.settingsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.settingsbtn.BackgroundImage = global::test1.Properties.Resources.settings;
            this.settingsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.settingsbtn.FlatAppearance.BorderSize = 0;
            this.settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbtn.Location = new System.Drawing.Point(1172, 623);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Size = new System.Drawing.Size(50, 50);
            this.settingsbtn.TabIndex = 2;
            this.settingsbtn.UseVisualStyleBackColor = false;
            this.settingsbtn.Click += new System.EventHandler(this.settingsbtn_Click);
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
            this.ClientSize = new System.Drawing.Size(1234, 687);
            this.Controls.Add(this.abtbtn);
            this.Controls.Add(this.sfbtn);
            this.Controls.Add(this.ofbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.settingsbtn);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.topbarpnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DarkMODE Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topbarpnl.ResumeLayout(false);
            this.topbarpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formiconpb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topbarpnl;
        private System.Windows.Forms.PictureBox formiconpb;
        private System.Windows.Forms.Label formtitlelbl;
        private System.Windows.Forms.Button appminimizebtn;
        private System.Windows.Forms.Button appexitbtn;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.Button settingsbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button ofbtn;
        private System.Windows.Forms.Button sfbtn;
        private System.Windows.Forms.Button abtbtn;
    }
}

