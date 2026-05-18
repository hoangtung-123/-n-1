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
    public class NguyenLieuDAL : DBConnect
    {
        public DataTable GetAll()
        {
            string sql = @"
                SELECT MaNL, TenNL, Gia
                FROM NguyenLieu
                ORDER BY MaNL";

            return GetDataTable(sql);
        }

        public bool Insert(NguyenLieu nl)
        {
            string sql = "INSERT INTO NguyenLieu VALUES(@MaNL, @TenNL, @Gia)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNL", nl.MaNL),
                new SqlParameter("@TenNL", nl.TenNL),
                new SqlParameter("@Gia", nl.Gia)
            };

            return ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool Update(NguyenLieu nl)
        {
            string sql = @"
                UPDATE NguyenLieu
                SET TenNL = @TenNL, 
                    Gia = @Gia
                WHERE MaNL = @MaNL";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNL", nl.MaNL),
                new SqlParameter("@TenNL", nl.TenNL),
                new SqlParameter("@Gia", nl.Gia)
            };

            return ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool Delete(string maNL)
        {
            string sql = "DELETE FROM NguyenLieu WHERE MaNL = @MaNL";
            SqlParameter[] parameters = { new SqlParameter("@MaNL", maNL) };

            return ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool Exists(string maNL)
        {
            string sql = "SELECT COUNT(*) FROM NguyenLieu WHERE MaNL = @MaNL";
            SqlParameter[] parameters = { new SqlParameter("@MaNL", maNL) };

            object result = ExecuteScalar(sql, parameters);
            return Convert.ToInt32(result) > 0;
        }

        public bool IsUsed(string maNL)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM (
                    SELECT MaNL FROM ChiTietKho WHERE MaNL = @MaNL
                    UNION ALL
                    SELECT MaNL FROM ChiTietPhieuNhap WHERE MaNL = @MaNL
                ) AS Used";

            SqlParameter[] parameters = { new SqlParameter("@MaNL", maNL) };

            object result = ExecuteScalar(sql, parameters);
            return Convert.ToInt32(result) > 0;
        }
    }
}
