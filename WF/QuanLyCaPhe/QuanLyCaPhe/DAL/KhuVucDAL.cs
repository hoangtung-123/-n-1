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
    public class KhuVucDAL : DBConnect
    {
        private readonly DBConnect db = new DBConnect();

        public DataTable GetAll()
        {
            string sql = @"SELECT 
                            kv.MaKV,
                            kv.TenKV,
                            kv.DiaChi,
                            kv.MaQuanLy,
                            ISNULL(nv.TenNV, N'Chưa phân công') AS TenQuanLy
                         FROM KhuVuc kv
                         LEFT JOIN NhanVien nv ON kv.MaQuanLy = nv.MaNV
                         ORDER BY kv.MaKV";

            return db.GetDataTable(sql);
        }

        public bool Insert(KhuVuc kv)
        {
            string sql = @"INSERT INTO KhuVuc (MaKV, TenKV, DiaChi, MaQuanLy)
                           VALUES(@MaKV, @TenKV, @DiaChi, @MaQuanLy)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKV", kv.MaKV),
                new SqlParameter("@TenKV", kv.TenKV),
                new SqlParameter("@DiaChi", kv.DiaChi ?? (object)DBNull.Value),
                new SqlParameter("@MaQuanLy", kv.MaQuanLy ?? (object)DBNull.Value)
            };

            int result = db.ExecuteNonQuery(sql, parameters);
            return result > 0;
        }

        public bool Update(KhuVuc kv)
        {
            string sql = @"UPDATE KhuVuc
                           SET TenKV = @TenKV,
                               DiaChi = @DiaChi,
                               MaQuanLy = @MaQuanLy
                           WHERE MaKV = @MaKV";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKV", kv.MaKV),
                new SqlParameter("@TenKV", kv.TenKV),
                new SqlParameter("@DiaChi", kv.DiaChi ?? (object)DBNull.Value),
                new SqlParameter("@MaQuanLy", kv.MaQuanLy ?? (object)DBNull.Value)
            };

            int result = db.ExecuteNonQuery(sql, parameters);
            return result > 0;
        }

        public bool Delete(string maKV)
        {
            string sql = "DELETE FROM KhuVuc WHERE MaKV = @MaKV";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKV", maKV)
            };

            int result = db.ExecuteNonQuery(sql, parameters);
            return result > 0;
        }

        public bool Exists(string maKV)
        {
            string sql = "SELECT COUNT(*) FROM KhuVuc WHERE MaKV = @MaKV";

            object result = db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@MaKV", maKV)
            });

            return Convert.ToInt32(result) > 0;
        }

        public bool IsUsed(string maKV)
        {
            string sql = @"
                SELECT COUNT(*) 
                FROM (
                    SELECT MaKV FROM NhanVien WHERE MaKV = @MaKV
                    UNION ALL
                    SELECT MaKV FROM Ban WHERE MaKV = @MaKV
                ) AS Used";

            object result = db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@MaKV", maKV)
            });

            return Convert.ToInt32(result) > 0;
        }
    }
}
