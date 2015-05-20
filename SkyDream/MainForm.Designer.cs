namespace SkyDream
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
			this.tabControl = new System.Windows.Forms.TabControl();
			this.studentTab = new System.Windows.Forms.TabPage();
			this.studentTable = new System.Windows.Forms.DataGridView();
			this.addStudentButton = new System.Windows.Forms.Button();
			this.teacherTab = new System.Windows.Forms.TabPage();
			this.teacherTable = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addTeacherButton = new System.Windows.Forms.Button();
			this.classTab = new System.Windows.Forms.TabPage();
			this.addClassButton = new System.Windows.Forms.Button();
			this.classTable = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.attendanceTab = new System.Windows.Forms.TabPage();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.skyDreamManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.familyPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl.SuspendLayout();
			this.studentTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
			this.teacherTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.teacherTable)).BeginInit();
			this.classTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.classTable)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabControl.Controls.Add(this.studentTab);
			this.tabControl.Controls.Add(this.teacherTab);
			this.tabControl.Controls.Add(this.classTab);
			this.tabControl.Location = new System.Drawing.Point(0, 27);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(784, 535);
			this.tabControl.TabIndex = 0;
			this.tabControl.Click += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// studentTab
			// 
			this.studentTab.Controls.Add(this.studentTable);
			this.studentTab.Controls.Add(this.addStudentButton);
			this.studentTab.Location = new System.Drawing.Point(22, 4);
			this.studentTab.Name = "studentTab";
			this.studentTab.Padding = new System.Windows.Forms.Padding(3);
			this.studentTab.Size = new System.Drawing.Size(758, 527);
			this.studentTab.TabIndex = 0;
			this.studentTab.Text = "학생관리";
			this.studentTab.UseVisualStyleBackColor = true;
			// 
			// studentTable
			// 
			this.studentTable.AllowUserToAddRows = false;
			this.studentTable.AllowUserToDeleteRows = false;
			this.studentTable.AllowUserToOrderColumns = true;
			this.studentTable.AllowUserToResizeColumns = false;
			this.studentTable.BackgroundColor = System.Drawing.Color.White;
			this.studentTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.studentTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.studentTable.ColumnHeadersHeight = 25;
			this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.studentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column6,
            this.Column5});
			this.studentTable.Location = new System.Drawing.Point(14, 10);
			this.studentTable.MultiSelect = false;
			this.studentTable.Name = "studentTable";
			this.studentTable.ReadOnly = true;
			this.studentTable.RowHeadersWidth = 40;
			this.studentTable.RowTemplate.Height = 25;
			this.studentTable.RowTemplate.ReadOnly = true;
			this.studentTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.studentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.studentTable.Size = new System.Drawing.Size(730, 450);
			this.studentTable.TabIndex = 3;
			this.studentTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentTable_CellContentDoubleClick);
			// 
			// addStudentButton
			// 
			this.addStudentButton.Location = new System.Drawing.Point(600, 470);
			this.addStudentButton.Name = "addStudentButton";
			this.addStudentButton.Size = new System.Drawing.Size(130, 40);
			this.addStudentButton.TabIndex = 2;
			this.addStudentButton.Text = "학생 추가하기";
			this.addStudentButton.UseVisualStyleBackColor = true;
			this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
			// 
			// teacherTab
			// 
			this.teacherTab.Controls.Add(this.teacherTable);
			this.teacherTab.Controls.Add(this.addTeacherButton);
			this.teacherTab.Location = new System.Drawing.Point(22, 4);
			this.teacherTab.Name = "teacherTab";
			this.teacherTab.Padding = new System.Windows.Forms.Padding(3);
			this.teacherTab.Size = new System.Drawing.Size(758, 527);
			this.teacherTab.TabIndex = 1;
			this.teacherTab.Text = "교사관리";
			this.teacherTab.UseVisualStyleBackColor = true;
			// 
			// teacherTable
			// 
			this.teacherTable.AllowUserToAddRows = false;
			this.teacherTable.AllowUserToDeleteRows = false;
			this.teacherTable.AllowUserToOrderColumns = true;
			this.teacherTable.AllowUserToResizeColumns = false;
			this.teacherTable.BackgroundColor = System.Drawing.Color.White;
			this.teacherTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.teacherTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.teacherTable.ColumnHeadersHeight = 25;
			this.teacherTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.teacherTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
			this.teacherTable.Location = new System.Drawing.Point(14, 10);
			this.teacherTable.MultiSelect = false;
			this.teacherTable.Name = "teacherTable";
			this.teacherTable.ReadOnly = true;
			this.teacherTable.RowHeadersWidth = 40;
			this.teacherTable.RowTemplate.Height = 25;
			this.teacherTable.RowTemplate.ReadOnly = true;
			this.teacherTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.teacherTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.teacherTable.Size = new System.Drawing.Size(730, 450);
			this.teacherTable.TabIndex = 4;
			this.teacherTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherTable_CellContentDoubleClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "이 름";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn1.Width = 120;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "반";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn2.Width = 200;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.HeaderText = "연 락 처";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// addTeacherButton
			// 
			this.addTeacherButton.Location = new System.Drawing.Point(600, 470);
			this.addTeacherButton.Name = "addTeacherButton";
			this.addTeacherButton.Size = new System.Drawing.Size(130, 40);
			this.addTeacherButton.TabIndex = 0;
			this.addTeacherButton.Text = "교사 추가하기";
			this.addTeacherButton.UseVisualStyleBackColor = true;
			this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
			// 
			// classTab
			// 
			this.classTab.Controls.Add(this.addClassButton);
			this.classTab.Controls.Add(this.classTable);
			this.classTab.Location = new System.Drawing.Point(22, 4);
			this.classTab.Name = "classTab";
			this.classTab.Padding = new System.Windows.Forms.Padding(3);
			this.classTab.Size = new System.Drawing.Size(758, 527);
			this.classTab.TabIndex = 2;
			this.classTab.Text = "반관리";
			this.classTab.UseVisualStyleBackColor = true;
			// 
			// addClassButton
			// 
			this.addClassButton.Location = new System.Drawing.Point(600, 470);
			this.addClassButton.Name = "addClassButton";
			this.addClassButton.Size = new System.Drawing.Size(130, 40);
			this.addClassButton.TabIndex = 6;
			this.addClassButton.Text = "반 추가하기";
			this.addClassButton.UseVisualStyleBackColor = true;
			this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
			// 
			// classTable
			// 
			this.classTable.AllowUserToAddRows = false;
			this.classTable.AllowUserToDeleteRows = false;
			this.classTable.AllowUserToOrderColumns = true;
			this.classTable.AllowUserToResizeColumns = false;
			this.classTable.BackgroundColor = System.Drawing.Color.White;
			this.classTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.classTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.classTable.ColumnHeadersHeight = 25;
			this.classTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.classTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column1,
            this.Column2});
			this.classTable.Location = new System.Drawing.Point(14, 10);
			this.classTable.MultiSelect = false;
			this.classTable.Name = "classTable";
			this.classTable.ReadOnly = true;
			this.classTable.RowHeadersWidth = 40;
			this.classTable.RowTemplate.Height = 25;
			this.classTable.RowTemplate.ReadOnly = true;
			this.classTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.classTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.classTable.Size = new System.Drawing.Size(730, 450);
			this.classTable.TabIndex = 5;
			this.classTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classTable_CellContentDoubleClick);
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "반";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn5.Width = 120;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.HeaderText = "담임 선생님";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "교실";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.Width = 120;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "현재 인원";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// attendanceTab
			// 
			this.attendanceTab.Location = new System.Drawing.Point(22, 4);
			this.attendanceTab.Name = "attendanceTab";
			this.attendanceTab.Padding = new System.Windows.Forms.Padding(3);
			this.attendanceTab.Size = new System.Drawing.Size(758, 527);
			this.attendanceTab.TabIndex = 3;
			this.attendanceTab.Text = "출석관리";
			this.attendanceTab.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skyDreamManagerToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// skyDreamManagerToolStripMenuItem
			// 
			this.skyDreamManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
			this.skyDreamManagerToolStripMenuItem.Name = "skyDreamManagerToolStripMenuItem";
			this.skyDreamManagerToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
			this.skyDreamManagerToolStripMenuItem.Text = "Sky Dream Manager";
			// 
			// 종료ToolStripMenuItem
			// 
			this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
			this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.종료ToolStripMenuItem.Text = "종료";
			this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
			// 
			// familyPhone
			// 
			this.familyPhone.HeaderText = "가족 연락처";
			this.familyPhone.Name = "familyPhone";
			this.familyPhone.ReadOnly = true;
			this.familyPhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.familyPhone.Width = 150;
			// 
			// studentPhone
			// 
			this.studentPhone.HeaderText = "연 락 처";
			this.studentPhone.Name = "studentPhone";
			this.studentPhone.ReadOnly = true;
			this.studentPhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.studentPhone.Width = 150;
			// 
			// classTime
			// 
			this.classTime.HeaderText = "수업시간";
			this.classTime.Name = "classTime";
			this.classTime.ReadOnly = true;
			this.classTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.classTime.Width = 150;
			// 
			// className
			// 
			this.className.HeaderText = "반";
			this.className.Name = "className";
			this.className.ReadOnly = true;
			this.className.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.className.Width = 120;
			// 
			// name
			// 
			this.name.HeaderText = "이 름";
			this.name.Name = "name";
			this.name.ReadOnly = true;
			this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.name.Width = 120;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "이름";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 120;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "반";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 120;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "수업 시간";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 150;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "연 락 처";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 120;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "보호자 연락처";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "하늘꿈 미술학원";
			this.tabControl.ResumeLayout(false);
			this.studentTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
			this.teacherTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.teacherTable)).EndInit();
			this.classTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.classTable)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage teacherTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem skyDreamManagerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.TabPage classTab;
		private System.Windows.Forms.TabPage attendanceTab;
		private System.Windows.Forms.Button addTeacherButton;
		private System.Windows.Forms.DataGridView teacherTable;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.Button addClassButton;
		private System.Windows.Forms.DataGridView classTable;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.TabPage studentTab;
		private System.Windows.Forms.DataGridView studentTable;
		private System.Windows.Forms.Button addStudentButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn familyPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn classTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn className;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

