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
    public class BanDAL : DBConnect
    {
        public DataTable GetAll()
        {
            string sql = @"SELECT b.MaBan, b.LoaiBan, b.TrangThai, b.MaKV, kv.TenKV
                           FROM Ban b 
                           JOIN KhuVuc kv ON b.MaKV = kv.MaKV
                           ORDER BY b.MaBan";
            return GetDataTable(sql);
        }

        public bool Insert(Ban ban)
        {
            string sql = "INSERT INTO Ban VALUES(@MaBan, @LoaiBan, @TrangThai, @MaKV)";
            SqlParameter[] para =
            {
                new SqlParameter("@MaBan", ban.MaBan),
                new SqlParameter("@LoaiBan", ban.LoaiBan),
                new SqlParameter("@TrangThai", ban.TrangThai),
                new SqlParameter("@MaKV", ban.MaKV)
            };
            return ExecuteNonQuery(sql, para) > 0;
        }

        public bool Update(Ban ban)
        {
            string sql = @"UPDATE Ban 
                           SET LoaiBan = @LoaiBan, 
                               TrangThai = @TrangThai, 
                               MaKV = @MaKV
                           WHERE MaBan = @MaBan";
            SqlParameter[] para =
            {
                new SqlParameter("@MaBan", ban.MaBan),
                new SqlParameter("@LoaiBan", ban.LoaiBan),
                new SqlParameter("@TrangThai", ban.TrangThai),
                new SqlParameter("@MaKV", ban.MaKV)
            };
            return ExecuteNonQuery(sql, para) > 0;
        }

        public bool Delete(string maBan)
        {
            string sql = "DELETE FROM Ban WHERE MaBan = @MaBan";
            return ExecuteNonQuery(sql, new SqlParameter[] { new SqlParameter("@MaBan", maBan) }) > 0;
        }

        public bool Exists(string maBan)
        {
            string sql = "SELECT COUNT(*) FROM Ban WHERE MaBan = @MaBan";
            object result = ExecuteScalar(sql, new SqlParameter[] { new SqlParameter("@MaBan", maBan) });
            return Convert.ToInt32(result) > 0;
        }

        public bool IsUsed(string maBan)
        {
            string sql = "SELECT COUNT(*) FROM HoaDon WHERE MaBan = @MaBan";
            object result = ExecuteScalar(sql, new SqlParameter[] { new SqlParameter("@MaBan", maBan) });
            return Convert.ToInt32(result) > 0;
        }
    }
}
