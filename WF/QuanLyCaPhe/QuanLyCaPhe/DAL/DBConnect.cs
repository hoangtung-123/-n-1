using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyCaPhe.DAL
{
    public class DBConnect
    {
        private readonly SqlConnection conn;

        public DBConnect()
        {
            string strConn = "Data Source=DESKTOP-6GBA1KF\\MSSQLSERVER01;" +
                             "Initial Catalog=QuanLyQuanCafe;" +
                             "Integrated Security=True;" +
                             "TrustServerCertificate=True;" +
                             "MultipleActiveResultSets=True";

            conn = new SqlConnection(strConn);
        }

        private void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
         
        public DataTable GetDataTable(string sql, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            try
            {
                OpenConnection();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi GetDataTable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        public int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi ExecuteNonQuery", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public object ExecuteScalar(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi ExecuteScalar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        // Phương thức hỗ trợ cũ (nếu còn dùng)
        public DataTable GetData(string sql)
        {
            return GetDataTable(sql);
        }
    }
}
