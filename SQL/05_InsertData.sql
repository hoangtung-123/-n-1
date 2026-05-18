USE QuanLyQuanCafe;
GO

-- =============================================
-- XÓA DỮ LIỆU CŨ
-- =============================================
DELETE FROM ChiTietPhieuNhap;
DELETE FROM PhieuNhap;
DELETE FROM ChiTietHoaDon;
DELETE FROM HoaDon;
DELETE FROM ChiTietKho;
DELETE FROM NguyenLieu;
DELETE FROM Kho;
DELETE FROM Mon;
DELETE FROM Ban;
DELETE FROM NhanVien;
DELETE FROM KhuVuc;
GO

-- =============================================
-- 1. KHU VỰC (3 khu)
-- =============================================
INSERT INTO KhuVuc (MaKV, TenKV, DiaChi, MaQuanLy)
VALUES
('KV01', N'Tầng 1', N'Hà Nội', NULL),
('KV02', N'Tầng 2', N'Hà Nội', NULL),
('KV03', N'Sân vườn', N'Hà Nội', NULL);
GO

-- =============================================
-- 2. KHO (2 kho)
-- =============================================
INSERT INTO Kho (MaKho, TenKho, TrangThai, NgayTao)
VALUES
('K01', N'Kho chính', N'Hoạt động', GETDATE()),
('K02', N'Kho phụ',   N'Hoạt động', GETDATE());
GO

-- =============================================
-- 3. NGUYÊN LIỆU
-- =============================================
INSERT INTO NguyenLieu (MaNL, TenNL, Gia)
VALUES
('NL01', N'Cà phê', 150000),
('NL02', N'Sữa đặc', 30000),
('NL03', N'Trà', 100000),
('NL04', N'Cam tươi', 50000),
('NL05', N'Bơ', 80000),
('NL06', N'Sô cô la', 120000),
('NL07', N'Đường', 25000),
('NL08', N'Siro', 45000),
('NL09', N'Ly nhựa', 15000),
('NL10', N'Ly giấy', 18000);
GO

-- =============================================
-- 4. CHI TIẾT KHO
-- =============================================
INSERT INTO ChiTietKho (MaCTKho, MaKho, MaNL, SoLuongTon)
VALUES
('CTK01', 'K01', 'NL01', 50),
('CTK02', 'K01', 'NL02', 80),
('CTK03', 'K01', 'NL03', 40),
('CTK04', 'K02', 'NL04', 60),
('CTK05', 'K01', 'NL05', 30),
('CTK06', 'K01', 'NL06', 25),
('CTK07', 'K02', 'NL07', 100),
('CTK08', 'K01', 'NL08', 45),
('CTK09', 'K02', 'NL09', 200),
('CTK10', 'K01', 'NL10', 150);
GO

-- =============================================
-- 5. NHÂN VIÊN (Chỉ dùng KV01, KV02, KV03)
-- =============================================
INSERT INTO NhanVien (MaNV, TenNV, SDT, DiaChi, ChucVu, MaKV, TenDangNhap, MatKhau)
VALUES
('NV01', N'Lưu Hoàng Tùng', '0123456789', N'Hà Nội', N'Quản lý', 'KV01', 'admin', '1234'),
('NV02', N'Nguyễn Văn Bình', '0987654321', N'Hà Nội', N'Nhân viên', 'KV01', 'nv02', '1234'),
('NV03', N'Trần Thị Chi', '0911222333', N'Hà Nội', N'Nhân viên', 'KV02', 'nv03', '1234'),
('NV04', N'Phạm Quốc Anh', '0909888777', N'Hà Nội', N'Nhân viên', 'KV03', 'nv04', '1234'),
('NV05', N'Lê Thị Dung', '0933445566', N'Hà Nội', N'Nhân viên', 'KV01', 'nv05', '1234'),
('NV06', N'Hoàng Minh Quân', '0977888999', N'Hà Nội', N'Nhân viên', 'KV02', 'nv06', '1234'),
('NV07', N'Vũ Thị Hương', '0944556677', N'Hà Nội', N'Nhân viên', 'KV03', 'nv07', '1234'),
('NV08', N'Đặng Văn Nam', '0912345678', N'Hà Nội', N'Nhân viên', 'KV01', 'nv08', '1234'),
('NV09', N'Phan Thị Lan', '0987654320', N'Hà Nội', N'Nhân viên', 'KV02', 'nv09', '1234'),
('NV10', N'Trịnh Minh Hải', '0966778899', N'Hà Nội', N'Nhân viên', 'KV03', 'nv10', '1234');
GO

-- =============================================
-- 6. BÀN (10 bản)
-- =============================================
INSERT INTO Ban (MaBan, LoaiBan, TrangThai, MaKV)
VALUES
('B01', N'4 người', N'Trống', 'KV01'),
('B02', N'4 người', N'Trống', 'KV01'),
('B03', N'6 người', N'Đầy', 'KV02'),
('B04', N'8 người', N'Đã đặt', 'KV02'),
('B05', N'8 người', N'Đầy', 'KV02'),
('B06', N'2 người', N'Trống', 'KV03'),
('B07', N'4 người', N'Trống', 'KV01'),
('B08', N'6 người', N'Trống', 'KV02'),
('B09', N'4 người', N'Đầy', 'KV03'),
('B10', N'8 người', N'Trống', 'KV03');
GO

