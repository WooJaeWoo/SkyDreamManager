using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDream
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
			TabSupporter ts = new TabSupporter();
			ts.fillStudentTable(studentTable);			
        }

        //Tap Page GridView 처리
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
			TabSupporter ts = new TabSupporter();
            if (tabControl.SelectedTab == tabControl.TabPages["attendanceTab"])
            {
				
            }
			else if (tabControl.SelectedTab == tabControl.TabPages["studentTab"])
            {
				ts.fillStudentTable(studentTable);
			}
            else if (tabControl.SelectedTab == tabControl.TabPages["teacherTab"])
			{
				ts.fillTeacherTable(teacherTable);
			}
			else if (tabControl.SelectedTab == tabControl.TabPages["classTab"])
			{
				ts.fillClassTable(classTable);
			}
		}

        private void addStudentButton_Click(object sender, EventArgs e)
        {
			TabSupporter ts = new TabSupporter();			
            PopupStudent popup = new PopupStudent();
            DialogResult dialogresult = popup.ShowDialog();
			if (dialogresult == DialogResult.OK)
				ts.fillStudentTable(studentTable);
            popup.Dispose();
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
			TabSupporter ts = new TabSupporter();
			PopupTeacher popup = new PopupTeacher();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
				ts.fillTeacherTable(teacherTable);
            popup.Dispose();
        }

		private void addClassButton_Click(object sender, EventArgs e)
		{
			TabSupporter ts = new TabSupporter();
			PopupClass popup = new PopupClass();
			DialogResult dialogresult = popup.ShowDialog();
			if (dialogresult == DialogResult.OK)
				ts.fillClassTable(classTable);
			popup.Dispose();
		}

		//Edit Data
		private void studentTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow selectedRow = studentTable.Rows[e.RowIndex];
			string selectedStudentName = selectedRow.Cells[0].Value.ToString();
			string[] att = { "SID" };
			ArrayList selectSid = SDDB.selectQuery("select SID from STUDENT where NAME='" + selectedStudentName + "';", att);
			int sId = Convert.ToInt32(selectSid[0]);

			TabSupporter ts = new TabSupporter();
			PopupStudent popup = new PopupStudent(sId);
			DialogResult dialogresult = popup.ShowDialog();
			if (dialogresult == DialogResult.OK)
				ts.fillStudentTable(studentTable);
			popup.Dispose();
		}
		private void teacherTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow selectedRow = teacherTable.Rows[e.RowIndex];
			string selectedTeacherName = selectedRow.Cells[0].Value.ToString();
			string[] att = {"TID"};
			ArrayList selectTid = SDDB.selectQuery("select TID from TEACHER where NAME='" + selectedTeacherName + "';", att);
			int tId = Convert.ToInt32(selectTid[0]);

			TabSupporter ts = new TabSupporter();
			PopupTeacher popup = new PopupTeacher(tId);
			DialogResult dialogresult = popup.ShowDialog();
			if (dialogresult == DialogResult.OK)
				ts.fillTeacherTable(teacherTable);
			popup.Dispose();
		}
		private void classTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow selectedRow = classTable.Rows[e.RowIndex];
			string selectedClassName = selectedRow.Cells[0].Value.ToString();

			TabSupporter ts = new TabSupporter();
			PopupClass popup = new PopupClass(selectedClassName);
			DialogResult dialogresult = popup.ShowDialog();
			if (dialogresult == DialogResult.OK)
				ts.fillClassTable(classTable);
			popup.Dispose();
		}

        //Menu Strip 처리
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
