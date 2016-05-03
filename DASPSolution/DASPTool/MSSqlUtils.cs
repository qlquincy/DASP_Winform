using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DASPTool
{
    public class MSSqlUtils
    {
        private const string connString = "Integrated Security=SSPI;" + "Initial Catalog=;" + "Data Source=localhost;";

        public static void CreateDB(string dbName)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            conn = new SqlConnection(connString);
            // 打开数据库连接
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            string sql = "create database " + dbName;
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
