USE master;
GO

IF DB_ID('QuanLyQuanCafe') IS NOT NULL
BEGIN
    ALTER DATABASE QuanLyQuanCafe 
    SET SINGLE_USER 
    WITH ROLLBACK IMMEDIATE;

    DROP DATABASE QuanLyQuanCafe;
END
GO

CREATE DATABASE QuanLyQuanCafe
ON PRIMARY
(
    NAME = QuanLyQuanCafe_Data,
    FILENAME = 'D:\QuanLyQuanCafe\QuanLyQuanCafe.mdf',
    SIZE = 10MB,
    MAXSIZE = 500MB,
    FILEGROWTH = 5MB
)
LOG ON
(
    NAME = QuanLyQuanCafe_Log,
    FILENAME = 'D:\QuanLyQuanCafe\QuanLyQuanCafe_log.ldf',
    SIZE = 5MB,
    MAXSIZE = 200MB,
    FILEGROWTH = 5MB
);
GO