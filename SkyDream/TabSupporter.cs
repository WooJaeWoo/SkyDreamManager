using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDream
{
	class TabSupporter
	{
		public void fillStudentTable(DataGridView studentTable)
		{
			string query = "select s.NAME, s.CLASS_NAME, s.PHONE as SPHONE, f.PHONE as FPHONE "
								+ "from STUDENT s inner join FAMILY f on s.SID = f.STUDENT_SID and s.FPHONE = f.RELATIONSHIP;";
			string[] attributes = { "NAME", "CLASS_NAME", "SPHONE", "FPHONE" };
			ArrayList selectResult = SDDB.selectQuery(query, attributes);

			studentTable.Rows.Clear();
			int rows = SDDB.getRowCount();
			for (int i = 0; i < rows; i++)
			{
				studentTable.Rows.Add(selectResult[i * attributes.Length], selectResult[i * attributes.Length + 1], getLessonTime(selectResult[i * attributes.Length + 1].ToString()), selectResult[i * attributes.Length + 2], selectResult[i * attributes.Length + 3]);
			}
		}

		public void fillTeacherTable(DataGridView teacherTable)
		{
			string query = "select NAME, PHONE from TEACHER;";
			string[] attributes = { "NAME", "PHONE" };
			ArrayList selectResult = SDDB.selectQuery(query, attributes);

			teacherTable.Rows.Clear();
			int rows = SDDB.getRowCount();
			for (int i = 0; i < rows; i++)
			{
				teacherTable.Rows.Add(selectResult[i * attributes.Length], getClasses(selectResult[i * attributes.Length].ToString()), selectResult[i * attributes.Length + 1]);
			}
		}

		public void fillClassTable(DataGridView classTable)
		{
			string query = "select c.NAME as CNAME, t.NAME as TNAME, c.CLASSROOM, c.MAX_STUDENT from TEACHER t inner join CLASS c on t.TID = c.TEACHER_TID;";
			string[] attributes = { "CNAME", "TNAME", "CLASSROOM", "MAX_STUDENT" };
			ArrayList selectResult = SDDB.selectQuery(query, attributes);

			classTable.Rows.Clear();
			int rows = SDDB.getRowCount();
			for (int i = 0; i < rows; i++)
			{
				string currentStudent = getCurrentStudent(selectResult[i * attributes.Length].ToString()) + " / " + selectResult[i * attributes.Length + 3].ToString();
				classTable.Rows.Add(selectResult[i * attributes.Length], selectResult[i * attributes.Length + 1], selectResult[i * attributes.Length + 2], currentStudent);
			}
		}

		private string getLessonTime(string className)
		{
			string query = "select LESSON_TIME from LESSON where CLASS_NAME='" + className + "';";
			string[] attributes = { "LESSON_TIME" };
			ArrayList a = SDDB.selectQuery(query, attributes);
			int rows = SDDB.getRowCount();
			return resultParser(a, rows);
		}

		private string getClasses(string teacherName)
		{
			string query = "select i.CNAME from "
							+ "(select t.NAME as TNAME, c.NAME as CNAME "
								+ "from TEACHER t inner join CLASS c on t.TID = c.TEACHER_TID) as i "
							+ "where i.TNAME='" + teacherName + "';";
			string[] attributes = { "CNAME" };
			ArrayList a = SDDB.selectQuery(query, attributes);
			int rows = SDDB.getRowCount();
			return resultParser(a, rows);
		}

		private string getCurrentStudent(string className)
		{
			string query = "select SID from STUDENT where CLASS_NAME = '" + className + "';";
			string[] attributes = { "SID" };
			ArrayList a = SDDB.selectQuery(query, attributes);
			return SDDB.getRowCount().ToString();
		}

		private string resultParser(ArrayList a, int rows)
		{
			string result = "";
			for (int i = 0; i < rows; i++)
			{
				if (i == rows - 1)
					result = result + a[i];
				else
					result = result + a[i] + " / ";
			}
			return result;
		}
	}
}
