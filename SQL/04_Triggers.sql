USE QuanLyQuanCafe;
GO

-- XÓA TRIGGER CŨ
DROP TRIGGER IF EXISTS trg_CheckHoaDon;
DROP TRIGGER IF EXISTS trg_Ban_Insert;
DROP TRIGGER IF EXISTS trg_Ban_Update;
DROP TRIGGER IF EXISTS trg_NhapKho;
DROP TRIGGER IF EXISTS trg_XoaCTHD;
GO

-- KHÔNG CHO THÊM MÓN VÀO HÓA ĐƠN ĐÃ THANH TOÁN
CREATE OR ALTER TRIGGER trg_CheckHoaDon
ON ChiTietHoaDon
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN HoaDon hd
        ON i.MaHD = hd.MaHD
        WHERE hd.TrangThai = N'Đã thanh toán'
    )
    BEGIN
        RAISERROR(N'Hóa đơn đã thanh toán',16,1);
        RETURN;
    END

    INSERT INTO ChiTietHoaDon
    (MaCTHD, MaHD, MaMon, SoLuong, DonGia)
    SELECT
        MaCTHD,
        MaHD,
        MaMon,
        SoLuong,
        DonGia
    FROM inserted;
END;
GO

-- CẬP NHẬT TRẠNG THÁI BÀN KHI TẠO HÓA ĐƠN
CREATE OR ALTER TRIGGER trg_Ban_Insert
ON HoaDon
AFTER INSERT
AS
BEGIN
    UPDATE Ban
    SET TrangThai = N'Đầy'
    WHERE MaBan IN (
        SELECT MaBan
        FROM inserted
    );
END;
GO

-- CẬP NHẬT TRẠNG THÁI BÀN KHI THANH TOÁN
CREATE OR ALTER TRIGGER trg_Ban_Update
ON HoaDon
AFTER UPDATE
AS
BEGIN
    IF UPDATE(TrangThai)
    BEGIN
        UPDATE Ban
        SET TrangThai = N'Trống'
        WHERE MaBan IN (
            SELECT MaBan
            FROM inserted
            WHERE TrangThai = N'Đã thanh toán'
        );
    END
END;
GO

-- CẬP NHẬT TỒN KHO KHI NHẬP HÀNG
CREATE OR ALTER TRIGGER trg_NhapKho
ON ChiTietPhieuNhap
AFTER INSERT
AS
BEGIN
    UPDATE ctk
    SET ctk.SoLuongTon = ctk.SoLuongTon + i.SoLuong
    FROM ChiTietKho ctk
    JOIN inserted i
    ON ctk.MaNL = i.MaNL;
END;
GO

-- TỰ ĐỘNG CẬP NHẬT BÀN TRỐNG KHI XÓA HẾT CHI TIẾT HÓA ĐƠN
CREATE OR ALTER TRIGGER trg_XoaCTHD
ON ChiTietHoaDon
AFTER DELETE
AS
BEGIN
    UPDATE Ban
    SET TrangThai = N'Trống'
    WHERE MaBan IN (
        SELECT hd.MaBan
        FROM HoaDon hd
        WHERE hd.MaHD IN (
            SELECT d.MaHD
            FROM deleted d
        )
        AND NOT EXISTS (
            SELECT 1
            FROM ChiTietHoaDon ct
            WHERE ct.MaHD = hd.MaHD
        )
    );
END;
GO