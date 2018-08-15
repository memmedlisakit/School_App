namespace School.Pages
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuUser = new System.Windows.Forms.MenuStrip();
            this.quationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStuProfile = new System.Windows.Forms.GroupBox();
            this.ckbFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ckbMale = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label01 = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.pctMain = new System.Windows.Forms.PictureBox();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.menuUser.SuspendLayout();
            this.grpStuProfile.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMain)).BeginInit();
            this.pnlAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuUser
            // 
            this.menuUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quationToolStripMenuItem,
            this.ticketToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuUser.Location = new System.Drawing.Point(0, 0);
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(1370, 28);
            this.menuUser.TabIndex = 0;
            this.menuUser.Text = "menuStrip1";
            // 
            // quationToolStripMenuItem
            // 
            this.quationToolStripMenuItem.Name = "quationToolStripMenuItem";
            this.quationToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.quationToolStripMenuItem.Text = "Suallar";
            this.quationToolStripMenuItem.Click += new System.EventHandler(this.QuationClick);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.ticketToolStripMenuItem.Text = "Biletlər";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.TicketClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.aboutToolStripMenuItem.Text = "Haqqimizda";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.profileToolStripMenuItem.Text = "Öz səhifəm";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.UpdateProfile);
            // 
            // grpStuProfile
            // 
            this.grpStuProfile.Controls.Add(this.ckbFemale);
            this.grpStuProfile.Controls.Add(this.label5);
            this.grpStuProfile.Controls.Add(this.txtEmail);
            this.grpStuProfile.Controls.Add(this.label1);
            this.grpStuProfile.Controls.Add(this.txtSurname);
            this.grpStuProfile.Controls.Add(this.label2);
            this.grpStuProfile.Controls.Add(this.txtName);
            this.grpStuProfile.Controls.Add(this.ckbMale);
            this.grpStuProfile.Font = new System.Drawing.Font("MilitaryID", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStuProfile.Location = new System.Drawing.Point(3, 44);
            this.grpStuProfile.Name = "grpStuProfile";
            this.grpStuProfile.Size = new System.Drawing.Size(960, 238);
            this.grpStuProfile.TabIndex = 4;
            this.grpStuProfile.TabStop = false;
            this.grpStuProfile.Text = "Səhifəm";
            this.grpStuProfile.Visible = false;
            // 
            // ckbFemale
            // 
            this.ckbFemale.AutoSize = true;
            this.ckbFemale.Enabled = false;
            this.ckbFemale.Location = new System.Drawing.Point(835, 172);
            this.ckbFemale.Name = "ckbFemale";
            this.ckbFemale.Size = new System.Drawing.Size(67, 20);
            this.ckbFemale.TabIndex = 14;
            this.ckbFemale.TabStop = true;
            this.ckbFemale.Text = "Qadın";
            this.ckbFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(671, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(674, 80);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 30);
            this.txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(370, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Soyad:";
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(373, 80);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(230, 30);
            this.txtSurname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(54, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(57, 80);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 30);
            this.txtName.TabIndex = 1;
            // 
            // ckbMale
            // 
            this.ckbMale.AutoSize = true;
            this.ckbMale.Enabled = false;
            this.ckbMale.Location = new System.Drawing.Point(664, 167);
            this.ckbMale.Name = "ckbMale";
            this.ckbMale.Size = new System.Drawing.Size(52, 20);
            this.ckbMale.TabIndex = 2;
            this.ckbMale.TabStop = true;
            this.ckbMale.Text = "Kişi";
            this.ckbMale.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("MilitaryID", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(112, 28);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(738, 48);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "\"Təhsilsiz sürücü olmasın, yol qəzalarında insanlar ölməsin\" və \"Yol Hərəkəti \r\nQ" +
    "aydalarını bizimlə ÖYRƏNİN, çünki Biz sadəcə dərs demirik, ÖYRƏDİRİK\"";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Font = new System.Drawing.Font("MilitaryID", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label01.ForeColor = System.Drawing.Color.Black;
            this.label01.Location = new System.Drawing.Point(3, 10);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(1081, 390);
            this.label01.TabIndex = 5;
            this.label01.Text = resources.GetString("label01.Text");
            this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.pctMain);
            this.grpInfo.Controls.Add(this.lblInfo);
            this.grpInfo.Font = new System.Drawing.Font("MilitaryID", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(1102, 58);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(963, 571);
            this.grpInfo.TabIndex = 26;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Əsas Səhifə";
            // 
            // pctMain
            // 
            this.pctMain.Location = new System.Drawing.Point(70, 90);
            this.pctMain.Name = "pctMain";
            this.pctMain.Size = new System.Drawing.Size(825, 451);
            this.pctMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMain.TabIndex = 1;
            this.pctMain.TabStop = false;
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.label6);
            this.pnlAbout.Controls.Add(this.label01);
            this.pnlAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAbout.Location = new System.Drawing.Point(3, 288);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(1093, 552);
            this.pnlAbout.TabIndex = 27;
            this.pnlAbout.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(291, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(497, 56);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yol Hərəkəti Qaydalarını bizimlə ÖYRƏNİN, çünki\r\nBiz sadəcə dərs demirik, ÖYRƏDİR" +
    "İK";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpStuProfile);
            this.Controls.Add(this.menuUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuUser;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Resize += new System.EventHandler(this.FormResize);
            this.menuUser.ResumeLayout(false);
            this.menuUser.PerformLayout();
            this.grpStuProfile.ResumeLayout(false);
            this.grpStuProfile.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMain)).EndInit();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion; 

        private System.Windows.Forms.MenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem quationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpStuProfile;
        private System.Windows.Forms.RadioButton ckbFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton ckbMale;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.PictureBox pctMain;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Label label6;
    }
}