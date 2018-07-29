namespace School.Pages
{
    partial class StuQuation
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuationNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuationCount = new System.Windows.Forms.Label();
            this.cmbIncorrectQuations = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pctQuation = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtQuationNum = new System.Windows.Forms.TextBox();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblIncorretCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuation)).BeginInit();
            this.grpAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(548, 36);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(224, 32);
            this.cmbCategory.TabIndex = 34;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryChange);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(545, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "Category:";
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrev.Location = new System.Drawing.Point(418, 552);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(72, 30);
            this.btnPrev.TabIndex = 35;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblQuationNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblQuationCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 146);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Quation Num:";
            // 
            // lblQuationNum
            // 
            this.lblQuationNum.AutoSize = true;
            this.lblQuationNum.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuationNum.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblQuationNum.Location = new System.Drawing.Point(132, 114);
            this.lblQuationNum.Name = "lblQuationNum";
            this.lblQuationNum.Size = new System.Drawing.Size(44, 18);
            this.lblQuationNum.TabIndex = 45;
            this.lblQuationNum.Text = "hghdf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Quation Count:";
            // 
            // lblQuationCount
            // 
            this.lblQuationCount.AutoSize = true;
            this.lblQuationCount.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuationCount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblQuationCount.Location = new System.Drawing.Point(132, 82);
            this.lblQuationCount.Name = "lblQuationCount";
            this.lblQuationCount.Size = new System.Drawing.Size(44, 18);
            this.lblQuationCount.TabIndex = 43;
            this.lblQuationCount.Text = "hghdf";
            // 
            // cmbIncorrectQuations
            // 
            this.cmbIncorrectQuations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncorrectQuations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIncorrectQuations.FormattingEnabled = true;
            this.cmbIncorrectQuations.Location = new System.Drawing.Point(834, 36);
            this.cmbIncorrectQuations.Name = "cmbIncorrectQuations";
            this.cmbIncorrectQuations.Size = new System.Drawing.Size(224, 32);
            this.cmbIncorrectQuations.TabIndex = 42;
            this.cmbIncorrectQuations.SelectedIndexChanged += new System.EventHandler(this.cmbIncorrectQuations_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(831, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Incorrect Quations:";
            // 
            // pctQuation
            // 
            this.pctQuation.Location = new System.Drawing.Point(126, 185);
            this.pctQuation.Name = "pctQuation";
            this.pctQuation.Size = new System.Drawing.Size(873, 346);
            this.pctQuation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctQuation.TabIndex = 43;
            this.pctQuation.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNext.Location = new System.Drawing.Point(630, 552);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(72, 30);
            this.btnNext.TabIndex = 44;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtQuationNum
            // 
            this.txtQuationNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuationNum.Location = new System.Drawing.Point(496, 552);
            this.txtQuationNum.Multiline = true;
            this.txtQuationNum.Name = "txtQuationNum";
            this.txtQuationNum.Size = new System.Drawing.Size(128, 30);
            this.txtQuationNum.TabIndex = 45;
            this.txtQuationNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectForNum);
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
            this.btn01.Click += new System.EventHandler(this.AnswerClick);
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
            this.btn02.Click += new System.EventHandler(this.AnswerClick);
            // 
            // btn03
            // 
            this.btn03.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn03.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn03.Location = new System.Drawing.Point(216, 19);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(42, 30);
            this.btn03.TabIndex = 48;
            this.btn03.Text = "3";
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.AnswerClick);
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
            this.btn04.Click += new System.EventHandler(this.AnswerClick);
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
            this.btn05.Click += new System.EventHandler(this.AnswerClick);
            // 
            // grpAnswers
            // 
            this.grpAnswers.Controls.Add(this.btn05);
            this.grpAnswers.Controls.Add(this.btn01);
            this.grpAnswers.Controls.Add(this.btn04);
            this.grpAnswers.Controls.Add(this.btn02);
            this.grpAnswers.Controls.Add(this.btn03);
            this.grpAnswers.Location = new System.Drawing.Point(328, 588);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(478, 64);
            this.grpAnswers.TabIndex = 44;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Answers";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.ForeColor = System.Drawing.Color.Black;
            this.lblResponse.Location = new System.Drawing.Point(344, 667);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(28, 16);
            this.lblResponse.TabIndex = 46;
            this.lblResponse.Text = "fghf";
            // 
            // lblIncorretCount
            // 
            this.lblIncorretCount.AutoSize = true;
            this.lblIncorretCount.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorretCount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIncorretCount.Location = new System.Drawing.Point(959, 15);
            this.lblIncorretCount.Name = "lblIncorretCount";
            this.lblIncorretCount.Size = new System.Drawing.Size(40, 18);
            this.lblIncorretCount.TabIndex = 46;
            this.lblIncorretCount.Text = "gfhgf";
            // 
            // StuQuation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 732);
            this.Controls.Add(this.lblIncorretCount);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.grpAnswers);
            this.Controls.Add(this.txtQuationNum);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pctQuation);
            this.Controls.Add(this.cmbIncorrectQuations);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label9);
            this.Name = "StuQuation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StuQuation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuation)).EndInit();
            this.grpAnswers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuationCount;
        private System.Windows.Forms.ComboBox cmbIncorrectQuations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pctQuation;
        private System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.TextBox txtQuationNum;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuationNum;
        private System.Windows.Forms.Label lblIncorretCount;
    }
}