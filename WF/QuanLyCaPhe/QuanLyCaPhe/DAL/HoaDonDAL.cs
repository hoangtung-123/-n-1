using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QuanLyCaPhe.Utils;


namespace QuanLyCaPhe.DAL
{
    public class HoaDonDAL
    {
        DBConnect db = new DBConnect();

        public DataTable GetAll()
        {
            string sql = @"SELECT hd.MaHD,hd.MaBan,hd.MaNV,hd.NgayTao,hd.TrangThai,
                            ISNULL(SUM(ct.SoLuong * ct.DonGia),0) AS TongTien FROM HoaDon hd
                            LEFT JOIN ChiTietHoaDon ct ON hd.MaHD = ct.MaHD GROUP BY hd.MaHD,
                            hd.MaBan,hd.MaNV,hd.NgayTao,hd.TrangThai
                            ORDER BY hd.NgayTao DESC";

            return db.GetDataTable(sql);
        }

        public string GetHoaDonChuaThanhToan(string maBan)
        {
            string sql = @"SELECT TOP 1 MaHD FROM HoaDon WHERE MaBan = @MaBan AND TrangThai = N'Chưa thanh toán'";

            SqlParameter[] para =
            {
                new SqlParameter("@MaBan", maBan)
            };

            object result = db.ExecuteScalar(sql, para);

            return result != null ? result.ToString() : null;
        }

        public string TaoHoaDon(string maBan, string maNV)
        {
            string maHD = "HD" + Guid.NewGuid().ToString("N").Substring(0, 8);

            string sql = @"INSERT INTO HoaDon
                           VALUES(@MaHD,@MaNV,@MaBan,GETDATE(),N'Chưa thanh toán')";

            SqlParameter[] para =
            {
                new SqlParameter("@MaHD", maHD),
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@MaBan", maBan)
            };

            db.ExecuteNonQuery(sql, para);

            string sqlBan = @"UPDATE Ban SET TrangThai = N'Đầy'WHERE MaBan = @MaBan";

            db.ExecuteNonQuery(sqlBan,new SqlParameter[]
            {
                new SqlParameter("@MaBan", maBan)
            });

            return maHD;
        }

        public bool ThanhToan(string maHD)
        {
            try
            {
                string sql = @"UPDATE HoaDon SET TrangThai = N'Đã thanh toán' WHERE MaHD = @MaHD";
                db.ExecuteNonQuery(sql, new SqlParameter[] { new SqlParameter("@MaHD", maHD) });

                // Cập nhật trạng thái bàn về Trống
                string sqlBan = @"UPDATE Ban 
                         SET TrangThai = N'Trống' 
                         WHERE MaBan = (SELECT MaBan FROM HoaDon WHERE MaHD = @MaHD)";

                db.ExecuteNonQuery(sqlBan, new SqlParameter[] { new SqlParameter("@MaHD", maHD) });

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable LocTheoNgay(DateTime from, DateTime to)
        {
            string sql = @"SELECT * FROM HoaDon WHERE NgayTao BETWEEN @From AND @To ORDER BY NgayTao DESC";

            return db.GetDataTable(sql,new SqlParameter[]
            {
                new SqlParameter("@From", from),
                new SqlParameter("@To", to)
            });
        }

        public void Xoa(string maHD)
        {
            string sqlCT = "DELETE FROM ChiTietHoaDon WHERE MaHD = @MaHD";

            db.ExecuteNonQuery(sqlCT,new SqlParameter[]
            {
                new SqlParameter("@MaHD", maHD)
            });

            string sqlHD = "DELETE FROM HoaDon WHERE MaHD = @MaHD";

            db.ExecuteNonQuery(sqlHD,new SqlParameter[]
            {
                new SqlParameter("@MaHD", maHD)
            });
        }
    }
}
