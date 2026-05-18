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
    public class NhanVienDAL : DBConnect
    {
        private readonly DBConnect db = new DBConnect();

        public DataTable GetAll()
        {
            string sql = @"SELECT 
                            nv.MaNV,
                            nv.TenNV,
                            nv.SDT,
                            nv.DiaChi,
                            nv.ChucVu,
                            nv.MaKV,
                            kv.TenKV,
                            nv.TenDangNhap,
                            nv.MatKhau
                        FROM NhanVien nv
                        JOIN KhuVuc kv ON nv.MaKV = kv.MaKV
                        ORDER BY nv.MaNV";

            return db.GetDataTable(sql);
        }

        public DataTable GetQuanLy()
        {
            string sql = @"SELECT MaNV, TenNV, ChucVu 
                           FROM NhanVien 
                           WHERE ChucVu IN (N'Quản lý', N'Nhân viên') 
                           ORDER BY ChucVu DESC, TenNV";

            return GetDataTable(sql);
        }

        public bool Insert(NhanVien nv)
        {
            string sql = @"
                INSERT INTO NhanVien 
                VALUES(@MaNV, @TenNV, @SDT, @DiaChi, @ChucVu, @MaKV, @TenDangNhap, @MatKhau)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@ChucVu", nv.ChucVu),
                new SqlParameter("@MaKV", nv.MaKV),
                new SqlParameter("@TenDangNhap", nv.TenDangNhap),
                new SqlParameter("@MatKhau", nv.MatKhau)
            };

            int kq = db.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }

        public bool Update(NhanVien nv)
        {
            string sql = @"
                UPDATE NhanVien
                SET TenNV = @TenNV,
                    SDT = @SDT,
                    DiaChi = @DiaChi,
                    ChucVu = @ChucVu,
                    MaKV = @MaKV,
                    TenDangNhap = @TenDangNhap,
                    MatKhau = @MatKhau
                WHERE MaNV = @MaNV";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@ChucVu", nv.ChucVu),
                new SqlParameter("@MaKV", nv.MaKV),
                new SqlParameter("@TenDangNhap", nv.TenDangNhap),
                new SqlParameter("@MatKhau", nv.MatKhau)
            };

            int kq = db.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }

        public bool Delete(string maNV)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";

            int kq = db.ExecuteNonQuery(sql, new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV)
            });

            return kq > 0;
        }

        public bool Exists(string maNV)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";

            int count = Convert.ToInt32(db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV)
            }));

            return count > 0;
        }

        public bool ExistsUsername(string username)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE TenDangNhap = @TenDangNhap";

            int count = Convert.ToInt32(db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", username)
            }));

            return count > 0;
        }

        public bool ExistsSDT(string sdt)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE SDT = @SDT";

            int count = Convert.ToInt32(db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@SDT", sdt)
            }));

            return count > 0;
        }

        public bool ExistsSDTUpdate(string sdt, string maNV)
        {
            string sql = @"
                SELECT COUNT(*) 
                FROM NhanVien 
                WHERE SDT = @SDT AND MaNV <> @MaNV";

            int count = Convert.ToInt32(db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@MaNV", maNV)
            }));

            return count > 0;
        }

        public bool ExistsUsernameUpdate(string username, string maNV)
        {
            string sql = @"
                SELECT COUNT(*) 
                FROM NhanVien 
                WHERE TenDangNhap = @TenDangNhap AND MaNV <> @MaNV";

            int count = Convert.ToInt32(db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", username),
                new SqlParameter("@MaNV", maNV)
            }));

            return count > 0;
        }

        public bool IsUsed(string maNV)
        {
            string sql = @"
                SELECT 
                (
                    (SELECT COUNT(*) FROM HoaDon WHERE MaNV = @MaNV) +
                    (SELECT COUNT(*) FROM PhieuNhap WHERE MaNV = @MaNV) +
                    (SELECT COUNT(*) FROM KhuVuc WHERE MaQuanLy = @MaNV)
                ) AS Total";

            int count = Convert.ToInt32(db.ExecuteScalar(sql, new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV)
            }));

            return count > 0;
        }
    }
}
