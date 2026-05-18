USE QuanLyQuanCafe;
GO

-- VIEW NHÂN VIÊN + KHU VỰC
CREATE OR ALTER VIEW vw_NhanVien_KhuVuc
AS
SELECT 
    nv.MaNV,
    nv.TenNV,
    nv.SDT,
    nv.DiaChi,
    nv.ChucVu,
    kv.TenKV,
    nv.TenDangNhap
FROM NhanVien nv
JOIN KhuVuc kv
ON nv.MaKV = kv.MaKV;
GO

-- VIEW HÓA ĐƠN
CREATE OR ALTER VIEW vw_HoaDon
AS
SELECT 
    hd.MaHD,
    nv.TenNV,
    b.MaBan,
    hd.NgayTao,
    hd.TrangThai
FROM HoaDon hd
JOIN NhanVien nv
ON hd.MaNV = nv.MaNV
JOIN Ban b
ON hd.MaBan = b.MaBan;
GO

-- VIEW CHI TIẾT HÓA ĐƠN
CREATE OR ALTER VIEW vw_ChiTietHoaDon
AS
SELECT 
    ct.MaCTHD,
    ct.MaHD,
    m.TenMon,
    ct.SoLuong,
    ct.DonGia,
    ct.ThanhTien
FROM ChiTietHoaDon ct
JOIN Mon m
ON ct.MaMon = m.MaMon;
GO

-- VIEW TỔNG TIỀN HÓA ĐƠN
CREATE OR ALTER VIEW vw_TongTienHoaDon
AS
SELECT 
    MaHD,
    SUM(SoLuong * DonGia) AS TongTien
FROM ChiTietHoaDon
GROUP BY MaHD;
GO