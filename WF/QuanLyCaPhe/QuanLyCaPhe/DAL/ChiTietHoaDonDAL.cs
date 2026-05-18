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
    public class ChiTietHoaDonDAL : DBConnect
    {
        private readonly DBConnect db = new DBConnect();
        private readonly HoaDonDAL hdDAL = new HoaDonDAL();

        public DataTable GetByBan(string maBan)
        {
            string maHD = hdDAL.GetHoaDonChuaThanhToan(maBan);
            if (string.IsNullOrEmpty(maHD))
                return new DataTable();

            string sql = @"SELECT 
                                m.MaMon, 
                                m.TenMon, 
                                ct.SoLuong, 
                                ct.DonGia, 
                                (ct.SoLuong * ct.DonGia) AS ThanhTien
                           FROM ChiTietHoaDon ct 
                           INNER JOIN Mon m ON ct.MaMon = m.MaMon
                           WHERE ct.MaHD = @MaHD";

            return db.GetDataTable(sql, new SqlParameter[]
            {
                new SqlParameter("@MaHD", maHD)
            });
        }

        public bool ThemMon(string maBan, string maMon)
        {
            try
            {
                if (string.IsNullOrEmpty(maBan) || string.IsNullOrEmpty(maMon))
                    return false;

                string maHD = hdDAL.GetHoaDonChuaThanhToan(maBan);

                // Tạo hóa đơn mới nếu chưa có
                if (string.IsNullOrEmpty(maHD))
                {
                    if (string.IsNullOrEmpty(Session.MaNV))
                        return false;

                    maHD = hdDAL.TaoHoaDon(maBan, Session.MaNV);
                    if (string.IsNullOrEmpty(maHD))
                        return false;
                }

                // Kiểm tra món đã tồn tại trong hóa đơn chưa
                string sqlCheck = @"SELECT COUNT(*) 
                                    FROM ChiTietHoaDon 
                                    WHERE MaHD = @MaHD AND MaMon = @MaMon";

                int count = Convert.ToInt32(db.ExecuteScalar(sqlCheck, new SqlParameter[]
                {
                    new SqlParameter("@MaHD", maHD),
                    new SqlParameter("@MaMon", maMon)
                }) ?? 0);

                if (count > 0)
                {
                    // Tăng số lượng
                    string sqlUpdate = @"UPDATE ChiTietHoaDon 
                                         SET SoLuong = SoLuong + 1 
                                         WHERE MaHD = @MaHD AND MaMon = @MaMon";

                    db.ExecuteNonQuery(sqlUpdate, new SqlParameter[]
                    {
                        new SqlParameter("@MaHD", maHD),
                        new SqlParameter("@MaMon", maMon)
                    });
                }
                else
                {
                    // Thêm mới
                    string sqlGia = "SELECT DonGia FROM Mon WHERE MaMon = @MaMon";
                    object giaObj = db.ExecuteScalar(sqlGia, new SqlParameter[]
                    {
                        new SqlParameter("@MaMon", maMon)
                    });

                    if (giaObj == null) return false;

                    decimal donGia = Convert.ToDecimal(giaObj);
                    string maCT = "CT" + Guid.NewGuid().ToString("N").Substring(0, 8);

                    string sqlInsert = @"INSERT INTO ChiTietHoaDon (MaCTHD, MaHD, MaMon, SoLuong, DonGia)
                                         VALUES(@MaCT, @MaHD, @MaMon, 1, @DonGia)";

                    db.ExecuteNonQuery(sqlInsert, new SqlParameter[]
                    {
                        new SqlParameter("@MaCT", maCT),
                        new SqlParameter("@MaHD", maHD),
                        new SqlParameter("@MaMon", maMon),
                        new SqlParameter("@DonGia", donGia)
                    });
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void TangSL(string maBan, string maMon)
        {
            string maHD = hdDAL.GetHoaDonChuaThanhToan(maBan);
            if (string.IsNullOrEmpty(maHD)) return;

            string sql = @"UPDATE ChiTietHoaDon 
                           SET SoLuong = SoLuong + 1 
                           WHERE MaHD = @MaHD AND MaMon = @MaMon";

            db.ExecuteNonQuery(sql, new SqlParameter[]
            {
                new SqlParameter("@MaHD", maHD),
                new SqlParameter("@MaMon", maMon)
            });
        }

        public void GiamSL(string maBan, string maMon)
        {
            string maHD = hdDAL.GetHoaDonChuaThanhToan(maBan);
            if (string.IsNullOrEmpty(maHD)) return;

            string sqlSL = @"SELECT SoLuong 
                             FROM ChiTietHoaDon 
                             WHERE MaHD = @MaHD AND MaMon = @MaMon";

            object kq = db.ExecuteScalar(sqlSL, new SqlParameter[]
            {
                new SqlParameter("@MaHD", maHD),
                new SqlParameter("@MaMon", maMon)
            });

            int sl = kq == null ? 0 : Convert.ToInt32(kq);

            if (sl <= 1)
            {
                XoaMon(maBan, maMon);
            }
            else
            {
                string sql = @"UPDATE ChiTietHoaDon 
                               SET SoLuong = SoLuong - 1 
                               WHERE MaHD = @MaHD AND MaMon = @MaMon";

                db.ExecuteNonQuery(sql, new SqlParameter[]
                {
                    new SqlParameter("@MaHD", maHD),
                    new SqlParameter("@MaMon", maMon)
                });
            }
        }

        public void XoaMon(string maBan, string maMon)
        {
            string maHD = hdDAL.GetHoaDonChuaThanhToan(maBan);
            if (string.IsNullOrEmpty(maHD)) return;

            string sql = @"DELETE FROM ChiTietHoaDon 
                           WHERE MaHD = @MaHD AND MaMon = @MaMon";

            db.ExecuteNonQuery(sql, new SqlParameter[]
            {
                new SqlParameter("@MaHD", maHD),
                new SqlParameter("@MaMon", maMon)
            });
        }

        public DataTable GetByMaHD(string maHD)
        {
            string sql = @"SELECT 
                                m.TenMon, 
                                ct.SoLuong, 
                                ct.DonGia, 
                                (ct.SoLuong * ct.DonGia) AS ThanhTien
                           FROM ChiTietHoaDon ct 
                           INNER JOIN Mon m ON ct.MaMon = m.MaMon 
                           WHERE ct.MaHD = @MaHD";

            return db.GetDataTable(sql, new SqlParameter[]
            {
                new SqlParameter("@MaHD", maHD)
            });
        }
    }
}