-- =============================================
-- 7. MÓN (10 bản)
-- =============================================
INSERT INTO Mon (MaMon, TenMon, DonGia, TrangThai)
VALUES
('M01', N'Cà phê đen', 20000, N'Còn bán'),
('M02', N'Cà phê sữa', 25000, N'Còn bán'),
('M03', N'Bạc xỉu', 30000, N'Hết món'),
('M04', N'Trà đào', 35000, N'Còn bán'),
('M05', N'Sinh tố bơ', 45000, N'Còn bán'),
('M06', N'Nước cam', 30000, N'Hết món'),
('M07', N'Latte', 40000, N'Còn bán'),
('M08', N'Capuchino', 45000, N'Còn bán'),
('M09', N'Trà sữa', 35000, N'Còn bán'),
('M10', N'Chocolate nóng', 40000, N'Còn bán');
GO

-- =============================================
-- 8. HÓA ĐƠN (Chỉ trạng thái "Chưa thanh toán" trước)
-- =============================================
INSERT INTO HoaDon (MaHD, MaNV, MaBan, NgayTao, TrangThai)
VALUES
('HD01', 'NV01', 'B03', GETDATE(), N'Chưa thanh toán'),
('HD02', 'NV02', 'B04', GETDATE(), N'Chưa thanh toán'),
('HD03', 'NV03', 'B01', DATEADD(HOUR, -2, GETDATE()), N'Chưa thanh toán'),
('HD04', 'NV01', 'B05', DATEADD(HOUR, -3, GETDATE()), N'Chưa thanh toán'),
('HD05', 'NV04', 'B06', GETDATE(), N'Chưa thanh toán'),
('HD06', 'NV02', 'B02', DATEADD(HOUR, -1, GETDATE()), N'Chưa thanh toán'),
('HD07', 'NV05', 'B07', GETDATE(), N'Chưa thanh toán'),
('HD08', 'NV03', 'B08', DATEADD(HOUR, -4, GETDATE()), N'Chưa thanh toán'),
('HD09', 'NV01', 'B09', GETDATE(), N'Chưa thanh toán');
GO

-- =============================================
-- 9. CHI TIẾT HÓA ĐƠN
-- =============================================
INSERT INTO ChiTietHoaDon (MaCTHD, MaHD, MaMon, SoLuong, DonGia)
VALUES
('CTHD01', 'HD01', 'M01', 2, 20000),
('CTHD02', 'HD01', 'M02', 1, 25000),
('CTHD03', 'HD02', 'M03', 2, 30000),
('CTHD04', 'HD03', 'M04', 3, 35000),
('CTHD05', 'HD04', 'M05', 1, 45000),
('CTHD06', 'HD05', 'M06', 2, 30000),
('CTHD07', 'HD06', 'M07', 2, 40000),
('CTHD08', 'HD07', 'M08', 1, 45000),
('CTHD09', 'HD08', 'M09', 3, 35000),
('CTHD10', 'HD09', 'M10', 2, 40000);
GO

-- Cập nhật một số hóa đơn sang Đã thanh toán
UPDATE HoaDon SET TrangThai = N'Đã thanh toán' 
WHERE MaHD IN ('HD03','HD04','HD06','HD08','HD10');
GO

-- =============================================
-- 10. PHIẾU NHẬP & CHI TIẾT
-- =============================================
INSERT INTO PhieuNhap (MaPN, MaNV, NgayTao, GhiChu, TongTien)
VALUES
('PN01', 'NV01', GETDATE(), N'Nhập cà phê', 950000),
('PN02', 'NV02', GETDATE(), N'Nhập trái cây', 360000),
('PN03', 'NV03', DATEADD(DAY, -1, GETDATE()), N'Nhập đồ uống', 450000),
('PN04', 'NV04', DATEADD(DAY, -2, GETDATE()), N'Nhập nguyên liệu khô', 280000),
('PN05', 'NV01', DATEADD(DAY, -3, GETDATE()), N'Nhập sữa', 520000),
('PN06', 'NV05', GETDATE(), N'Nhập siro', 180000),
('PN07', 'NV02', DATEADD(DAY, -1, GETDATE()), N'Nhập ly giấy', 120000),
('PN08', 'NV06', DATEADD(DAY, -4, GETDATE()), N'Nhập trà', 300000),
('PN09', 'NV03', GETDATE(), N'Nhập socola', 250000),
('PN10', 'NV04', DATEADD(DAY, -2, GETDATE()), N'Nhập đường', 80000);
GO

INSERT INTO ChiTietPhieuNhap (MaCTPN, MaPN, MaNL, SoLuong, GiaNhap)
VALUES
('CTPN01', 'PN01', 'NL01', 5, 140000),
('CTPN02', 'PN01', 'NL02', 10, 25000),
('CTPN03', 'PN02', 'NL04', 8, 45000),
('CTPN04', 'PN03', 'NL03', 6, 90000),
('CTPN05', 'PN04', 'NL05', 12, 75000),
('CTPN06', 'PN05', 'NL06', 4, 110000),
('CTPN07', 'PN06', 'NL07', 20, 20000),
('CTPN08', 'PN07', 'NL09', 100, 1200),
('CTPN09', 'PN08', 'NL03', 15, 85000),
('CTPN10', 'PN09', 'NL10', 50, 1500);
GO

