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
    public class KhoDAL : DBConnect
    {
        public DataTable GetAll()
        {
            string sql = @"SELECT MaKho, TenKho, TrangThai, NgayTao
                           FROM Kho
                           ORDER BY MaKho";

            return GetDataTable(sql);
        }

        public DataTable GetChiTietKho(string maKho)
        {
            string sql = @"SELECT 
                                ctk.MaCTKho,
                                ctk.MaNL,
                                nl.TenNL,
                                ctk.SoLuongTon
                           FROM ChiTietKho ctk
                           JOIN NguyenLieu nl ON ctk.MaNL = nl.MaNL
                           WHERE ctk.MaKho = @MaKho
                           ORDER BY nl.TenNL";

            return GetDataTable(sql, new SqlParameter[]
            {
                new SqlParameter("@MaKho", maKho)
            });
        }

        public bool Insert(Kho kho)
        {
            string sql = @"INSERT INTO Kho (MaKho, TenKho, TrangThai, NgayTao)
                           VALUES(@MaKho, @TenKho, @TrangThai, GETDATE())";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKho", kho.MaKho),
                new SqlParameter("@TenKho", kho.TenKho),
                new SqlParameter("@TrangThai", kho.TrangThai)
            };

            return ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool Update(Kho kho)
        {
            string sql = @"UPDATE Kho
                           SET TenKho = @TenKho,
                               TrangThai = @TrangThai
                           WHERE MaKho = @MaKho";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKho", kho.MaKho),
                new SqlParameter("@TenKho", kho.TenKho),
                new SqlParameter("@TrangThai", kho.TrangThai)
            };

            return ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool Delete(string maKho)
        {
            string sql = "DELETE FROM Kho WHERE MaKho = @MaKho";

            return ExecuteNonQuery(sql, new SqlParameter[]
            {
                new SqlParameter("@MaKho", maKho)
            }) > 0;
        }

        public bool Exists(string maKho)
        {
            string sql = "SELECT COUNT(*) FROM Kho WHERE MaKho = @MaKho";

            object result = ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@MaKho", maKho)
            });

            return Convert.ToInt32(result) > 0;
        }

        public bool IsUsed(string maKho)
        {
            string sql = "SELECT COUNT(*) FROM ChiTietKho WHERE MaKho = @MaKho";

            object result = ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@MaKho", maKho)
            });

            return Convert.ToInt32(result) > 0;
        }
    }
}
