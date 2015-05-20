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
	public partial class PopupClass : Form
	{
		private bool isEdit = false;

		public PopupClass()
		{
			InitializeComponent();
			initAddClassForm();
			isEdit = false;
			saveButton.Enabled = false;
		}

		public PopupClass(string className)
		{
			InitializeComponent();
			initAddClassForm();
			saveButton.Text = "수정하기";
			textBox1.ReadOnly = true;
			isEdit = true;

			string classQuery = "select c.NAME as CNAME, t.NAME as TNAME, c.CLASSROOM, c.MAX_STUDENT from CLASS c inner join TEACHER t on c.NAME='" + className + "' and c.TEACHER_TID = t.TID";
			string[] attributes = { "CNAME", "TNAME", "CLASSROOM", "MAX_STUDENT" };
			ArrayList classInfo = SDDB.selectQuery(classQuery, attributes);
			textBox1.Text = classInfo[0].ToString();
			comboBox1.Text = classInfo[1].ToString();
			textBox2.Text = classInfo[2].ToString();
			textBox3.Text = classInfo[3].ToString();

			string lessonQuery = "select LESSON_TIME from LESSON where CLASS_NAME='" + className + "';";
			string[] lessonAtt = { "LESSON_TIME" };
			ArrayList lessons = SDDB.selectQuery(lessonQuery, lessonAtt);
			for (int i = 0; i < SDDB.getRowCount(); i++)
			{
				listBox1.Items.Add(lessons[i]);
			}
		}

		private void initAddClassForm()
		{
			string teacherQuery = "select NAME from TEACHER;";
			string[] att = { "NAME" };
			ArrayList a = SDDB.selectQuery(teacherQuery, att);
			for (int i = 0; i < SDDB.getRowCount(); i++)
			{
				comboBox1.Items.Add(a[i].ToString());
			}
		}

		private void isCompletedForm(object sender, EventArgs e)
		{
			if (!SDUtil.isNullCheck(textBox1.Text) && !SDUtil.isNullCheck(comboBox1.Text) && !SDUtil.isNullCheck(textBox3.Text))
				saveButton.Enabled = true;
			else
				saveButton.Enabled = false;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{

			string name = textBox1.Text;
			string teacher = comboBox1.Text;
			string classRoom = textBox2.Text;
			string maxStudent = textBox3.Text;

			string teacherQuery = "select TID from TEACHER where NAME='" + teacher + "';";
			string[] att = {"TID"};
			ArrayList tid = SDDB.selectQuery(teacherQuery, att);


			string classQuery = "";
			if (isEdit)
			{
				classQuery = "update CLASS set NAME='" + name + "', TEACHER_TID=" + tid[0].ToString()
							+ ", CLASSROOM='" + classRoom + "', MAX_STUDENT=" + maxStudent
							+ " where NAME='" + name + "';";
			}
			else
			{
				classQuery = "insert into CLASS (NAME, TEACHER_TID, CLASSROOM, MAX_STUDENT) "
								+ "values ('" + name + "', " + tid[0] + ", '" + classRoom + "', " + maxStudent + ");";
			}			
			SDDB.executeQuery(classQuery);

			SDDB.executeQuery("delete from LESSON where CLASS_NAME='" + name + "';");
			for (int i = 0; i < listBox1.Items.Count; i++)
			{
				string lessonQuery = "insert into LESSON values ('" + name + "', '" + listBox1.Items[i].ToString() + "');";
				SDDB.executeQuery(lessonQuery);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string classTime = comboBox2.Text + " " + textBox4.Text + "시";
			listBox1.Items.Add(classTime);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem != null)
			{
				listBox1.Items.Remove(listBox1.SelectedItem);
			}
		}
	}
}
