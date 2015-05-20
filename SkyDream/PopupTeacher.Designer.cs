namespace SkyDream
{
    partial class PopupTeacher
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
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.saveButton.Location = new System.Drawing.Point(50, 363);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(90, 30);
			this.saveButton.TabIndex = 10;
			this.saveButton.Text = "추가하기";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(160, 363);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(90, 30);
			this.cancelButton.TabIndex = 11;
			this.cancelButton.Text = "취  소";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 12);
			this.label1.TabIndex = 12;
			this.label1.Text = "이  름*";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 12);
			this.label2.TabIndex = 12;
			this.label2.Text = "나  이*";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(165, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "성  별";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 12);
			this.label4.TabIndex = 5;
			this.label4.Text = "주민등록번호*";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 12);
			this.label5.TabIndex = 6;
			this.label5.Text = "주  소";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(37, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 12);
			this.label6.TabIndex = 7;
			this.label6.Text = "연 락 처*";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox1.Location = new System.Drawing.Point(107, 35);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 23);
			this.textBox1.TabIndex = 0;
			this.textBox1.Leave += new System.EventHandler(this.isCompletedForm);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox2.Location = new System.Drawing.Point(107, 75);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(33, 23);
			this.textBox2.TabIndex = 1;
			this.textBox2.Leave += new System.EventHandler(this.isCompletedForm);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(106, 332);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(92, 16);
			this.checkBox1.TabIndex = 9;
			this.checkBox1.Text = "현재 근무 중";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox3.Location = new System.Drawing.Point(107, 115);
			this.textBox3.MaxLength = 6;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(70, 24);
			this.textBox3.TabIndex = 3;
			this.textBox3.Leave += new System.EventHandler(this.isCompletedForm);
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox4.Location = new System.Drawing.Point(197, 115);
			this.textBox4.MaxLength = 7;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(70, 24);
			this.textBox4.TabIndex = 4;
			this.textBox4.Leave += new System.EventHandler(this.isCompletedForm);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(182, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(11, 12);
			this.label7.TabIndex = 14;
			this.label7.Text = "-";
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox5.Location = new System.Drawing.Point(107, 155);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(160, 23);
			this.textBox5.TabIndex = 5;
			this.textBox5.Leave += new System.EventHandler(this.isCompletedForm);
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox6.Location = new System.Drawing.Point(107, 195);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(160, 47);
			this.textBox6.TabIndex = 6;
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox7.Location = new System.Drawing.Point(107, 286);
			this.textBox7.MaxLength = 50;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(160, 23);
			this.textBox7.TabIndex = 8;
			this.textBox7.Leave += new System.EventHandler(this.isCompletedForm);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(36, 265);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 12);
			this.label9.TabIndex = 19;
			this.label9.Text = "은행계좌*";
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "국민",
            "신한",
            "우리",
            "하나",
            "한국씨티",
            "외환",
            "SC제일",
            "기업",
            "농협",
            "우체국",
            "산업",
            "수협",
            "한국수출입",
            "경남",
            "광주",
            "대구",
            "부산",
            "전북",
            "제주",
            "새마을",
            "신협"});
			this.comboBox2.Location = new System.Drawing.Point(107, 257);
			this.comboBox2.MaxDropDownItems = 2;
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(91, 23);
			this.comboBox2.TabIndex = 7;
			this.comboBox2.Leave += new System.EventHandler(this.isCompletedForm);
			// 
			// comboBox3
			// 
			this.comboBox3.Font = new System.Drawing.Font("굴림", 11F);
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "여자",
            "남자"});
			this.comboBox3.Location = new System.Drawing.Point(207, 75);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(60, 23);
			this.comboBox3.TabIndex = 2;
			// 
			// PopupTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 412);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Name = "PopupTeacher";
			this.Text = "교사 추가하기";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
    }
}