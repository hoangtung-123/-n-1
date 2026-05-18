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
    public class MonDAL : DBConnect
    {
        private readonly DBConnect db = new DBConnect();

        public DataTable GetAll()
        {
            string sql = @"SELECT MaMon, TenMon, DonGia, TrangThai 
                           FROM Mon 
                           ORDER BY MaMon";

            return db.GetDataTable(sql);
        }

        public DataTable GetDangBan()
        {
            string sql = @"SELECT MaMon, TenMon, DonGia, TrangThai 
                           FROM Mon 
                           WHERE TrangThai = N'Còn bán' 
                           ORDER BY MaMon";

            return db.GetDataTable(sql);
        }

        public bool Insert(Mon mon)
        {
            string sql = @"INSERT INTO Mon 
                           VALUES(@MaMon, @TenMon, @DonGia, @TrangThai)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaMon", mon.MaMon),
                new SqlParameter("@TenMon", mon.TenMon),
                new SqlParameter("@DonGia", mon.DonGia),
                new SqlParameter("@TrangThai", mon.TrangThai)
            };

            int kq = db.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }

        public bool Update(Mon mon)
        {
            string sql = @"UPDATE Mon
                           SET TenMon = @TenMon,
                               DonGia = @DonGia,
                               TrangThai = @TrangThai
                           WHERE MaMon = @MaMon";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaMon", mon.MaMon),
                new SqlParameter("@TenMon", mon.TenMon),
                new SqlParameter("@DonGia", mon.DonGia),
                new SqlParameter("@TrangThai", mon.TrangThai)
            };

            int kq = db.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }

        public bool Exists(string maMon)
        {
            string sql = "SELECT COUNT(*) FROM Mon WHERE MaMon = @MaMon";

            int count = Convert.ToInt32(db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@MaMon", maMon)
            }));

            return count > 0;
        }

        public bool IsUsed(string maMon)
        {
            string sql = @"SELECT COUNT(*) 
                           FROM ChiTietHoaDon 
                           WHERE MaMon = @MaMon";

            int count = Convert.ToInt32(db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@MaMon", maMon)
            }));

            return count > 0;
        }
    }
}
