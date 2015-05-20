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
    public partial class PopupStudent : Form
    {
		private int sId = -1;
 
        public PopupStudent()
        {
            InitializeComponent();
			initStudentForm();
			checkBox1.Checked = true;
			sId = -1;
			saveButton.Enabled = false;
		}

		public PopupStudent(int sId)
		{
			InitializeComponent();
			initStudentForm();
			this.sId = sId;
			textBox1.ReadOnly = true;
			saveButton.Text = "수정하기";

			string studentQuery = "select NAME, AGE, SEX, CLASS_NAME, SCHOOL, PHONE, ADDRESS, IS_LEARNING from STUDENT where SID=" + sId + ";";
			string[] studentAtt = { "NAME", "AGE", "SEX", "CLASS_NAME", "SCHOOL", "PHONE", "ADDRESS", "IS_LEARNING" };
			ArrayList studentInfo = SDDB.selectQuery(studentQuery, studentAtt);
			textBox1.Text = studentInfo[0].ToString();
			textBox2.Text = studentInfo[1].ToString();
			comboBox3.Text = studentInfo[2].ToString();
			comboBox1.Text = studentInfo[3].ToString();
			textBox4.Text = studentInfo[4].ToString();
			textBox5.Text = studentInfo[5].ToString();
			textBox6.Text = studentInfo[6].ToString();
			if (studentInfo[7].ToString() == "False")
				checkBox1.Checked = false;
			
			string familyQuery = "select f.RELATIONSHIP, f.PHONE from STUDENT s inner join FAMILY f on s.NAME='" + textBox1.Text + "' and s.SID=f.STUDENT_SID;";
			string[] familyAtt = { "RELATIONSHIP", "PHONE" };
			ArrayList familyInfo = SDDB.selectQuery(familyQuery, familyAtt);
			for (int i = 0; i < SDDB.getRowCount(); i++)
			{
				string familyListItem = familyInfo[i * familyAtt.Length].ToString() + " : " + familyInfo[i * familyAtt.Length + 1];
				listBox1.Items.Add(familyListItem);
			}

		}

		private void initStudentForm()
		{
			string query = "select NAME from CLASS";
			string[] att = { "NAME" };
			ArrayList a = SDDB.selectQuery(query, att);
			
			for (int i = 0; i < SDDB.getRowCount(); i++)
			{
				comboBox1.Items.Add(a[i].ToString());
			}
		}

		private void isCompletedForm(object sender, EventArgs e)
		{
			if (!SDUtil.isNullCheck(textBox1.Text) && !SDUtil.isNullCheck(textBox2.Text)
				&& listBox1.Items.Count > 0)
				saveButton.Enabled = true;
			else
				saveButton.Enabled = false;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			//Student Default Info
			string name = "'" + textBox1.Text + "', ";
			string age = textBox2.Text + ", ";
			string sex = "'" + comboBox3.Text + "', ";
			string className = "";
			if (comboBox1.Text == null || comboBox1.Text == "")
				className = "NULL, ";
			else
				className = "'" + comboBox1.Text + "', ";
			string school = "'" + textBox4.Text + "', ";
			string phone = "'" + textBox5.Text + "', ";
			string address = "'" + textBox6.Text + "', ";
			string isLearning = "true";
			if (!checkBox1.Checked)
				isLearning = "false";

			//Extracting fphone
			//일단 주 연락처는 listbox 최상단으로 해둡니다.
			string fphoneInfo = listBox1.Items[0].ToString();
			string[] stringSeparators = new string[] { " : " };
			string[] fphoneInfos = fphoneInfo.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
			string fphone = "'" + fphoneInfos[0] + "', ";

			string query = "";
			if (sId != -1)
			{
				query = "update STUDENT set CLASS_NAME=" + className + "NAME=" + name + "AGE=" + age + "SEX=" + sex + "PHONE=" + phone
							+ "FPHONE=" + fphone + "ADDRESS=" + address + "SCHOOL=" + school + "IS_LEARNING=" + isLearning
							+ " where NAME='" + textBox1.Text + "';";
			}
			else
			{
				query = "insert into STUDENT (CLASS_NAME, NAME, AGE, SEX, PHONE, FPHONE, ADDRESS, SCHOOL, IS_LEARNING) values ("
							+ className + name + age + sex + phone + fphone + address + school + isLearning + ");";
			}

			SDDB.executeQuery(query);

			//Insert family Info into sddb 
			int familyCount = listBox1.Items.Count;
			string idQuery = "select SID from STUDENT where NAME='" + textBox1.Text + "';";
			string[] attId = {"SID"};
			ArrayList id = SDDB.selectQuery(idQuery, attId);
			SDDB.executeQuery("delete from FAMILY where STUDENT_SID=" + id[0] + ";");
			
			for (int i = 0; i < familyCount; i++)
			{
				string familyInfo = listBox1.Items[i].ToString();
				string[] familyInfos = familyInfo.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
				string familyQuery = "insert into FAMILY values (" + id[0] + ", '" + familyInfos[0] + "', '" + familyInfos[1] + "');";
				SDDB.executeQuery(familyQuery);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(comboBox2.Text + " : " + textBox7.Text); 
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem != null)
			{
				string familyInfo = listBox1.SelectedItem.ToString();
				string[] stringSeparators = new string[] { " : " };
				string[] familyInfos = familyInfo.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
				textBox7.Text = familyInfos[1];
				comboBox2.Text = familyInfos[0];
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem != null)
			{
				listBox1.Items.Remove(listBox1.SelectedItem);
			}
		}
    }
}
