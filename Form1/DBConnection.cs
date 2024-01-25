using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DBConnection() { }
        public void Execute(string sqlStr, string message)
        {
            try
            {
                // Ket noi
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show(message + " thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + " that bai" + ex);
            }
            finally
            {


                conn.Close();
            }

        }
        public DataTable Load(string sqlStr)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dt);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

    }
}
