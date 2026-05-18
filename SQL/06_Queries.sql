USE QuanLyQuanCafe;
GO

-- XEM DỮ LIỆU
SELECT * FROM KhuVuc;
SELECT * FROM NhanVien;
SELECT * FROM Ban;
SELECT * FROM Mon;
SELECT * FROM Kho;
SELECT * FROM NguyenLieu;
SELECT * FROM ChiTietKho;
SELECT * FROM HoaDon;
SELECT * FROM ChiTietHoaDon;
SELECT * FROM PhieuNhap;
SELECT * FROM ChiTietPhieuNhap;
GO

-- DANH SÁCH NHÂN VIÊN + KHU VỰC
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

-- DANH SÁCH BÀN + KHU VỰC
SELECT 
    b.MaBan,
    b.LoaiBan,
    b.TrangThai,
    kv.TenKV
FROM Ban b
JOIN KhuVuc kv
ON b.MaKV = kv.MaKV;
GO

-- DANH SÁCH HÓA ĐƠN
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

-- CHI TIẾT HÓA ĐƠN
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

-- TỔNG TIỀN HÓA ĐƠN
SELECT 
    MaHD,
    SUM(SoLuong * DonGia) AS TongTien
FROM ChiTietHoaDon
GROUP BY MaHD;
GO

-- DANH SÁCH PHIẾU NHẬP
SELECT 
    pn.MaPN,
    nv.TenNV,
    pn.NgayTao
FROM PhieuNhap pn
JOIN NhanVien nv
ON pn.MaNV = nv.MaNV;
GO

-- CHI TIẾT PHIẾU NHẬP
SELECT 
    ctpn.MaCTPN,
    ctpn.MaPN,
    nl.TenNL,
    ctpn.SoLuong,
    ctpn.GiaNhap,
    (ctpn.SoLuong * ctpn.GiaNhap) AS ThanhTien
FROM ChiTietPhieuNhap ctpn
JOIN NguyenLieu nl
ON ctpn.MaNL = nl.MaNL;
GO

-- TỒN KHO
SELECT 
    k.TenKho,
    nl.TenNL,
    ctk.SoLuongTon,
    nl.Gia
FROM ChiTietKho ctk
JOIN Kho k
ON ctk.MaKho = k.MaKho
JOIN NguyenLieu nl
ON ctk.MaNL = nl.MaNL;
GO

-- MÓN CÒN BÁN
SELECT *
FROM Mon
WHERE TrangThai = N'Còn bán';
GO

-- BÀN TRỐNG
SELECT *
FROM Ban
WHERE TrangThai = N'Trống';
GO

-- NHÂN VIÊN QUẢN LÝ
SELECT *
FROM NhanVien
WHERE ChucVu = N'Quản lý';
GO