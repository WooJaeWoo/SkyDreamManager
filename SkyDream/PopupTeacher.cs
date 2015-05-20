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
    public partial class PopupTeacher : Form
    {
		private int tId = -1;

        public PopupTeacher()
        {
            InitializeComponent();
			comboBox3.SelectedIndex = 0;
			checkBox1.Checked = true;
			tId = -1;
			saveButton.Enabled = false;
		}

		public PopupTeacher(int tId)
		{
			InitializeComponent();
			comboBox3.SelectedIndex = 0;
			textBox1.ReadOnly = true;
			this.tId = tId;
			saveButton.Text = "수정하기";

			string teacherQuery = "select NAME, AGE, SEX, SSN, PHONE, ADDRESS, BANK, BANK_ACCOUNT, IS_WORKING from TEACHER where TID='" + tId + "';";
			string[] attributes = { "NAME", "AGE", "SEX", "SSN", "PHONE", "ADDRESS", "BANK", "BANK_ACCOUNT", "IS_WORKING"};
			ArrayList teacherInfo = SDDB.selectQuery(teacherQuery, attributes);
			textBox1.Text = teacherInfo[0].ToString();
			textBox2.Text = teacherInfo[1].ToString();
			comboBox3.Text = teacherInfo[2].ToString();
			string ssn = teacherInfo[3].ToString();
			string[] ssnSplit = ssn.Split('-');
			textBox3.Text = ssnSplit[0];
			textBox4.Text = ssnSplit[1];
			textBox5.Text = teacherInfo[4].ToString();
			textBox6.Text = teacherInfo[5].ToString();
			comboBox2.Text = teacherInfo[6].ToString();
			textBox7.Text = teacherInfo[7].ToString();
			if (teacherInfo[8].ToString() == "False")
				checkBox1.Checked = false;
		}

		private void isCompletedForm(object sender, EventArgs e)
		{
			if (!SDUtil.isNullCheck(textBox1.Text) && !SDUtil.isNullCheck(textBox2.Text)
				&& !SDUtil.isNullCheck(textBox3.Text) && !SDUtil.isNullCheck(textBox4.Text)
				&& !SDUtil.isNullCheck(textBox5.Text) && !SDUtil.isNullCheck(textBox7.Text)
				&& !SDUtil.isNullCheck(comboBox2.Text))
				saveButton.Enabled = true;
			else
				saveButton.Enabled = false;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			string name = "'" + textBox1.Text + "', ";
			string age = textBox2.Text + ", ";
			string sex = "'" + comboBox3.Text + "', ";
			string ssn = "'" + textBox3.Text + "-" + textBox4.Text + "', ";
			string phone = "'" + textBox5.Text + "', ";
			string address = "'" + textBox6.Text + "', ";
			string bank = "'" + comboBox2.Text + "', ";
			string bankAccount = "'" + textBox7.Text + "', ";
			string isWorking = "true";
			if (!checkBox1.Checked)
				isWorking = "false";

			string query = "";
			if (tId != -1)
			{
				query = "update TEACHER set NAME=" + name + "AGE=" + age + "SEX=" + sex + "SSN=" + ssn 
						+ "PHONE=" + phone + "ADDRESS=" + address + "BANK=" + bank + "BANK_ACCOUNT=" + bankAccount + "IS_WORKING=" + isWorking
						+ " where TID=" + tId + ";";
			}
			else
			{
				query = "insert into TEACHER (NAME, AGE, SEX, SSN, PHONE, ADDRESS, BANK, BANK_ACCOUNT, IS_WORKING) values ("
						+ name + age + sex + ssn + phone + address + bank + bankAccount + isWorking + ");";
			}
			
			SDDB.executeQuery(query);
        }
    }
}
