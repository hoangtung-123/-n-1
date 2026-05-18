USE QuanLyQuanCafe;
GO

-- TÍNH TỔNG TIỀN HÓA ĐƠN
CREATE OR ALTER FUNCTION fn_TongTienHoaDon
(
    @MaHD VARCHAR(10)
)
RETURNS DECIMAL(18,2)
AS
BEGIN
    DECLARE @TongTien DECIMAL(18,2);

    SELECT @TongTien =
        SUM(SoLuong * DonGia)
    FROM ChiTietHoaDon
    WHERE MaHD = @MaHD;

    RETURN ISNULL(@TongTien,0);
END;
GO

-- ĐẾM SỐ BÀN TRỐNG
CREATE OR ALTER FUNCTION fn_SoBanTrong()
RETURNS INT
AS
BEGIN
    DECLARE @SoBan INT;

    SELECT @SoBan = COUNT(*)
    FROM Ban
    WHERE TrangThai = N'Trống';

    RETURN @SoBan;
END;
GO

-- ĐẾM SỐ NHÂN VIÊN
CREATE OR ALTER FUNCTION fn_SoNhanVien()
RETURNS INT
AS
BEGIN
    DECLARE @SoNV INT;

    SELECT @SoNV = COUNT(*)
    FROM NhanVien;

    RETURN @SoNV;
END;
GO