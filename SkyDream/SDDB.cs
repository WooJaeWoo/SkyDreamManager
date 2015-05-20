using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SkyDream
{
    static class SDDB
    {
        static public int executeQuery(string query)
        {
            IDbConnection dbcon = getConnection();
            IDbCommand dbcmd = dbcon.CreateCommand();
            dbcmd.CommandText = query;

            int rowCount = dbcmd.ExecuteNonQuery();

            dbcmd.Dispose();
            dbcmd = null;

            closeConnection(dbcon);
			return rowCount;
        }

		static private int rowCount = 0;
        static public ArrayList selectQuery(string query, string[] attributes)
        {
            IDbConnection dbcon = getConnection();
            IDbCommand dbcmd = dbcon.CreateCommand();
            dbcmd.CommandText = query;

			rowCount = 0;
            ArrayList result = new ArrayList();

            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
				rowCount++;
                for (int i = 0; i < attributes.Length; i++)
                {
                    string att = reader[attributes[i]].ToString();
                    result.Add(att);
                }
            }
            dbcmd.Dispose();
            dbcmd = null;
            
			closeConnection(dbcon);
            return result;
        }

		static public int getRowCount()
		{
			return rowCount;
		}

        static private IDbConnection getConnection()
        {
            string connectionString = "Server=localhost;"
                + "Database=DB_FINAL;"
                + "User ID=root;"
                + "Password=1234;";
            IDbConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            return dbcon;
        }

        static private void closeConnection(IDbConnection dbcon)
        {
            dbcon.Close();
            dbcon = null;
        }
    }
}
