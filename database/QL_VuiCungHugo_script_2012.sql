USE [master]
GO

ALTER DATABASE [QL_VuiCungHugo] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_VuiCungHugo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_VuiCungHugo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_VuiCungHugo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_VuiCungHugo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_VuiCungHugo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_VuiCungHugo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_VuiCungHugo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_VuiCungHugo] SET  MULTI_USER 
GO
ALTER DATABASE [QL_VuiCungHugo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_VuiCungHugo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_VuiCungHugo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_VuiCungHugo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_VuiCungHugo', N'ON'
GO
USE [QL_VuiCungHugo]
GO
/****** Object:  Table [dbo].[DangKy]    Script Date: 18/11/2022 2:39:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKy](
	[Ma_NguoiChoi] [nvarchar](20) NOT NULL,
	[Ten_NguoiChoi] [nvarchar](50) NULL,
	[SoDT_NguoiChoi] [nvarchar](12) NULL,
	[DiaChi_NguoiChoi] [nvarchar](50) NULL,
	[Ngay_DangKy] [datetime] NULL,
	[Tinh_Thanh] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 18/11/2022 2:39:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[Ma_NguoiChoi] [nvarchar](20) NOT NULL,
	[Ma_TroChoi] [nvarchar](5) NOT NULL,
	[Vong] [smallint] NOT NULL,
	[Ngay_Choi] [datetime] NULL,
	[Diem] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 18/11/2022 2:39:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MSNV] [nvarchar](5) NOT NULL,
	[HoLot] [nvarchar](25) NULL,
	[Ten] [nvarchar](12) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[QuyenSD] [nvarchar](20) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TroChoi]    Script Date: 18/11/2022 2:39:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TroChoi](
	[Ma_TC] [nvarchar](5) NOT NULL,
	[Ten_TC] [nvarchar](50) NULL,
	[Dien_Giai] [nvarchar](50) NULL,
	[MSNV] [nvarchar](5) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0001', N'Trần Quỵ', N'8691800', N'78 đường GiảI Phóng', CAST(0x000095BB00000000 AS DateTime), N'HÀ NỘI')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0002', N'Lê Văn Trạch', N'9714526', N'Số 1 Trần Khánh Dư', CAST(0x000095BB00000000 AS DateTime), N'HÀ NỘI')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0003', N'Trần Ngọc Ân', N'7543832', N'Phường Nghĩa Tân', CAST(0x0000963400000000 AS DateTime), N'HÀ NỘI')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0004', N'Trần Văn Trường', N'8269723', N'40B Tràng Thi', CAST(0x0000963400000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0005', N'Nguyễn Thị Ngọc Dinh', N'8697033', N'78 đường GiảI Phóng', CAST(0x0000963E00000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0006', N'Tôn Thị Kim Thanh', N'8226672', N'85', CAST(0x0000963400000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0007', N'Mai Xuân Trường', N'8341676', N'SỐ 9 ĐƯỜNG XT- P MD', CAST(0x0000963E00000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0008', N'Tạ Văn Bình', N'5621037', N'YÊN LÃNG THÁI THỊNH', CAST(0x0000963E00000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0009', N'Nguyễn Bá Đức', N'8246652', N'43 PHO QUAN SU', CAST(0x0000963400000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0010', N'Nguyễn Tiến Quyết', N'8289267', N'40 TRÀNG THI', CAST(0x0000963E00000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0011', N'Nguyễn Đức Vy', N'8259281', N'43 TRÀNG THI - HOÀN KIẾM', CAST(0x000095BB00000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0012', N'Nguyễn Thanh Liêm', N'7754082', N'PHỐ GIẢNG VÕ', CAST(0x0000963E00000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0013', N'Nguyễn Tài Thu', N'8534275', N'SỐ 49 THÁI THỊNH', CAST(0x0000963E00000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0014', N'Đinh Ngọc Sỹ', N'7613723', N'463 HOÀNG HOA THÁM', CAST(0x0000963400000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0015', N'Nguyễn Thị Bích Đào', N'5112506', N'192 NGUYỄN LƯƠNG BẰNG', CAST(0x0000963400000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0016', N'Nguyễn Bá Kinh', N'8210421', N'42 PHỐ THANH NHÀN', CAST(0x0000963E00000000 AS DateTime), N'TP. Hồ Chí Minh')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0017', N'Lê Văn Điểm', N'8233060', N'12 CHU VĂN AN', CAST(0x000095BB00000000 AS DateTime), N'TP. Hồ Chí Minh')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0018', N'Nguyễn Thị Thoa', N'9344362', N'37 HAI BÀ TRƯNG', CAST(0x0000963E00000000 AS DateTime), N'TP. Hồ Chí Minh')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0019', N'Nguyễn Thọ Khảo', N'883...', N'UY NỖ THỊ TRẤN ĐÔNG ANH', CAST(0x0000963E00000000 AS DateTime), N'TP. Hồ Chí Minh')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0020', N'Lê Văn Thảo', N'831301', N'42 THANH NHÀN', CAST(0x000095BB00000000 AS DateTime), N'TP. Hồ Chí Minh')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0021', N'Đỗ Thuý Lan', N'6270499', N'PHỐ HỒNG MAI', CAST(0x0000963E00000000 AS DateTime), N'TP. Hồ Chí Minh')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0022', N'Bùi Sương', N'7751779', N'ĐƯỜNG LA THÀNH P N.KHÁNH', CAST(0x0000963400000000 AS DateTime), N'TP. Hồ Chí Minh')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0023', N'Nguyễn Minh HảI', N'8751246', N'THỊ TRẤN SÀI ĐỒNG', CAST(0x000095BB00000000 AS DateTime), N'Long An')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0024', N'Nguyễn Thị Ánh', N'8289267', N'78 đường GiảI Phóng', CAST(0x000095BC00000000 AS DateTime), N'HÀ NỘI')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0025', N'Trần Bảo Châu', N'8259281', N'85', CAST(0x000095BD00000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0026', N'Nguyễn Quốc Cường', N'7754082', N'SỐ 9 ĐƯỜNG XT- P MD', CAST(0x000095BE00000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0027', N'Dương Thị Xuân Đao', N'8534275', N'YÊN LÃNG THÁI THỊNH', CAST(0x000095BF00000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0028', N'Huỳnh Trường Giang', N'7613723', N'43 PHO QUAN SU', CAST(0x000095C000000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0029', N'Nguyễn Thị Hồng Hạnh', N'831301', N'40 TRÀNG THI', CAST(0x000095C100000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0030', N'Nguyễn Thị Phương Oanh', N'8210421', N'43 TRÀNG THI - HOÀN KIẾM', CAST(0x000095C200000000 AS DateTime), N'Cần thơ')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0031', N'Nguyễn Duy Hùng', N'8233060', N'PHỐ GIẢNG VÕ', CAST(0x000095C300000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0032', N'Triệu Ngọc Lan', N'9344362', N'SỐ 49 THÁI THỊNH', CAST(0x000095C400000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0033', N'Trần Thị Bạch Lê', N'883...', N'463 HOÀNG HOA THÁM', CAST(0x000095C500000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0034', N'Huỳnh Quốc Nam', N'831301', N'192 NGUYỄN LƯƠNG BẰNG', CAST(0x000095C600000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0035', N'Lê Thị Kim Như', N'6270499', N'42 PHỐ THANH NHÀN', CAST(0x000095C700000000 AS DateTime), N'Tiền Giang')
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0036', N'Võ Ngọc Tâm', N'7751779', N'12 CHU VĂN AN', CAST(0x000095C800000000 AS DateTime), NULL)
INSERT [dbo].[DangKy] ([Ma_NguoiChoi], [Ten_NguoiChoi], [SoDT_NguoiChoi], [DiaChi_NguoiChoi], [Ngay_DangKy], [Tinh_Thanh]) VALUES (N'NC02_03_0037', N'Đào Thị Ngọc Thanh', N'8751246', N'37 HAI BÀ TRƯNG', CAST(0x000095C900000000 AS DateTime), NULL)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0001', N'HG01', 1, CAST(0x000095BB00000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0001', N'HG03', 2, CAST(0x000095BB00000000 AS DateTime), 223)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0002', N'HG02', 1, CAST(0x000095C500000000 AS DateTime), 300)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0002', N'HG01', 2, CAST(0x000095C500000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0003', N'HG03', 1, CAST(0x0000963400000000 AS DateTime), 522)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0003', N'HG03', 2, CAST(0x0000963400000000 AS DateTime), 522)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0003', N'HG01', 3, CAST(0x0000963400000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0004', N'HG01', 1, CAST(0x0000963400000000 AS DateTime), 422)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0004', N'HG01', 2, CAST(0x0000963400000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0004', N'HG03', 3, CAST(0x0000963400000000 AS DateTime), 522)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0005', N'HG02', 1, CAST(0x0000963E00000000 AS DateTime), 662)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0005', N'HG02', 2, CAST(0x0000963E00000000 AS DateTime), 300)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0005', N'HG01', 3, CAST(0x0000963E00000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0006', N'HG03', 1, CAST(0x0000963400000000 AS DateTime), 852)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0006', N'HG03', 2, CAST(0x0000963400000000 AS DateTime), 522)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0006', N'HG02', 3, CAST(0x0000963400000000 AS DateTime), 300)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0007', N'HG03', 1, CAST(0x0000963E00000000 AS DateTime), 223)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0007', N'HG03', 2, CAST(0x0000963E00000000 AS DateTime), 422)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0008', N'HG01', 1, CAST(0x0000963E00000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0008', N'HG01', 2, CAST(0x0000963E00000000 AS DateTime), 662)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0009', N'HG03', 1, CAST(0x0000963400000000 AS DateTime), 522)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0009', N'HG02', 2, CAST(0x0000963400000000 AS DateTime), 852)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0010', N'HG01', 1, CAST(0x0000963E00000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0010', N'HG03', 2, CAST(0x0000963E00000000 AS DateTime), 223)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0011', N'HG02', 1, CAST(0x000095C500000000 AS DateTime), 300)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0011', N'HG03', 2, CAST(0x000095C500000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0012', N'HG03', 1, CAST(0x0000963E00000000 AS DateTime), 522)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0012', N'HG01', 2, CAST(0x0000963E00000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0013', N'HG03', 1, CAST(0x0000963E00000000 AS DateTime), 422)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0013', N'HG02', 2, CAST(0x0000963E00000000 AS DateTime), 300)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0013', N'HG01', 3, CAST(0x0000963E00000000 AS DateTime), 300)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0014', N'HG01', 1, CAST(0x0000963400000000 AS DateTime), 662)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0014', N'HG03', 2, CAST(0x0000963400000000 AS DateTime), 522)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0014', N'HG01', 3, CAST(0x0000963400000000 AS DateTime), 522)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0015', N'HG02', 1, CAST(0x0000963400000000 AS DateTime), 852)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0015', N'HG01', 2, CAST(0x0000963400000000 AS DateTime), 422)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0015', N'HG02', 3, CAST(0x0000963400000000 AS DateTime), 422)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0016', N'HG03', 1, CAST(0x0000963E00000000 AS DateTime), 223)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0016', N'HG02', 2, CAST(0x0000963E00000000 AS DateTime), 662)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0016', N'HG03', 3, CAST(0x0000963E00000000 AS DateTime), 662)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0017', N'HG03', 1, CAST(0x000095BB00000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0017', N'HG03', 2, CAST(0x000095BB00000000 AS DateTime), 852)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0018', N'HG01', 1, CAST(0x0000963E00000000 AS DateTime), 300)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0018', N'HG03', 2, CAST(0x0000963E00000000 AS DateTime), 223)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0019', N'HG01', 1, CAST(0x0000963E00000000 AS DateTime), 522)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0019', N'HG01', 2, CAST(0x0000963E00000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0019', N'HG03', 3, CAST(0x0000963E00000000 AS DateTime), 223)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0020', N'HG02', 1, CAST(0x000095BB00000000 AS DateTime), 422)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0020', N'HG03', 2, CAST(0x000095BB00000000 AS DateTime), 522)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0020', N'HG03', 3, CAST(0x000095BB00000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0021', N'HG03', 1, CAST(0x0000963E00000000 AS DateTime), 662)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0021', N'HG01', 2, CAST(0x0000963E00000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0021', N'HG01', 3, CAST(0x0000963E00000000 AS DateTime), 200)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0022', N'HG03', 1, CAST(0x0000963400000000 AS DateTime), 852)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0023', N'HG01', 1, CAST(0x000095C500000000 AS DateTime), 223)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0001', N'HG06', 1, CAST(0x0000ADD300000000 AS DateTime), 25)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0001', N'HG04', 1, CAST(0x0000ADD300000000 AS DateTime), 367)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0002', N'HG04', 2, CAST(0x0000ADD300000000 AS DateTime), 65)
INSERT [dbo].[KetQua] ([Ma_NguoiChoi], [Ma_TroChoi], [Vong], [Ngay_Choi], [Diem]) VALUES (N'NC02_03_0004', N'HG02', 1, CAST(0x000095BB00000000 AS DateTime), 1212)
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV001', N'Le', N'Giang', N'NV001', N'Quản lý')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV002', N'Tran Duc', N'Nam', N'NV002', N'Kế toán')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV009', N'Nguyen Kim', N'Nga', N'NV009', N'Dẫn chương trình')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV010', N'Lam Hoang', N'Thanh', N'NV010', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV014', N'Nguyen Thai', N'Bang', N'NV014', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV016', N'Nguyen Thanh', N'Son', N'NV016', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV018', N'Vu Huong', N'Giang', N'NV018', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV025', N'Tran Le', N'Hoa', N'NV025', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV061', N'Tran Thuong', N'Giang', N'NV061', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV072', N'Nguyen Mai', N'Phuong', N'NV072', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV106', N'Tran Hai', N'Yen', N'NV106', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV120', N'Lam Tuan', N'Khanh', N'NV120', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MSNV], [HoLot], [Ten], [MatKhau], [QuyenSD]) VALUES (N'NV125', N'Ha Thanh', N'Xuan', N'NV125', N'Nhân viên')
INSERT [dbo].[TroChoi] ([Ma_TC], [Ten_TC], [Dien_Giai], [MSNV]) VALUES (N'HG01', N'Hugo thám hiểm Đại dương', N'Cố gắng tránh xa loài cá ăn thịt và ..', N'NV001')
INSERT [dbo].[TroChoi] ([Ma_TC], [Ten_TC], [Dien_Giai], [MSNV]) VALUES (N'HG02', N'Cơn sốt Kim cương', N'Cố gắng tránh xa loài hoa an thịt', N'NV001')
INSERT [dbo].[TroChoi] ([Ma_TC], [Ten_TC], [Dien_Giai], [MSNV]) VALUES (N'HG03', N'Hugo lái Máy bay', N'Vượt qua chướng ngại vật', N'NV009')
INSERT [dbo].[TroChoi] ([Ma_TC], [Ten_TC], [Dien_Giai], [MSNV]) VALUES (N'HG04', N'Đi tìm kho báo', N'Đi tìm kho báo', N'NV009')
INSERT [dbo].[TroChoi] ([Ma_TC], [Ten_TC], [Dien_Giai], [MSNV]) VALUES (N'HG05', N'Làm theo chỉ dẫn', N'Làm theo chỉ dãn của chú khỉ', N'NV010')
INSERT [dbo].[TroChoi] ([Ma_TC], [Ten_TC], [Dien_Giai], [MSNV]) VALUES (N'HG06', N'Hugo mạo hiểm', N'Hugo mạo hiểm', N'NV018')
SET ANSI_PADDING ON

GO
/****** Object:  Index [aaaaaDangKy_PK]    Script Date: 18/11/2022 2:39:38 PM ******/
ALTER TABLE [dbo].[DangKy] ADD  CONSTRAINT [aaaaaDangKy_PK] PRIMARY KEY NONCLUSTERED 
(
	[Ma_NguoiChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [aaaaaKetQua_PK]    Script Date: 18/11/2022 2:39:38 PM ******/
ALTER TABLE [dbo].[KetQua] ADD  CONSTRAINT [aaaaaKetQua_PK] PRIMARY KEY NONCLUSTERED 
(
	[Ma_NguoiChoi] ASC,
	[Vong] ASC,
	[Ma_TroChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [DangKy_ChoiKetQua_Choi]    Script Date: 18/11/2022 2:39:38 PM ******/
CREATE NONCLUSTERED INDEX [DangKy_ChoiKetQua_Choi] ON [dbo].[KetQua]
(
	[Ma_NguoiChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [Tro_ChoiKetQua_Choi]    Script Date: 18/11/2022 2:39:38 PM ******/
CREATE NONCLUSTERED INDEX [Tro_ChoiKetQua_Choi] ON [dbo].[KetQua]
(
	[Ma_TroChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [aaaaaNhanVien_PK]    Script Date: 18/11/2022 2:39:38 PM ******/
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [aaaaaNhanVien_PK] PRIMARY KEY NONCLUSTERED 
(
	[MSNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [aaaaaTroChoi_PK]    Script Date: 18/11/2022 2:39:38 PM ******/
ALTER TABLE [dbo].[TroChoi] ADD  CONSTRAINT [aaaaaTroChoi_PK] PRIMARY KEY NONCLUSTERED 
(
	[Ma_TC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [NhanVienTroChoi]    Script Date: 18/11/2022 2:39:38 PM ******/
CREATE NONCLUSTERED INDEX [NhanVienTroChoi] ON [dbo].[TroChoi]
(
	[MSNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_TroChoi] FOREIGN KEY([Ma_TroChoi])
REFERENCES [dbo].[TroChoi] ([Ma_TC])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_TroChoi]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [KetQua_FK00] FOREIGN KEY([Ma_NguoiChoi])
REFERENCES [dbo].[DangKy] ([Ma_NguoiChoi])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [KetQua_FK00]
GO
ALTER TABLE [dbo].[TroChoi]  WITH CHECK ADD  CONSTRAINT [TroChoi_FK00] FOREIGN KEY([MSNV])
REFERENCES [dbo].[NhanVien] ([MSNV])
GO
ALTER TABLE [dbo].[TroChoi] CHECK CONSTRAINT [TroChoi_FK00]
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'ᵠ㋚胾䤀᢬떆䗓韃' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Ma_NguoiChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Ma_NguoiChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'DangKy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'2430' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'�ⴠᡅ䥾讶鮣' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Ten_NguoiChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Ten_NguoiChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'DangKy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ten_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'霏兿靱仠喫笄愲' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'SoDT_NguoiChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'SoDT_NguoiChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'DangKy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'SoDT_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'쪘殓꺅䰉ƇᎪ�桲' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'DiaChi_Nguoichoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'DiaChi_Nguoichoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'DangKy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'DiaChi_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'瘝룂悷䙀隠鷤�갛' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Ngay_DangKy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'ShowDatePicker', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'8' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Ngay_DangKy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'DangKy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'8' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Ngay_DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'웟있⵺亷�㫶疤' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Tinh_Thanh' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'5' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Tinh_Thanh' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'DangKy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy', @level2type=N'COLUMN',@level2name=N'Tinh_Thanh'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackShade', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackTint', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'BackShade', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'BackTint', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'DatasheetForeThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'DatasheetGridlinesThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'DateCreated', @value=N'19/05/05 1:35:31 PM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'DisplayViewsOnSharePointSite', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'FilterOnLoad', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'HideNewField', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'LastUpdated', @value=N'27/04/16 10:18:24 AM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DefaultView', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_OrderByOn', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Orientation', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'DangKy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'OrderByOnLoad', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'RecordCount', @value=N'37' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'ThemeFontIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'TotalsRow', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'Updatable', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DangKy'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'1545' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'尺㩀䕼ᦌ幏壷ꦴ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Ma_NguoiChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Ma_NguoiChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'KetQua' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_NguoiChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'1290' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'숒䘠枞잮⮳' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Ma_TroChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Ma_TroChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'KetQua' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ma_TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'645' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'ﶤ鵞䵭龞怤ㆣꌰ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DecimalPlaces', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Vong' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'8' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Vong' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'KetQua' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'7' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Vong'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'1170' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'쁘ᤧ麑䴚⾽苛傅ዲ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Ngay_Choi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'ShowDatePicker', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'8' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Ngay_Choi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'KetQua' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'8' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Ngay_Choi'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'900' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'쟹ﻚ䣠잜︴' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DecimalPlaces', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'SoDiem' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'8' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'SoDiem' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'KetQua' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'7' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua', @level2type=N'COLUMN',@level2name=N'Diem'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackShade', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackTint', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'BackShade', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'BackTint', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'DatasheetForeThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'DatasheetGridlinesThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'DateCreated', @value=N'19/05/05 1:35:42 PM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'DisplayViewsOnSharePointSite', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'FilterOnLoad', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'HideNewField', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'LastUpdated', @value=N'27/04/16 10:18:24 AM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DefaultView', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_OrderByOn', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Orientation', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'KetQua' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'OrderByOnLoad', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'RecordCount', @value=N'55' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'ThemeFontIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'TotalsRow', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'Updatable', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KetQua'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'뙍Ⱘ梨䙋⊔�ᤜᵖ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'MsNV' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'50' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'MsNV' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'NhanVien' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'㾟溶䷍莭롯떼' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'HoLot' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'50' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'HoLot' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'NhanVien' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoLot'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'㳽⣉䠉鞸箟៓⌹' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Ten' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'50' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Ten' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'NhanVien' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Ten'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'塢慯崎䣙ᦥ✉껩쿝' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'QuyenSD' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'50' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'QuyenSD' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'NhanVien' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'し䶰䎙ꑭ녛䬩' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'MatKhau' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'5' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'50' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'MatKhau' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'NhanVien' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'QuyenSD'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackShade', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackTint', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'BackShade', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'BackTint', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'DatasheetForeThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'DatasheetGridlinesThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'DateCreated', @value=N'27/04/16 9:38:50 AM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'DisplayViewsOnSharePointSite', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'FilterOnLoad', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'HideNewField', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'LastUpdated', @value=N'27/04/16 10:18:24 AM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DefaultView', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_OrderByOn', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Orientation', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'NhanVien' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'OrderByOnLoad', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'RecordCount', @value=N'13' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'ThemeFontIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'TotalsRow', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'Updatable', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'795' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'惐䬜龎仭ₐ彝弪ದ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Ma_TC' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Ma_TC' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'TroChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ma_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'2565' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'㗬�ᦵ䲱墸궝彄ୡ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Ten_TC' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'50' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Ten_TC' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'TroChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Ten_TC'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'3285' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'촢耥᳗严ꎝ꽢ꊣ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'109' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Dien_Giai' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'50' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Dien_Giai' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'TroChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'Dien_Giai'
GO
EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowValueListEdits', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'諗뽲☧䵕莬琢᝾緛' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_BoundColumn', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_ColumnCount', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_ColumnHeads', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'111' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMEMode', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_IMESentMode', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_LimitToList', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_ListRows', @value=N'16' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_ListWidth', @value=N'0twip' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_RowSource', @value=N'NhanVien' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_RowSourceType', @value=N'Table/View/StoredProc' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'MsNV' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'ShowOnlyRowSourceValues', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'50' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'MsNV' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'TroChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'UnicodeCompression', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'COLUMN',@level2name=N'MSNV'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackShade', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'AlternateBackTint', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'BackShade', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'BackTint', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'DatasheetForeThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'DatasheetGridlinesThemeColorIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'DateCreated', @value=N'19/05/05 1:36:07 PM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'DisplayViewsOnSharePointSite', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'FilterOnLoad', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'HideNewField', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'LastUpdated', @value=N'27/04/16 10:18:24 AM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DefaultView', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_OrderByOn', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Orientation', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'TroChoi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'OrderByOnLoad', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'RecordCount', @value=N'6' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'ThemeFontIndex', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'TotalsRow', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'Updatable', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_ConstraintText', @value=N'You cannot add, change, or delete this record because of the relationship restriction between the tables ''NhanVien'' and ''TroChoi''.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TroChoi', @level2type=N'CONSTRAINT',@level2name=N'TroChoi_FK00'
GO
USE [master]
GO
ALTER DATABASE [QL_VuiCungHugo] SET  READ_WRITE 
GO
