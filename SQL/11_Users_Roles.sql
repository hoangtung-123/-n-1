USE master;
GO

-- TẠO LOGIN
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'qlcf_admin')
    CREATE LOGIN qlcf_admin WITH PASSWORD = 'Admin@123';

IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'qlcf_staff')
    CREATE LOGIN qlcf_staff WITH PASSWORD = 'Staff@123';
GO

USE QuanLyQuanCafe;
GO

-- TẠO USER
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'qlcf_admin')
    CREATE USER qlcf_admin FOR LOGIN qlcf_admin;

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'qlcf_staff')
    CREATE USER qlcf_staff FOR LOGIN qlcf_staff;
GO

-- ROLE ADMIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'db_admin_role')
    CREATE ROLE db_admin_role;

-- ROLE NHÂN VIÊN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'db_staff_role')
    CREATE ROLE db_staff_role;
GO

-- GÁN ROLE
ALTER ROLE db_admin_role ADD MEMBER qlcf_admin;
ALTER ROLE db_staff_role ADD MEMBER qlcf_staff;
GO

-- QUYỀN ADMIN (FULL)
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA::dbo TO db_admin_role;
GRANT EXECUTE ON SCHEMA::dbo TO db_admin_role;

-- QUYỀN NHÂN VIÊN (GIỚI HẠN)
GRANT SELECT ON KhuVuc TO db_staff_role;
GRANT SELECT ON Ban TO db_staff_role;
GRANT SELECT ON Mon TO db_staff_role;

GRANT SELECT, INSERT, UPDATE ON HoaDon TO db_staff_role;
GRANT SELECT, INSERT, UPDATE ON ChiTietHoaDon TO db_staff_role;

GRANT SELECT ON NhanVien TO db_staff_role;
GO