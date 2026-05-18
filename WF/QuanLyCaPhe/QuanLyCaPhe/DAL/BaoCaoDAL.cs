using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QuanLyCaPhe.BUS;

namespace QuanLyCaPhe.DAL
{
    public class BaoCaoDAL
    {
        private readonly DBConnect db = new DBConnect();

        public decimal TongDoanhThu(DateTime from, DateTime to)
        {
            string sql = @"SELECT ISNULL(SUM(ct.SoLuong * ct.DonGia), 0)
                           FROM HoaDon hd
                           JOIN ChiTietHoaDon ct ON hd.MaHD = ct.MaHD
                           WHERE hd.NgayTao BETWEEN @From AND @To";

            object kq = db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@From", from),
                new SqlParameter("@To", to)
            });

            return Convert.ToDecimal(kq ?? 0);
        }

        public int TongHoaDon(DateTime from, DateTime to)
        {
            string sql = @"SELECT COUNT(*) FROM HoaDon 
                           WHERE NgayTao BETWEEN @From AND @To";

            object kq = db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@From", from),
                new SqlParameter("@To", to)
            });

            return Convert.ToInt32(kq ?? 0);
        }

        public int TongPhieuNhap(DateTime from, DateTime to)
        {
            string sql = @"SELECT COUNT(*) FROM PhieuNhap 
                           WHERE NgayTao BETWEEN @From AND @To";

            object kq = db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@From", from),
                new SqlParameter("@To", to)
            });

            return Convert.ToInt32(kq ?? 0);
        }

        public int TongTonKho()
        {
            string sql = @"SELECT ISNULL(SUM(SoLuongTon), 0) FROM ChiTietKho";
            object kq = db.ExecuteScalar(sql);
            return Convert.ToInt32(kq ?? 0);
        }

        public DataTable DoanhThuTheoNgay(DateTime from, DateTime to)
        {
            string sql = @"SELECT 
                                CAST(hd.NgayTao AS DATE) AS Ngay,
                                SUM(ct.SoLuong * ct.DonGia) AS DoanhThu
                           FROM HoaDon hd
                           JOIN ChiTietHoaDon ct ON hd.MaHD = ct.MaHD
                           WHERE hd.NgayTao BETWEEN @From AND @To
                           GROUP BY CAST(hd.NgayTao AS DATE)
                           ORDER BY Ngay";

            SqlParameter[] para =
            {
                new SqlParameter("@From", from),
                new SqlParameter("@To", to)
            };

            return db.GetDataTable(sql, para);
        }

        public DataTable DoanhThuTheoThang(DateTime from, DateTime to)
        {
            string sql = @"SELECT 
                                MONTH(hd.NgayTao) AS Thang,
                                SUM(ct.SoLuong * ct.DonGia) AS DoanhThu
                           FROM HoaDon hd
                           JOIN ChiTietHoaDon ct ON hd.MaHD = ct.MaHD
                           WHERE hd.NgayTao BETWEEN @From AND @To
                           GROUP BY MONTH(hd.NgayTao)
                           ORDER BY Thang";

            SqlParameter[] para =
            {
                new SqlParameter("@From", from),
                new SqlParameter("@To", to)
            };

            return db.GetDataTable(sql, para);
        }

        public DataTable DoanhThuTheoNam(DateTime from, DateTime to)
        {
            string sql = @"SELECT 
                                YEAR(hd.NgayTao) AS Nam,
                                SUM(ct.SoLuong * ct.DonGia) AS DoanhThu
                           FROM HoaDon hd
                           JOIN ChiTietHoaDon ct ON hd.MaHD = ct.MaHD
                           WHERE hd.NgayTao BETWEEN @From AND @To
                           GROUP BY YEAR(hd.NgayTao)
                           ORDER BY Nam";

            SqlParameter[] para =
            {
                new SqlParameter("@From", from),
                new SqlParameter("@To", to)
            };

            return db.GetDataTable(sql, para);
        }

        public DataTable TopMonBan()
        {
            string sql = @"SELECT 
                                m.TenMon,
                                SUM(ct.SoLuong) AS SoLuongBan
                           FROM ChiTietHoaDon ct
                           JOIN Mon m ON ct.MaMon = m.MaMon
                           GROUP BY m.TenMon
                           ORDER BY SoLuongBan DESC";

            return db.GetDataTable(sql);
        }

        public DataTable BaoCaoHoaDon(DateTime from, DateTime to)
        {
            string sql = @"SELECT 
                                hd.MaHD,
                                nv.TenNV,
                                b.MaBan,
                                hd.NgayTao,
                                SUM(ct.SoLuong * ct.DonGia) AS TongTien
                           FROM HoaDon hd
                           JOIN NhanVien nv ON hd.MaNV = nv.MaNV
                           JOIN Ban b ON hd.MaBan = b.MaBan
                           JOIN ChiTietHoaDon ct ON hd.MaHD = ct.MaHD
                           WHERE hd.NgayTao BETWEEN @From AND @To
                           GROUP BY hd.MaHD, nv.TenNV, b.MaBan, hd.NgayTao
                           ORDER BY hd.NgayTao DESC";

            SqlParameter[] para =
            {
                new SqlParameter("@From", from),
                new SqlParameter("@To", to)
            };

            return db.GetDataTable(sql, para);
        }

        public DataTable BaoCaoPhieuNhap(DateTime from, DateTime to)
        {
            string sql = @"SELECT 
                                pn.MaPN,
                                nv.TenNV AS TenNhanVien,
                                pn.NgayTao,
                                pn.GhiChu,
                                pn.TongTien
                            FROM PhieuNhap pn
                            JOIN NhanVien nv ON pn.MaNV = nv.MaNV
                            WHERE pn.NgayTao BETWEEN @FromDate AND @ToDate
                            ORDER BY pn.NgayTao DESC";

            SqlParameter[] parameters =
            {
                new SqlParameter("@FromDate", from),
                new SqlParameter("@ToDate", to)
            };

            return db.GetDataTable(sql, parameters);
        }
    }   
}
