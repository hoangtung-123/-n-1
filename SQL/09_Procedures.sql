USE QuanLyQuanCafe;
GO

-- ĐĂNG NHẬP
CREATE OR ALTER PROC sp_DangNhap
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(100)
AS
BEGIN
    SELECT *
    FROM NhanVien
    WHERE TenDangNhap = @TenDangNhap
    AND MatKhau = @MatKhau;
END;
GO

-- THÊM MÓN
CREATE OR ALTER PROC sp_ThemMon
    @MaMon VARCHAR(10),
    @TenMon NVARCHAR(100),
    @DonGia DECIMAL(10,2),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO Mon
    VALUES(@MaMon,@TenMon,@DonGia,@TrangThai);
END;
GO

-- XÓA MÓN
CREATE OR ALTER PROC sp_XoaMon
    @MaMon VARCHAR(10)
AS
BEGIN
    DELETE FROM Mon
    WHERE MaMon = @MaMon;
END;
GO

-- THANH TOÁN HÓA ĐƠN
CREATE OR ALTER PROC sp_ThanhToan
    @MaHD VARCHAR(10)
AS
BEGIN
    UPDATE HoaDon
    SET TrangThai = N'Đã thanh toán'
    WHERE MaHD = @MaHD;
END;
GO

-- TÌM NHÂN VIÊN
CREATE OR ALTER PROC sp_TimNhanVien
    @TenNV NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM NhanVien
    WHERE TenNV LIKE '%' + @TenNV + '%';
END;
GO