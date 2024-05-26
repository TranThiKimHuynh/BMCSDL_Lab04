﻿
-- CAU LENH TAO DB

-- DROP CONNECTION WITH QLSVNhom
USE master

DECLARE @DatabaseName nvarchar(50)
SET @DatabaseName = N'QLSVNhom'

DECLARE @SQL varchar(max)

SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
FROM MASTER..SysProcesses
WHERE DBId = DB_ID(@DatabaseName) AND SPId <> @@SPId

--SELECT @SQL 
EXEC(@SQL)

-- DROP DATABASE IF QLSV has existed
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'QLSVNhom')
    DROP DATABASE QLSVNhom;
GO

CREATE DATABASE QLSVNhom
GO


USE QLSVNhom

CREATE TABLE SINHVIEN (
	MASV NVARCHAR(20),
	HOTEN NVARCHAR(100) NOT NULL,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR(20),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARCHAR(200) NOT NULL
	PRIMARY KEY (MASV)
)

CREATE TABLE NHANVIEN (
	MANV VARCHAR(20),
	HOTEN NVARCHAR(100) NOT NULL,
	EMAIL VARCHAR(20),
	LUONG VARCHAR(200) ,
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARCHAR(200) NOT NULL,
	PUBKEY VARCHAR(MAX)
	PRIMARY KEY (MANV)
)

CREATE TABLE LOP (
	MALOP VARCHAR(20),
	TENLOP NVARCHAR(100) NOT NULL,
	MANV VARCHAR(20)
	PRIMARY KEY (MALOP)
)

CREATE TABLE HOCPHAN (
	MAHP VARCHAR(20),
	TENHP NVARCHAR(100) NOT NULL,
	SOTC INT
	PRIMARY KEY (MAHP)
)

CREATE TABLE BANGDIEM (
	MASV VARCHAR(20),
	MAHP VARCHAR(20),
	DIEMTHI VARCHAR(200)
	PRIMARY KEY (MASV,MAHP)
)

-- DROP STORE_PROCEDURE 
GO
USE QLSVNhom
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' 
	AND name = 'SP_INS_PUBLIC_ENCRYPT_NHANVIEN')
    DROP PROCEDURE SP_INS_PUBLIC_ENCRYPT_NHANVIEN;
GO
CREATE PROCEDURE SP_INS_PUBLIC_ENCRYPT_NHANVIEN
	@manv varchar(20),
	@hoten nvarchar(100),
	@email varchar(20),
	@luong varchar(200),
	@tendn nvarchar(100),
	@matkhau varchar(200),
	@pub varchar(MAX)

AS
	BEGIN

		INSERT INTO NHANVIEN VALUES (@manv,@hoten,@email,@luong,@tendn,@matkhau,@pub)

	END

GO
-- NVA - abcd12
-- ADMIN - 12345 - 15 triệu 

EXEC SP_INS_PUBLIC_ENCRYPT_NHANVIEN 'SYAD',N'SYSTEM ADMIN','Admin@','keA5TUDTEhS0y6oNIwPubOCGkdrFzjDN0UiIRx2a3z2GheNM5MgPtgKog5zJDjnwy9h5n76nv7itWruvLCWt2boJmVgoyNxUO8aDmUYDMK/Wd68o8qmseI7d0yn8xG4o8cH4FEl9knopG8qIvDkSbY0UyrN2M4HA7U/Y5zmuFQ4=','ADMIN','8CB2237D0679CA88DB6464EAC60DA96345513964','PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4NCjxSU0FQYXJhbWV0ZXJzIHhtbG5zOnhzaT0iaHR0cDovL3d3dy53My5vcmcvMjAwMS9YTUxTY2hlbWEtaW5zdGFuY2UiIHhtbG5zOnhzZD0iaHR0cDovL3d3dy53My5vcmcvMjAwMS9YTUxTY2hlbWEiPg0KICA8RXhwb25lbnQ+QVFBQjwvRXhwb25lbnQ+DQogIDxNb2R1bHVzPjNOMnFqSktsYjRCSk9raEh5U0wyN1I3S1F0Z1VjM0Z1UTNYQWtLVjhDTTZmd1cvSnF0M082eUNUbDFkK05RNlRhSTBNSkZtcjBDVUdKNUZTUTVUYXcrSWRFYTlzYWI1VE5pOHoyWkxDZlZGQ1BDNGE4OGFlb1JmVXQyRGlDVkZOcktJWElHRFdqSHhDOWQyUHBZdEtMVmRrWmxBaXJ6RW5ncmJPNGI1d1M4MD08L01vZHVsdXM+DQo8L1JTQVBhcmFtZXRlcnM+'
EXEC SP_INS_PUBLIC_ENCRYPT_NHANVIEN 'NV01', 'NVA','NVA@', 'q6+NraM8bjh1EGk2d2MSJJ+ffEnUuj26ekBAImx5hNI78j3O/mJOEOlOkMhqPCYsUh3X7isC6Fz6/K6e1rrm1vdZ6d6aKGPMAUc9aXIchRhki8/xEFFpP7H7M5oM3f5EJeM//zYEoMe5wUpN/R+dt6g60nuEfa2M8k77zYgsXXc=', 'NVA', 'C35A37F0BCA08AFA583247CC461CAD9C8082A47C','PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4NCjxSU0FQYXJhbWV0ZXJzIHhtbG5zOnhzaT0iaHR0cDovL3d3dy53My5vcmcvMjAwMS9YTUxTY2hlbWEtaW5zdGFuY2UiIHhtbG5zOnhzZD0iaHR0cDovL3d3dy53My5vcmcvMjAwMS9YTUxTY2hlbWEiPg0KICA8RXhwb25lbnQ+QVFBQjwvRXhwb25lbnQ+DQogIDxNb2R1bHVzPjNOMnFqSktsYjRCSk9raEh5U0wyN1I3S1F0Z1VjM0Z1UTNYQWtLVjhDTTZmd1cvSnF0M082eUNUbDFkK05RNlRhSTBNSkZtcjBDVUdKNUZTUTVUYXcrSWRFYTlzYWI1VE5pOHoyWkxDZlZGQ1BDNGE4OGFlb1JmVXQyRGlDVkZOcktJWElHRFdqSHhDOWQyUHBZdEtMVmRrWmxBaXJ6RW5ncmJPNGI1d1M4MD08L01vZHVsdXM+DQo8L1JTQVBhcmFtZXRlcnM+'
GO

USE QLSVNhom
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' 
	AND name = 'SP_SEL_PUBLIC_ENCRYPT_NHANVIEN')
    DROP PROCEDURE SP_SEL_PUBLIC_ENCRYPT_NHANVIEN;
GO

CREATE PROCEDURE SP_SEL_PUBLIC_ENCRYPT_NHANVIEN 
	@tendn nvarchar(100),
	@mk varchar(200)
AS
	BEGIN
		SELECT nv.MANV, nv.HOTEN, nv.EMAIL, nv.LUONG FROM NHANVIEN nv WHERE nv.TENDN = @tendn AND nv.MATKHAU = @mk
	END

GO

SELECT * FROM NHANVIEN



