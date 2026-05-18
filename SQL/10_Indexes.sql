USE QuanLyQuanCafe;
GO

-- INDEX cho khóa ngoại (tăng tốc JOIN)

CREATE INDEX IX_NhanVien_MaKV ON NhanVien(MaKV);
CREATE INDEX IX_Ban_MaKV ON Ban(MaKV);

CREATE INDEX IX_HoaDon_MaNV ON HoaDon(MaNV);
CREATE INDEX IX_HoaDon_MaBan ON HoaDon(MaBan);

CREATE INDEX IX_ChiTietHoaDon_MaHD ON ChiTietHoaDon(MaHD);
CREATE INDEX IX_ChiTietHoaDon_MaMon ON ChiTietHoaDon(MaMon);

CREATE INDEX IX_PhieuNhap_MaNV ON PhieuNhap(MaNV);

CREATE INDEX IX_ChiTietPhieuNhap_MaPN ON ChiTietPhieuNhap(MaPN);
CREATE INDEX IX_ChiTietPhieuNhap_MaNL ON ChiTietPhieuNhap(MaNL);

CREATE INDEX IX_ChiTietKho_MaKho ON ChiTietKho(MaKho);
CREATE INDEX IX_ChiTietKho_MaNL ON ChiTietKho(MaNL);

-- INDEX phục vụ tìm kiếm nhanh
CREATE INDEX IX_Mon_TenMon ON Mon(TenMon);
CREATE INDEX IX_NguyenLieu_TenNL ON NguyenLieu(TenNL);

-- UNIQUE login tối ưu tra cứu đăng nhập
CREATE INDEX IX_NhanVien_TenDangNhap ON NhanVien(TenDangNhap);
GO