using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QuanLyCaPhe.DTO;


namespace QuanLyCaPhe.DAL
{
    public class LoginDAL : DBConnect
    {
        public NhanVien CheckLogin(string user, string pass)
        {
            string sql = @"SELECT MaNV, TenNV, ChucVu
                           FROM NhanVien
                           WHERE TenDangNhap = @u AND MatKhau = @p";

            SqlParameter[] parameters =
            {
                new SqlParameter("@u", user),
                new SqlParameter("@p", pass)
            };

            DataTable dt = GetDataTable(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                var nv = new NhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    TenNV = row["TenNV"].ToString(),
                    ChucVu = row["ChucVu"].ToString()
                };
                return nv;
            }

            return null;
        }
    }
}
