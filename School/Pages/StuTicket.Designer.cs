namespace School.Pages
{
    partial class StuTicket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbTicket = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.txtTicketNum = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.grpQuations = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pctTicket = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpAnswers.SuspendLayout();
            this.grpQuations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.cmbTicket);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 194);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Surname:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSurname.Location = new System.Drawing.Point(86, 53);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(40, 18);
            this.lblSurname.TabIndex = 39;
            this.lblSurname.Text = "gfhgf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblName.Location = new System.Drawing.Point(66, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 18);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "hgfd";
            // 
            // cmbTicket
            // 
            this.cmbTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTicket.FormattingEnabled = true;
            this.cmbTicket.Location = new System.Drawing.Point(9, 137);
            this.cmbTicket.Name = "cmbTicket";
            this.cmbTicket.Size = new System.Drawing.Size(224, 32);
            this.cmbTicket.TabIndex = 43;
            this.cmbTicket.SelectedIndexChanged += new System.EventHandler(this.cmbTicket_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(6, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Ticket:";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.ForeColor = System.Drawing.Color.Black;
            this.lblResponse.Location = new System.Drawing.Point(565, 555);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(28, 16);
            this.lblResponse.TabIndex = 52;
            this.lblResponse.Text = "fghf";
            // 
            // grpAnswers
            // 
            this.grpAnswers.Controls.Add(this.btn05);
            this.grpAnswers.Controls.Add(this.btn01);
            this.grpAnswers.Controls.Add(this.btn04);
            this.grpAnswers.Controls.Add(this.btn02);
            this.grpAnswers.Controls.Add(this.btn03);
            this.grpAnswers.Location = new System.Drawing.Point(543, 477);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(478, 64);
            this.grpAnswers.TabIndex = 49;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Answers";
            // 
            // btn05
            // 
            this.btn05.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn05.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn05.Location = new System.Drawing.Point(384, 19);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(42, 30);
            this.btn05.TabIndex = 50;
            this.btn05.Text = "5";
            this.btn05.UseVisualStyleBackColor = true;
            this.btn05.Click += new System.EventHandler(this.btnAnswer);
            // 
            // btn01
            // 
            this.btn01.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn01.Location = new System.Drawing.Point(49, 19);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(42, 30);
            this.btn01.TabIndex = 46;
            this.btn01.Text = "1";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btnAnswer);
            // 
            // btn04
            // 
            this.btn04.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn04.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn04.Location = new System.Drawing.Point(299, 19);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(42, 30);
            this.btn04.TabIndex = 49;
            this.btn04.Text = "4";
            this.btn04.UseVisualStyleBackColor = true;
            this.btn04.Click += new System.EventHandler(this.btnAnswer);
            // 
            // btn02
            // 
            this.btn02.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn02.Location = new System.Drawing.Point(136, 19);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(42, 30);
            this.btn02.TabIndex = 47;
            this.btn02.Text = "2";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btnAnswer);
            // 
            // btn03
            // 
            this.btn03.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn03.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn03.Location = new System.Drawing.Point(218, 19);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(42, 30);
            this.btn03.TabIndex = 48;
            this.btn03.Text = "3";
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.btnAnswer);
            // 
            // txtTicketNum
            // 
            this.txtTicketNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketNum.Location = new System.Drawing.Point(711, 441);
            this.txtTicketNum.Multiline = true;
            this.txtTicketNum.Name = "txtTicketNum";
            this.txtTicketNum.Size = new System.Drawing.Size(128, 30);
            this.txtTicketNum.TabIndex = 51;
            this.txtTicketNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectForNum);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNext.Location = new System.Drawing.Point(845, 441);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(72, 30);
            this.btnNext.TabIndex = 50;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrev.Location = new System.Drawing.Point(633, 441);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(72, 30);
            this.btnPrev.TabIndex = 47;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // grpQuations
            // 
            this.grpQuations.Controls.Add(this.button6);
            this.grpQuations.Controls.Add(this.button7);
            this.grpQuations.Controls.Add(this.button8);
            this.grpQuations.Controls.Add(this.button9);
            this.grpQuations.Controls.Add(this.button10);
            this.grpQuations.Controls.Add(this.button1);
            this.grpQuations.Controls.Add(this.button2);
            this.grpQuations.Controls.Add(this.button3);
            this.grpQuations.Controls.Add(this.button4);
            this.grpQuations.Controls.Add(this.button5);
            this.grpQuations.Location = new System.Drawing.Point(194, 586);
            this.grpQuations.Name = "grpQuations";
            this.grpQuations.Size = new System.Drawing.Size(891, 107);
            this.grpQuations.TabIndex = 51;
            this.grpQuations.TabStop = false;
            this.grpQuations.Text = "Quations";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button6.Location = new System.Drawing.Point(808, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 53);
            this.button6.TabIndex = 55;
            this.button6.Text = "10";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button7.Location = new System.Drawing.Point(461, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 53);
            this.button7.TabIndex = 51;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button8.Location = new System.Drawing.Point(721, 29);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 53);
            this.button8.TabIndex = 54;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button9.Location = new System.Drawing.Point(548, 29);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 53);
            this.button9.TabIndex = 52;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button10.Location = new System.Drawing.Point(634, 29);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 53);
            this.button10.TabIndex = 53;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(374, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 53);
            this.button1.TabIndex = 50;
            this.button1.Text = "5";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(26, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 53);
            this.button2.TabIndex = 46;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(287, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 53);
            this.button3.TabIndex = 49;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Location = new System.Drawing.Point(113, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 53);
            this.button4.TabIndex = 47;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button5.Location = new System.Drawing.Point(200, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 53);
            this.button5.TabIndex = 48;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pctTicket
            // 
            this.pctTicket.Location = new System.Drawing.Point(318, 12);
            this.pctTicket.Name = "pctTicket";
            this.pctTicket.Size = new System.Drawing.Size(873, 407);
            this.pctTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTicket.TabIndex = 48;
            this.pctTicket.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Duration:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDuration.Location = new System.Drawing.Point(86, 88);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(40, 18);
            this.lblDuration.TabIndex = 45;
            this.lblDuration.Text = "15:00";
            // 
            // StuTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 709);
            this.Controls.Add(this.grpQuations);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.grpAnswers);
            this.Controls.Add(this.txtTicketNum);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pctTicket);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.groupBox1);
            this.Name = "StuTicket";
            this.Text = "StuTicket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAnswers.ResumeLayout(false);
            this.grpQuations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbTicket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn03;
        public System.Windows.Forms.TextBox txtTicketNum;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pctTicket;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.GroupBox grpQuations;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label2;
    }
}