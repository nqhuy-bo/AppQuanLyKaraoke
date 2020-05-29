USE [master]
GO
/****** Object:  Database [QL_KARAOKE]    Script Date: 05/29/2020 8:21:23 CH ******/
CREATE DATABASE [QL_KARAOKE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_KARAOKE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QL_KARAOKE.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_KARAOKE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QL_KARAOKE_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_KARAOKE] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_KARAOKE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_KARAOKE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_KARAOKE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_KARAOKE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_KARAOKE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_KARAOKE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_KARAOKE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_KARAOKE] SET  MULTI_USER 
GO
ALTER DATABASE [QL_KARAOKE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_KARAOKE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_KARAOKE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_KARAOKE] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_KARAOKE]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MAHOADON] [int] IDENTITY(1,1) NOT NULL,
	[NGAYVAO] [date] NULL,
	[GIOVAO] [time](7) NULL,
	[GIORA] [time](7) NULL,
	[MASANPHAM] [int] NULL,
	[SOLUONG] [int] NULL,
	[THANHTIEN] [int] NULL,
	[MAKHUYENMAI] [int] NULL,
	[MAKHACHHANG] [int] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETNHAPKHO]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETNHAPKHO](
	[MANHAPKHO] [int] IDENTITY(1,1) NOT NULL,
	[MASANPHAM] [int] NULL,
	[NGAYNHAPKHO] [date] NULL,
	[DONVICUNGCAP] [nvarchar](50) NULL,
	[SOLUONGNHAPVAO] [int] NULL,
	[MANHANVIEN] [int] NULL,
	[THANHTIEN] [int] NULL,
 CONSTRAINT [PK_CHITIETNHAPKHO] PRIMARY KEY CLUSTERED 
(
	[MANHAPKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHOADON] [int] IDENTITY(1,1) NOT NULL,
	[MAPHONG] [int] NOT NULL,
	[MANHANVIEN] [int] NOT NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKHACHHANG] [int] IDENTITY(1,1) NOT NULL,
	[TENKHACHHANG] [nvarchar](10) NULL,
	[CMND] [int] NULL,
	[GIOITINH] [nchar](10) NULL,
	[NAMSINH] [int] NULL,
	[DIENTHOAI] [nchar](10) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[MAVIP] [nchar](10) NULL,
	[MAPHONG] [int] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MAKHACHHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHO]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO](
	[MASANPHAM] [int] IDENTITY(1,1) NOT NULL,
	[SOLUONG] [int] NULL,
 CONSTRAINT [PK_KHO] PRIMARY KEY CLUSTERED 
(
	[MASANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHUYENMAI]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUYENMAI](
	[MAKHUYENMAI] [int] IDENTITY(1,1) NOT NULL,
	[GIATRIKHUYENMAI] [int] NOT NULL,
 CONSTRAINT [PK_KHUYENMAI] PRIMARY KEY CLUSTERED 
(
	[MAKHUYENMAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[MALOAIPHONG] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAIPHONG] [nvarchar](50) NULL,
	[DONGIASANG] [int] NULL,
	[DONGIATOI] [int] NULL,
 CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[MALOAIPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[MALOAISANPHAM] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAISANPHAM] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAISANPHAM] PRIMARY KEY CLUSTERED 
(
	[MALOAISANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANHANVIEN] [int] IDENTITY(1,1) NOT NULL,
	[TENNHANVIEN] [nvarchar](100) NULL,
	[TENDANGNHAP] [nchar](50) NULL,
	[MATKHAU] [nchar](20) NULL,
	[PHANQUYEN] [bit] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANHANVIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MAPHONG] [int] IDENTITY(1,1) NOT NULL,
	[TENPHONG] [nvarchar](50) NULL,
	[MALOAIPHONG] [int] NULL,
	[TRANGTHAIPHONG] [nchar](10) NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MAPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUANLYTHUCHI]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLYTHUCHI](
	[MATHUCHI] [int] IDENTITY(1,1) NOT NULL,
	[MANHANVIEN] [int] NULL,
	[LOAI] [bit] NULL,
	[NGAY] [date] NULL,
	[GHICHU] [nvarchar](200) NULL,
 CONSTRAINT [PK_QUANLYTHUCHI] PRIMARY KEY CLUSTERED 
(
	[MATHUCHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 05/29/2020 8:21:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASANPHAM] [int] IDENTITY(1,1) NOT NULL,
	[TENSANPHAM] [nvarchar](50) NULL,
	[GIATIENBANRA] [int] NULL,
	[MALOAISANPHAM] [int] NULL,
	[GIATIENNHAPVAO] [int] NULL,
	[HINHANH] [bit] NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MASANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [TENDANGNHAP], [MATKHAU], [PHANQUYEN]) VALUES (1, N'Quang Huy', N'huyhuy                                            ', N'123456789           ', 1)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADON] ([MAHOADON])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_KHACHHANG] FOREIGN KEY([MAKHACHHANG])
REFERENCES [dbo].[KHACHHANG] ([MAKHACHHANG])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_KHUYENMAI] FOREIGN KEY([MAKHUYENMAI])
REFERENCES [dbo].[KHUYENMAI] ([MAKHUYENMAI])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_KHUYENMAI]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SANPHAM] FOREIGN KEY([MASANPHAM])
REFERENCES [dbo].[SANPHAM] ([MASANPHAM])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SANPHAM]
GO
ALTER TABLE [dbo].[CHITIETNHAPKHO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETNHAPKHO_KHO] FOREIGN KEY([MASANPHAM])
REFERENCES [dbo].[KHO] ([MASANPHAM])
GO
ALTER TABLE [dbo].[CHITIETNHAPKHO] CHECK CONSTRAINT [FK_CHITIETNHAPKHO_KHO]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_PHONG] FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[PHONG] ([MAPHONG])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_PHONG]
GO
ALTER TABLE [dbo].[KHO]  WITH CHECK ADD  CONSTRAINT [FK_KHO_SANPHAM] FOREIGN KEY([MASANPHAM])
REFERENCES [dbo].[SANPHAM] ([MASANPHAM])
GO
ALTER TABLE [dbo].[KHO] CHECK CONSTRAINT [FK_KHO_SANPHAM]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAIPHONG] FOREIGN KEY([MALOAIPHONG])
REFERENCES [dbo].[LOAIPHONG] ([MALOAIPHONG])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAIPHONG]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_LOAISANPHAM] FOREIGN KEY([MALOAISANPHAM])
REFERENCES [dbo].[LOAISANPHAM] ([MALOAISANPHAM])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_LOAISANPHAM]
GO
USE [master]
GO
ALTER DATABASE [QL_KARAOKE] SET  READ_WRITE 
GO
