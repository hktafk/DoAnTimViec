USE [UngDungTimViec]
GO

/****** Object: Table [dbo].[TaoTaiKhoan] Script Date: 3/20/2024 12:26:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TaoTaiKhoan] (
	[TenTaiKhoan]	NVARCHAR (50) NOT NULL,
	[MatKhau]		NVARCHAR (50) NOT NULL,
    [NguoiDung]		NVARCHAR (50) NOT NULL,
    [Email]			NVARCHAR (50) NOT NULL,
    [DOB]			DATE          NOT NULL,
    [VaiTro]		TINYINT       NOT NULL,

	
);


