USE [TrungTamTinHoc]
GO
/****** Object:  UserDefinedFunction [dbo].[fLoaiKhoaHoc]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fLoaiKhoaHoc] (@malkh nvarchar(50))
returns nvarchar(50)
as
begin 
declare @loai nvarchar(50), @makh nvarchar(50);
set @makh = (select Makhoahoc from LOPKHOAHOC where MaLopKhoaHoc=@malkh)

if exists (select * from NHOMCHUYENDE where MaKhoaHocCD = @makh)
	set @loai= N'Chuyên đề';
if exists (select * from DAOTAOCHUNGCHI where MaKhoaHocDTCC = @makh) 
	set @loai= N'Đào tạo chứng chỉ'; 
if exists (select * from KYTHUATVIEN where MaKhoaHocKTV = @makh) 
	set @loai=  N'Kỹ thuật viên'; 
	return @loai;
end
GO
/****** Object:  UserDefinedFunction [dbo].[login]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[login](@username nchar(10), @pass nchar(50))
	returns int 
	begin 
		DECLARE @loaitaikhoan char(10); 
		set @loaitaikhoan = (select LoaiTaiKhoan 
							 from TaiKhoan 
							 where TenTaiKhoan=@username and MatKhau=@pass)
		if @loaitaikhoan like 'hocsinh'
		return 1;
		if @loaitaikhoan like 'giaovien'
		return 2;
		if @loaitaikhoan like 'daotao'
		return 3;	
		return 0;
	end
GO
/****** Object:  UserDefinedFunction [dbo].[sp_KiemTraKhoaHocDaHocChua]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[sp_KiemTraKhoaHocDaHocChua]
(@malopkhoahoc nvarchar(50))
returns int
as
begin
	if exists (select * from LOPKHOAHOC where MaLopKhoaHoc = @malopkhoahoc and NgayKhaiGiang > GETDATE())
		return 1;
	return 0;

end

GO
/****** Object:  Table [dbo].[CHUNGCHIVANBANG]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUNGCHIVANBANG](
	[MaChungChi] [nvarchar](50) NOT NULL,
	[MaLoaiChungChi] [nvarchar](50) NULL,
	[NgayCap] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChungChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHUYENDE]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUYENDE](
	[MaChuyenDe] [nvarchar](50) NOT NULL,
	[TenChuyenDe] [nvarchar](50) NULL,
	[MaKhoaHocCD] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuyenDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DAOTAOCHUNGCHI]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAOTAOCHUNGCHI](
	[MaKhoaHocDTCC] [nvarchar](50) NOT NULL,
	[SoMonHoc] [int] NULL,
	[MaLoaiChungChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoaHocDTCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MaGV] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [nvarchar](50) NOT NULL,
	[NgayLap] [datetime] NULL,
	[TongTien] [float] NULL,
	[MaNhanVienTN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOCVIEN]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCVIEN](
	[MaHocVien] [int] NOT NULL,
	[TenHocVien] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[SDT] [nvarchar](10) NULL,
	[Email] [nvarchar](50) NULL,
	[TenTaiKhoan] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOAHOC]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOAHOC](
	[MaKhoaHoc] [nvarchar](50) NOT NULL,
	[TenKhoaHoc] [nvarchar](50) NULL,
	[HocPhi] [float] NULL,
	[SoTietHoc] [int] NULL,
	[SiSoToiDa] [int] NULL,
	[SiSoToiThieu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoaHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KYTHUATVIEN]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KYTHUATVIEN](
	[MaKhoaHocKTV] [nvarchar](50) NOT NULL,
	[SoMonHoc] [int] NULL,
	[MaLoaiChungChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoaHocKTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LICH_THI_TOT_NGHIEP]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICH_THI_TOT_NGHIEP](
	[MaLichThi] [nvarchar](50) NOT NULL,
	[NgayThi] [datetime] NULL,
	[LanThi] [int] NULL,
	[DiaDiem] [nvarchar](50) NULL,
	[MaLopKhoaHoc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLichThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LICHTHI]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHTHI](
	[MaLichThi] [nvarchar](50) NOT NULL,
	[NgayThi] [date] NULL,
	[CaThi] [int] NULL,
	[MaLop] [nvarchar](50) NULL,
	[DiaDiem] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLichThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAICCVB]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAICCVB](
	[MaLoaiChungChi] [nvarchar](50) NOT NULL,
	[TenLoaiChungChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiChungChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOPKHOAHOC]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPKHOAHOC](
	[MaLopKhoaHoc] [nvarchar](50) NOT NULL,
	[NgayKhaiGiang] [date] NULL,
	[SiSo] [int] NULL,
	[MaKhoaHoc] [nvarchar](50) NULL,
	[MaGV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLopKhoaHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOPMONHOC]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPMONHOC](
	[MaLop] [nvarchar](50) NOT NULL,
	[ThoiGianHoc] [nvarchar](50) NULL,
	[MaGV] [int] NULL,
	[MaMonHoc] [nvarchar](50) NULL,
	[MaLopKhoaHoc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MaMonHoc] [nvarchar](50) NOT NULL,
	[MaHocPhan] [nvarchar](50) NULL,
	[TenMonHoc] [nvarchar](50) NULL,
	[SoTiet] [int] NULL,
	[LoaiMonHoc] [nvarchar](50) NULL,
	[HocPhi] [float] NULL,
	[MaLoaiChungChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [int] NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[SDT] [nvarchar](10) NULL,
	[Email] [nvarchar](50) NULL,
	[TenTaiKhoan] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIENDAOTAO]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIENDAOTAO](
	[MaNhanVienDT] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVienDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIENTHUNGAN]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIENTHUNGAN](
	[MaNhanVienTN] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVienTN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIENTIEPTAN]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIENTIEPTAN](
	[MaNhanVienTT] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVienTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHOMCHUYENDE]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMCHUYENDE](
	[MaKhoaHocCD] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoaHocCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHOMHOCPHAN]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMHOCPHAN](
	[MaHocPhan] [nvarchar](50) NOT NULL,
	[TenHocPhan] [nvarchar](50) NULL,
	[MaKhoaHoc] [nvarchar](50) NULL,
	[MaLoaiChungChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [nchar](10) NOT NULL,
	[MatKhau] [nchar](50) NULL,
	[LoaiTaiKhoan] [nchar](10) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAMGIA_KHOAHOC]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMGIA_KHOAHOC](
	[MaLopKhoaHoc] [nvarchar](50) NOT NULL,
	[MaHoaDon] [nvarchar](50) NULL,
	[MaHocVien] [int] NOT NULL,
	[TinhTrangThamGia] [nvarchar](50) NULL,
	[MaChungChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocVien] ASC,
	[MaLopKhoaHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAMGIALOPHOC]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMGIALOPHOC](
	[MaHocVien] [int] NOT NULL,
	[MaHoaDon] [nvarchar](50) NULL,
	[MaLopMH] [nvarchar](50) NOT NULL,
	[TinhTrangHoc] [nvarchar](50) NULL,
	[MaChungChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocVien] ASC,
	[MaLopMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAMGIATHI]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMGIATHI](
	[MaGV] [int] NULL,
	[MaLichThi] [nvarchar](50) NOT NULL,
	[MaLopMH] [nvarchar](50) NOT NULL,
	[MaHocVien] [int] NOT NULL,
	[Diem] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocVien] ASC,
	[MaLopMH] ASC,
	[MaLichThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAMGIATHI_TOTNGHIEP]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMGIATHI_TOTNGHIEP](
	[MaLichThi] [nvarchar](50) NOT NULL,
	[MaGV] [int] NULL,
	[Diem] [float] NULL,
	[MaHocVien] [int] NOT NULL,
	[MaLopKhoaHoc] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLichThi] ASC,
	[MaLopKhoaHoc] ASC,
	[MaHocVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CHUNGCHIVANBANG] ([MaChungChi], [MaLoaiChungChi], [NgayCap]) VALUES (N'THVP', NULL, NULL)
INSERT [dbo].[CHUYENDE] ([MaChuyenDe], [TenChuyenDe], [MaKhoaHocCD]) VALUES (N'CD_CSDL', N'Chuyên đề Database', N'CD_HQTCSDL')
INSERT [dbo].[CHUYENDE] ([MaChuyenDe], [TenChuyenDe], [MaKhoaHocCD]) VALUES (N'MCD100', N'He quan tri csdl', N'MKH103')
INSERT [dbo].[CHUYENDE] ([MaChuyenDe], [TenChuyenDe], [MaKhoaHocCD]) VALUES (N'MCD102', N'Tri Tue Nhan Tao', N'MKH103')
INSERT [dbo].[CHUYENDE] ([MaChuyenDe], [TenChuyenDe], [MaKhoaHocCD]) VALUES (N'MCD103', N'Index trong Oracle', N'MKH104')
INSERT [dbo].[DAOTAOCHUNGCHI] ([MaKhoaHocDTCC], [SoMonHoc], [MaLoaiChungChi]) VALUES (N'CC_THVP', 3, NULL)
INSERT [dbo].[DAOTAOCHUNGCHI] ([MaKhoaHocDTCC], [SoMonHoc], [MaLoaiChungChi]) VALUES (N'KH1', 2, NULL)
INSERT [dbo].[DAOTAOCHUNGCHI] ([MaKhoaHocDTCC], [SoMonHoc], [MaLoaiChungChi]) VALUES (N'MKH101', 4, NULL)
INSERT [dbo].[DAOTAOCHUNGCHI] ([MaKhoaHocDTCC], [SoMonHoc], [MaLoaiChungChi]) VALUES (N'MKH102', 3, NULL)
INSERT [dbo].[GIAOVIEN] ([MaGV]) VALUES (1)
INSERT [dbo].[GIAOVIEN] ([MaGV]) VALUES (2)
INSERT [dbo].[GIAOVIEN] ([MaGV]) VALUES (123)
INSERT [dbo].[GIAOVIEN] ([MaGV]) VALUES (124)
INSERT [dbo].[GIAOVIEN] ([MaGV]) VALUES (125)
INSERT [dbo].[GIAOVIEN] ([MaGV]) VALUES (126)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVienTN]) VALUES (N'HD1', CAST(N'2021-01-01 00:00:00.000' AS DateTime), 500000, 3)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVienTN]) VALUES (N'HD2', CAST(N'2020-12-12 00:00:00.000' AS DateTime), 600000, 3)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVienTN]) VALUES (N'HD3', CAST(N'2020-12-12 00:00:00.000' AS DateTime), 550000, 3)
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (1, N'Nguyễn Quang Hải', CAST(N'1997-01-01' AS Date), N'Nam', N'0123456789', N'hai@gmail', N'hs1       ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (2, N'Nguyễn Công Phượng', CAST(N'1998-02-02' AS Date), N'Nam', N'0123456788', N'ph@gmail', N'hs2       ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (3, N'Phan Thị Ngọc', CAST(N'1994-04-04' AS Date), N'Nữ', N'0123456700', N'ng@gmail', N'hs3       ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (4, N'Nguyễn An', CAST(N'1999-09-09' AS Date), N'Nam', N'0123456781', N'an@gmail', N'an        ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (5, N'Cao Xuân H?ng Phúc', CAST(N'2000-04-04' AS Date), N'Nam', N'0123456789', N'phuc123', N'phuc      ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (6, N'Võ Nguyễn Hồng Sơn', CAST(N'2005-07-20' AS Date), N'Nam', N'1234567891', N'son@gmail', N'son       ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (7, N'Nguyễn Hoài Nam', CAST(N'2000-07-10' AS Date), N'Nam', N'0123456777', N'nam@gmail', N'nam       ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (8, N'Phan Văn An', CAST(N'2000-07-10' AS Date), N'Nam', N'090123321', N'an@gmail', N'an123     ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (9, N'Peter', CAST(N'2000-07-11' AS Date), N'Nam', N'0901233219', N'peter@gmail', N'peter     ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (10, N'Kevin', CAST(N'2000-07-11' AS Date), N'Nam', N'0901233211', N'kevin', N'kevin     ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (11, N'VNU', CAST(N'1986-07-11' AS Date), N'Nam', N'0903123121', N'vnu@gmail', N'vnu       ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (12, N'Covid', CAST(N'2021-07-11' AS Date), N'Nam', N'012344321', N'covid@gmail', N'covid     ')
INSERT [dbo].[HOCVIEN] ([MaHocVien], [TenHocVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (13, N'Cao Văn Phúc', CAST(N'1976-12-02' AS Date), N'Nam', N'0902391023', N'phuc123', N'caophuc   ')
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'CC_THVP', N'Tin Học Văn Phòng', 2000000, 50, 30, 5)
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'CD_HQTCSDL', N'Chuyên đề Hệ quản trị cơ sở dữ liệu', 1500000, 50, 30, 5)
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'KH1', N'Chứng chỉ tin học B', 1500000, 100, 100, 50)
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'KH2', N'Chứng chỉ tin học A', 1000000, 80, 100, 50)
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'KH3', N'Kỹ thuật viên full stack', 10000000, 1000, 100, 50)
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'KTV_DBA', N'DBA', 3000000, 50, 30, 5)
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'MKH101', N'Dao Tao Chung Chi A', 123000, 9, 40, 15)
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'MKH102', N'Ky Thuat Vien', 3200000, 9, 40, 15)
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'MKH103', N'Chuyen De', 1000000, 2, 1, 1)
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'MKH104', N'Chuyen De', 50000, 2, 40, 1)
INSERT [dbo].[KHOAHOC] ([MaKhoaHoc], [TenKhoaHoc], [HocPhi], [SoTietHoc], [SiSoToiDa], [SiSoToiThieu]) VALUES (N'MKH105', N'Dao Tao Chung Chi B', 93000, 9, 40, 15)
INSERT [dbo].[KYTHUATVIEN] ([MaKhoaHocKTV], [SoMonHoc], [MaLoaiChungChi]) VALUES (N'KH3', NULL, NULL)
INSERT [dbo].[KYTHUATVIEN] ([MaKhoaHocKTV], [SoMonHoc], [MaLoaiChungChi]) VALUES (N'KTV_DBA', 2, NULL)
INSERT [dbo].[LICH_THI_TOT_NGHIEP] ([MaLichThi], [NgayThi], [LanThi], [DiaDiem], [MaLopKhoaHoc]) VALUES (N'LichThi1', CAST(N'2021-01-08 00:00:00.000' AS DateTime), 1, N'KHTN', N'LKH1')
INSERT [dbo].[LICH_THI_TOT_NGHIEP] ([MaLichThi], [NgayThi], [LanThi], [DiaDiem], [MaLopKhoaHoc]) VALUES (N'LT1', CAST(N'2021-01-01 00:00:00.000' AS DateTime), 2, N'LKH2', NULL)
INSERT [dbo].[LICHTHI] ([MaLichThi], [NgayThi], [CaThi], [MaLop], [DiaDiem]) VALUES (N'LichThiThuong1', CAST(N'2021-02-08' AS Date), 2, N'LMH1', N'KHTN')
INSERT [dbo].[LICHTHI] ([MaLichThi], [NgayThi], [CaThi], [MaLop], [DiaDiem]) VALUES (N'LichThiThuong2', CAST(N'2021-02-08' AS Date), 2, N'LMH2', N'KHTN')
INSERT [dbo].[LICHTHI] ([MaLichThi], [NgayThi], [CaThi], [MaLop], [DiaDiem]) VALUES (N'LT1', CAST(N'2021-01-01' AS Date), 1, N'LMH1', NULL)
INSERT [dbo].[LICHTHI] ([MaLichThi], [NgayThi], [CaThi], [MaLop], [DiaDiem]) VALUES (N'LT2', CAST(N'2021-01-01' AS Date), 2, N'LMH2', NULL)
INSERT [dbo].[LICHTHI] ([MaLichThi], [NgayThi], [CaThi], [MaLop], [DiaDiem]) VALUES (N'LT3', CAST(N'2021-01-01' AS Date), 2, N'LMH3', NULL)
INSERT [dbo].[LICHTHI] ([MaLichThi], [NgayThi], [CaThi], [MaLop], [DiaDiem]) VALUES (N'LT4', CAST(N'2021-01-01' AS Date), 2, N'LMH4', NULL)
INSERT [dbo].[LICHTHI] ([MaLichThi], [NgayThi], [CaThi], [MaLop], [DiaDiem]) VALUES (N'LT5', CAST(N'2021-01-01' AS Date), 2, N'LMH5', NULL)
INSERT [dbo].[LICHTHI] ([MaLichThi], [NgayThi], [CaThi], [MaLop], [DiaDiem]) VALUES (N'LT6', CAST(N'2021-01-01' AS Date), 2, N'LMH6', NULL)
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC100', N'Chung Chi Van Bang A')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC101', N'Chung Chi Van Bang B')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC102', N'Hoc Phan web')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC103', N'Hoc Phan logic')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC104', N'Oracle')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC105', N'SQL Server')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC106', N'Chung Chi Hoan Thanh Lop Java Co Ban')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC107', N'Chung Chi Hoan Thanh Lop Java nang cao')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC108', N'Chung Chi Hoan Thanh Lop Javascript nang cao')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC109', N'Chung Chi Hoan Thanh Lop Javascript co ban')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC110', N'Chung Chi Hoan Thanh Lop Nodejs nang cao')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC111', N'Chung Chi Hoan Thanh Lop Typecript co ban')
INSERT [dbo].[LOAICCVB] ([MaLoaiChungChi], [TenLoaiChungChi]) VALUES (N'MLCC112', N'Chung Chi Hoan Thanh Lop JDBC')
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'Access_THVP', CAST(N'2021-02-02' AS Date), 20, N'CC_THVP', 1)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'Database_CD', CAST(N'2021-03-03' AS Date), 25, N'CD_HQTCSDL', 2)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'Database_CD2', CAST(N'2021-03-03' AS Date), 25, N'CD_HQTCSDL', 1)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'Excel_THVP', CAST(N'2021-02-02' AS Date), 20, N'CC_THVP', 2)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'FrontE', CAST(N'2021-07-12' AS Date), 70, N'MKH102', NULL)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'FrontEeasy', CAST(N'2021-07-12' AS Date), 60, N'MKH102', NULL)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'Java999', CAST(N'2021-07-12' AS Date), 99, N'MKH105', NULL)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'LKH1', CAST(N'2021-08-01' AS Date), 60, N'KH1', 1)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'LKH1_1', CAST(N'2021-08-08' AS Date), 60, N'KH1', 1)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'LKH1_2', CAST(N'2021-09-09' AS Date), 60, N'KH1', 1)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'LKH2', CAST(N'2021-01-01' AS Date), 60, N'KH3', 1)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'LKH999', CAST(N'2021-07-12' AS Date), 60, N'MKH101', NULL)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'LopKHOra', CAST(N'2021-07-12' AS Date), 60, N'MKH104', 126)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'Master_DBA', CAST(N'2021-03-03' AS Date), 25, N'KTV_DBA', 1)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'MLKH111', CAST(N'2000-09-04' AS Date), 0, N'MKH103', 123)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'MLKH113', CAST(N'2000-08-04' AS Date), 0, N'MKH101', 124)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'MLKH114', CAST(N'2021-07-13' AS Date), 60, N'MKH104', 123)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'Oracel_DBA', CAST(N'2021-03-03' AS Date), 25, N'KTV_DBA', 2)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'SQLDev', CAST(N'2021-07-12' AS Date), 55, N'MKH103', 2)
INSERT [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc], [NgayKhaiGiang], [SiSo], [MaKhoaHoc], [MaGV]) VALUES (N'Word_THVP', CAST(N'2021-02-02' AS Date), 20, N'CC_THVP', 1)
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'FE997', N'tHỨ 7 ', 2, N'MH102', N'FrontEeasy')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'FE998', N'Thứ 7', 1, N'MH100', N'FrontE')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'FE999', N'Thứ 7', 1, N'MH100', N'FrontE')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'LMH1', N'Thứ 3: 8g-11g ', 1, N'MH1', N'LKH1')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'LMH10', N'Thứ 5: 8g-11g', 1, N'MH8', N'LKH1_2')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'LMH2', N'Thứ 4: 8g-11g ', 1, N'MH2', N'LKH1')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'LMH3', N'Thứ 4: 8g-11g ', 1, N'MH3', N'LKH2')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'LMH4', N'Thứ 4: 8g-11g ', 1, N'MH4', N'LKH2')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'LMH5', N'Thứ 4: 8g-11g ', 1, N'MH5', N'LKH2')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'LMH6', N'Thứ 4: 8g-11g ', 1, N'MH6', N'LKH2')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'LMH7', N'Thứ 2: 8g-11g', 1, N'MH7', N'LKH1_1')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'LMH8', N'Thứ 5: 8g-11g', 1, N'MH8', N'LKH1_1')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'LMH9', N'Thứ 5: 8g-11g', 1, N'MH7', N'LKH1_2')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'ML113', N'Thứ 2, 3: 5 - 6h30', 123, N'MH116', N'SQLDev')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'ML123', N'Thứ 2,3,4: 5h 6h30', 1, N'MH110', N'LKH999')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'ML999', N'Thứ 2,3,4: 5h 6h30', 1, N'MH110', N'LKH999')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'MLJa', N'Thứ 7, Cn 8h 9h30', 2, N'MH112', N'Java999')
INSERT [dbo].[LOPMONHOC] ([MaLop], [ThoiGianHoc], [MaGV], [MaMonHoc], [MaLopKhoaHoc]) VALUES (N'MLJa1', N'Thứ 7, Cn 9h 10h30', 2, N'MH112', N'Java999')
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'EB', N'HP1', N'Excel_Basic_1', 15, N'null', 1000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH1', N'HP1', N'Word', 10, N'Bắt buộc', 200000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH100', N'MHP123', N'Lap trinh Front End', 12, N'Lap Trinh Web', 2000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH101', N'MHP123', N'Lap trinh Back End', 12, N'Lap Trinh Web', 2000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH102', N'MHP124', N'Cau Truc Du Lieu va Giai Thuat', 16, N'Logic Lap Trinh', 2340000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH103', N'MHP124', N'Phuong Phap Tinh', 20, N'Logic trong lap trinh', 6430000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH104', N'MHP124', N'Ly thuyet Do Thi', 15, N'Logic trong lap trinh', 6130000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH105', N'MHP126', N'Nhap Mon Sql Server', 15, N'SQL SERVER', 6130000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH106', N'MHP126', N'Nang Cao Sql Server', 15, N'SQL SERVER', 6130000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH107', N'MHP125', N'Oracle Co Ban', 20, N'Oracle', 6430000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH108', N'MHP125', N'Oracle Nang Cao', 20, N'Oracle', 987700, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH110', N'MHP127', N'Java co ban', 15, N'Chung Chi Van Bang A', 6130000, N'MLCC106')
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH111', N'MHP127', N'Java nang cao', 15, N'Chung Chi Van Bang A', 6130000, N'MLCC107')
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH112', N'MHP128', N'Javascript co ban', 15, N'Chung Chi Van Bang B', 6130000, N'MLCC107')
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH113', N'MHP128', N'Javascript nang cao', 15, N'Chung Chi Van Bang B', 6130000, N'MLCC107')
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH114', N'MHP128', N'Nodejs nang cao', 15, N'Chung Chi Van Bang B', 6130000, N'MLCC107')
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH115', N'MHP127', N'JDBC', 18, N'Chung Chi Van Bang A', 6830000, N'MLCC108')
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH116', N'MHP128', N'typecript', 15, N'Chung Chi Van Bang B', 6130000, N'MLCC111')
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH2', N'HP1', N'Excel', 10, N'Bắt buộc', 200000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH3', N'HP2', N'HTML/CSS', 10, N'Bắt buộc', 200000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH4', N'HP2', N'JavaScript', 10, N'Bắt buộc', 200000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH5', N'HP3', N'ASP.NET', 10, N'Bắt buộc', 200000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH6', N'HP3', N'MySQL', 10, N'Bắt buộc', 200000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH7', N'HP5', N'Basic Web', 10, N'Bắt buộc', 200000, NULL)
INSERT [dbo].[MONHOC] ([MaMonHoc], [MaHocPhan], [TenMonHoc], [SoTiet], [LoaiMonHoc], [HocPhi], [MaLoaiChungChi]) VALUES (N'MH8', N'HP5', N'Basic C#', 10, N'Bắt buộc ', 200000, NULL)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (1, N'Trần Văn A', CAST(N'1987-03-04' AS Date), N'Nam', N'09876543', N'a@gmail', N'giaovien  ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (2, N'Nguyễn Thị B', CAST(N'1988-04-04' AS Date), N'Nữ', N'09023818', N'b@gmail', N'giaovien1 ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (3, N'Bùi Thị C', CAST(N'1988-08-08' AS Date), N'Nữ', N'01231231', N'cc@gmail', N'thungan1  ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (4, N'Cao Phúc', CAST(N'2000-09-09' AS Date), N'Nam', N'01231232', N'phuc@gmail', N'pdt       ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (123, N'Bich Phuong', CAST(N'2000-09-11' AS Date), N'Nữ', N'0397034656', N'BP@gmail.com', N'BP100     ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (124, N'Hoai', CAST(N'2000-09-04' AS Date), N'Nam', N'0397034890', N'HN@gmail.com', N'HN100     ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (125, N'Hong Phuc', CAST(N'2000-09-09' AS Date), N'Nam', N'039700890', N'HP@gmail.com', N'HP100     ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SDT], [Email], [TenTaiKhoan]) VALUES (126, N'Hong Son', CAST(N'2000-08-07' AS Date), N'Nam', N'039700620', N'HP@gmail.com', N'HS100     ')
INSERT [dbo].[NHANVIENTHUNGAN] ([MaNhanVienTN]) VALUES (3)
INSERT [dbo].[NHOMCHUYENDE] ([MaKhoaHocCD]) VALUES (N'CD_HQTCSDL')
INSERT [dbo].[NHOMCHUYENDE] ([MaKhoaHocCD]) VALUES (N'MKH103')
INSERT [dbo].[NHOMCHUYENDE] ([MaKhoaHocCD]) VALUES (N'MKH104')
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'HP1', N'Hoc phần 1', NULL, NULL)
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'HP2', N'front-end', N'KH3', NULL)
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'HP3', N'back-end', N'KH3', NULL)
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'HP4', N'Học phần tin học A', N'KH1', NULL)
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'HP5', N'FULL_Stack', N'KH1', NULL)
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'MHP123', N'Hoc phan Web', N'MKH102', N'MLCC102')
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'MHP124', N'Hoc phan Logic', N'MKH102', N'MLCC103')
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'MHP125', N'Hoc Phan Oracle', N'MKH102', N'MLCC104')
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'MHP126', N'Hoc Phan SQL Server', N'MKH102', N'MLCC105')
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'MHP127', N'Chung Chi Van Bang A', N'MKH101', N'MLCC101')
INSERT [dbo].[NHOMHOCPHAN] ([MaHocPhan], [TenHocPhan], [MaKhoaHoc], [MaLoaiChungChi]) VALUES (N'MHP128', N'Chung Chi Van Bang B', N'MKH105', N'MLCC100')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'an        ', N'an                                                ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'an123     ', N'an123                                             ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'BP100     ', N'123456                                            ', NULL)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'caophuc   ', N'caophuc                                           ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'covid     ', N'covid                                             ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'giaovien  ', N'giaovien                                          ', N'giaovien  ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'giaovien1 ', N'giaovien1                                         ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'HN100     ', N'123456                                            ', NULL)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'HP100     ', N'123456                                            ', NULL)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'hs1       ', N'hs1                                               ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'HS100     ', N'123456                                            ', NULL)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'hs2       ', N'hs2                                               ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'hs3       ', N'hs3                                               ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'kevin     ', N'kevin                                             ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'nam       ', N'nam                                               ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'pdt       ', N'pdt                                               ', N'daotao    ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'peter     ', N'peter                                             ', NULL)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'phuc      ', N'phuc                                              ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'son       ', N'son                                               ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'thungan1  ', N'thungan1                                          ', N'hocsinh   ')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'vnu       ', N'vnu                                               ', N'hocsinh   ')
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'Access_THVP', N'HD3', 1, N'Đang tham gia', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'Excel_THVP', N'HD2', 1, N'Đang tham gia', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1', NULL, 1, N'Đậu', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH2', NULL, 1, N'Đã tốt nghiệp', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'Word_THVP', N'HD1', 1, N'Đang tham gia', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1', NULL, 2, NULL, NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1', NULL, 3, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1', NULL, 4, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1', NULL, 5, NULL, NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1', NULL, 6, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1_1', NULL, 6, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1_2', NULL, 6, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH2', NULL, 7, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1', NULL, 8, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH2', NULL, 8, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1', NULL, 9, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1', NULL, 10, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'Access_THVP', NULL, 11, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1_1', NULL, 12, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'Master_DBA', NULL, 12, N'Đang học', NULL)
INSERT [dbo].[THAMGIA_KHOAHOC] ([MaLopKhoaHoc], [MaHoaDon], [MaHocVien], [TinhTrangThamGia], [MaChungChi]) VALUES (N'LKH1', NULL, 13, N'Đang học', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (1, NULL, N'LMH1', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (1, NULL, N'LMH2', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (1, NULL, N'LMH3', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (1, NULL, N'LMH4', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (1, NULL, N'LMH5', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (1, NULL, N'LMH6', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (3, NULL, N'LMH1', NULL, NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (3, NULL, N'LMH2', NULL, NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (3, NULL, N'LMH3', NULL, NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (3, NULL, N'LMH4', NULL, NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (3, NULL, N'LMH5', NULL, NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (3, NULL, N'LMH6', NULL, NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (4, NULL, N'LMH1', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (4, NULL, N'LMH2', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (5, NULL, N'LMH1', NULL, NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (5, NULL, N'LMH2', NULL, NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (6, NULL, N'LMH10', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (6, NULL, N'LMH7', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (6, NULL, N'LMH8', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (6, NULL, N'LMH9', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (7, NULL, N'LMH3', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (7, NULL, N'LMH4', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (7, NULL, N'LMH5', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (7, NULL, N'LMH6', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (8, NULL, N'LMH1', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (8, NULL, N'LMH2', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (8, NULL, N'LMH3', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (8, NULL, N'LMH4', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (8, NULL, N'LMH5', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (8, NULL, N'LMH6', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (9, NULL, N'LMH1', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (9, NULL, N'LMH2', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (10, NULL, N'LMH1', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (10, NULL, N'LMH2', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (12, NULL, N'LMH7', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (12, NULL, N'LMH8', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (13, NULL, N'LMH1', N'Chính thức', NULL)
INSERT [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaHoaDon], [MaLopMH], [TinhTrangHoc], [MaChungChi]) VALUES (13, NULL, N'LMH2', N'Chính thức', NULL)
INSERT [dbo].[THAMGIATHI] ([MaGV], [MaLichThi], [MaLopMH], [MaHocVien], [Diem]) VALUES (1, N'LichThiThuong1', N'LMH1', 1, 1)
INSERT [dbo].[THAMGIATHI] ([MaGV], [MaLichThi], [MaLopMH], [MaHocVien], [Diem]) VALUES (NULL, N'LT1', N'LMH1', 1, 9)
INSERT [dbo].[THAMGIATHI] ([MaGV], [MaLichThi], [MaLopMH], [MaHocVien], [Diem]) VALUES (NULL, N'LT2', N'LMH2', 1, 8)
INSERT [dbo].[THAMGIATHI] ([MaGV], [MaLichThi], [MaLopMH], [MaHocVien], [Diem]) VALUES (NULL, N'LT3', N'LMH3', 1, 6)
INSERT [dbo].[THAMGIATHI] ([MaGV], [MaLichThi], [MaLopMH], [MaHocVien], [Diem]) VALUES (NULL, N'LT4', N'LMH4', 1, 7)
INSERT [dbo].[THAMGIATHI] ([MaGV], [MaLichThi], [MaLopMH], [MaHocVien], [Diem]) VALUES (NULL, N'LT5', N'LMH5', 1, 8)
INSERT [dbo].[THAMGIATHI] ([MaGV], [MaLichThi], [MaLopMH], [MaHocVien], [Diem]) VALUES (NULL, N'LT6', N'LMH6', 1, 9)
INSERT [dbo].[THAMGIATHI] ([MaGV], [MaLichThi], [MaLopMH], [MaHocVien], [Diem]) VALUES (1, N'LichThiThuong1', N'LMH1', 3, 1)
INSERT [dbo].[THAMGIATHI] ([MaGV], [MaLichThi], [MaLopMH], [MaHocVien], [Diem]) VALUES (1, N'LichThiThuong2', N'LMH2', 4, NULL)
INSERT [dbo].[THAMGIATHI_TOTNGHIEP] ([MaLichThi], [MaGV], [Diem], [MaHocVien], [MaLopKhoaHoc]) VALUES (N'LichThi1', 1, 8, 1, N'LKH1')
INSERT [dbo].[THAMGIATHI_TOTNGHIEP] ([MaLichThi], [MaGV], [Diem], [MaHocVien], [MaLopKhoaHoc]) VALUES (N'LichThi1', 1, 9, 2, N'LKH1')
INSERT [dbo].[THAMGIATHI_TOTNGHIEP] ([MaLichThi], [MaGV], [Diem], [MaHocVien], [MaLopKhoaHoc]) VALUES (N'LichThi1', 1, 7, 3, N'LKH1')
INSERT [dbo].[THAMGIATHI_TOTNGHIEP] ([MaLichThi], [MaGV], [Diem], [MaHocVien], [MaLopKhoaHoc]) VALUES (N'LichThi1', 1, 5, 4, N'LKH1')
INSERT [dbo].[THAMGIATHI_TOTNGHIEP] ([MaLichThi], [MaGV], [Diem], [MaHocVien], [MaLopKhoaHoc]) VALUES (N'LichThi1', 1, 4, 6, N'LKH1')
INSERT [dbo].[THAMGIATHI_TOTNGHIEP] ([MaLichThi], [MaGV], [Diem], [MaHocVien], [MaLopKhoaHoc]) VALUES (N'LT1', NULL, 9, 1, N'LKH2')
ALTER TABLE [dbo].[CHUNGCHIVANBANG]  WITH CHECK ADD  CONSTRAINT [FK_CCVB_LOAICCVB] FOREIGN KEY([MaLoaiChungChi])
REFERENCES [dbo].[LOAICCVB] ([MaLoaiChungChi])
GO
ALTER TABLE [dbo].[CHUNGCHIVANBANG] CHECK CONSTRAINT [FK_CCVB_LOAICCVB]
GO
ALTER TABLE [dbo].[CHUYENDE]  WITH CHECK ADD  CONSTRAINT [FK_CD_MaKHCD_MaKHCD_NHOMCHUYENDE] FOREIGN KEY([MaKhoaHocCD])
REFERENCES [dbo].[NHOMCHUYENDE] ([MaKhoaHocCD])
GO
ALTER TABLE [dbo].[CHUYENDE] CHECK CONSTRAINT [FK_CD_MaKHCD_MaKHCD_NHOMCHUYENDE]
GO
ALTER TABLE [dbo].[DAOTAOCHUNGCHI]  WITH CHECK ADD FOREIGN KEY([MaKhoaHocDTCC])
REFERENCES [dbo].[KHOAHOC] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[DAOTAOCHUNGCHI]  WITH CHECK ADD FOREIGN KEY([MaLoaiChungChi])
REFERENCES [dbo].[LOAICCVB] ([MaLoaiChungChi])
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HD_NVTN] FOREIGN KEY([MaNhanVienTN])
REFERENCES [dbo].[NHANVIENTHUNGAN] ([MaNhanVienTN])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HD_NVTN]
GO
ALTER TABLE [dbo].[HOCVIEN]  WITH CHECK ADD  CONSTRAINT [FK_HocVien_TaiKhoan] FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([TenTaiKhoan])
GO
ALTER TABLE [dbo].[HOCVIEN] CHECK CONSTRAINT [FK_HocVien_TaiKhoan]
GO
ALTER TABLE [dbo].[KYTHUATVIEN]  WITH CHECK ADD FOREIGN KEY([MaKhoaHocKTV])
REFERENCES [dbo].[KHOAHOC] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[KYTHUATVIEN]  WITH CHECK ADD FOREIGN KEY([MaLoaiChungChi])
REFERENCES [dbo].[LOAICCVB] ([MaLoaiChungChi])
GO
ALTER TABLE [dbo].[LICH_THI_TOT_NGHIEP]  WITH CHECK ADD  CONSTRAINT [FK_LTTN_LOPKHOAHOC] FOREIGN KEY([MaLopKhoaHoc])
REFERENCES [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc])
GO
ALTER TABLE [dbo].[LICH_THI_TOT_NGHIEP] CHECK CONSTRAINT [FK_LTTN_LOPKHOAHOC]
GO
ALTER TABLE [dbo].[LICHTHI]  WITH CHECK ADD  CONSTRAINT [FK_LichThi_LOPMONHOC] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOPMONHOC] ([MaLop])
GO
ALTER TABLE [dbo].[LICHTHI] CHECK CONSTRAINT [FK_LichThi_LOPMONHOC]
GO
ALTER TABLE [dbo].[LOPKHOAHOC]  WITH CHECK ADD  CONSTRAINT [FK_LOPKH_KHOAHOC] FOREIGN KEY([MaKhoaHoc])
REFERENCES [dbo].[KHOAHOC] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[LOPKHOAHOC] CHECK CONSTRAINT [FK_LOPKH_KHOAHOC]
GO
ALTER TABLE [dbo].[LOPKHOAHOC]  WITH CHECK ADD  CONSTRAINT [FK_LOPKH_MGV_MGV_GIAOVIEN] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[LOPKHOAHOC] CHECK CONSTRAINT [FK_LOPKH_MGV_MGV_GIAOVIEN]
GO
ALTER TABLE [dbo].[LOPMONHOC]  WITH CHECK ADD  CONSTRAINT [FK_LOPMH_LOPKHOAHOC] FOREIGN KEY([MaLopKhoaHoc])
REFERENCES [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc])
GO
ALTER TABLE [dbo].[LOPMONHOC] CHECK CONSTRAINT [FK_LOPMH_LOPKHOAHOC]
GO
ALTER TABLE [dbo].[LOPMONHOC]  WITH CHECK ADD  CONSTRAINT [FK_LOPMH_MONHOC] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MONHOC] ([MaMonHoc])
GO
ALTER TABLE [dbo].[LOPMONHOC] CHECK CONSTRAINT [FK_LOPMH_MONHOC]
GO
ALTER TABLE [dbo].[LOPMONHOC]  WITH CHECK ADD  CONSTRAINT [FK_LOPMONHOC_GV] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[LOPMONHOC] CHECK CONSTRAINT [FK_LOPMONHOC_GV]
GO
ALTER TABLE [dbo].[MONHOC]  WITH CHECK ADD  CONSTRAINT [FK_MONHOC_LOAICCVB] FOREIGN KEY([MaLoaiChungChi])
REFERENCES [dbo].[LOAICCVB] ([MaLoaiChungChi])
GO
ALTER TABLE [dbo].[MONHOC] CHECK CONSTRAINT [FK_MONHOC_LOAICCVB]
GO
ALTER TABLE [dbo].[MONHOC]  WITH CHECK ADD  CONSTRAINT [FK_MONHOC_NHOMHOCPHAN] FOREIGN KEY([MaHocPhan])
REFERENCES [dbo].[NHOMHOCPHAN] ([MaHocPhan])
GO
ALTER TABLE [dbo].[MONHOC] CHECK CONSTRAINT [FK_MONHOC_NHOMHOCPHAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([TenTaiKhoan])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[NHANVIENDAOTAO]  WITH CHECK ADD FOREIGN KEY([MaNhanVienDT])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NHANVIENTHUNGAN]  WITH CHECK ADD FOREIGN KEY([MaNhanVienTN])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NHANVIENTIEPTAN]  WITH CHECK ADD FOREIGN KEY([MaNhanVienTT])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NHOMCHUYENDE]  WITH CHECK ADD  CONSTRAINT [FK_NhomCD_MaKhoaHocCD_MaKhoaHoc_KHOAHOC] FOREIGN KEY([MaKhoaHocCD])
REFERENCES [dbo].[KHOAHOC] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[NHOMCHUYENDE] CHECK CONSTRAINT [FK_NhomCD_MaKhoaHocCD_MaKhoaHoc_KHOAHOC]
GO
ALTER TABLE [dbo].[NHOMHOCPHAN]  WITH CHECK ADD FOREIGN KEY([MaLoaiChungChi])
REFERENCES [dbo].[LOAICCVB] ([MaLoaiChungChi])
GO
ALTER TABLE [dbo].[NHOMHOCPHAN]  WITH CHECK ADD  CONSTRAINT [FK_NHOMHOCPHAN_KhoaHOc] FOREIGN KEY([MaKhoaHoc])
REFERENCES [dbo].[KHOAHOC] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[NHOMHOCPHAN] CHECK CONSTRAINT [FK_NHOMHOCPHAN_KhoaHOc]
GO
ALTER TABLE [dbo].[THAMGIA_KHOAHOC]  WITH CHECK ADD  CONSTRAINT [FK_TGKH_ChungChi] FOREIGN KEY([MaChungChi])
REFERENCES [dbo].[CHUNGCHIVANBANG] ([MaChungChi])
GO
ALTER TABLE [dbo].[THAMGIA_KHOAHOC] CHECK CONSTRAINT [FK_TGKH_ChungChi]
GO
ALTER TABLE [dbo].[THAMGIA_KHOAHOC]  WITH CHECK ADD  CONSTRAINT [FK_TGKH_MaHoaDon_MaHoaDon_HOADON] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[THAMGIA_KHOAHOC] CHECK CONSTRAINT [FK_TGKH_MaHoaDon_MaHoaDon_HOADON]
GO
ALTER TABLE [dbo].[THAMGIA_KHOAHOC]  WITH CHECK ADD  CONSTRAINT [FK_TGKH_MaHV_MaHV_HOCVIEN] FOREIGN KEY([MaHocVien])
REFERENCES [dbo].[HOCVIEN] ([MaHocVien])
GO
ALTER TABLE [dbo].[THAMGIA_KHOAHOC] CHECK CONSTRAINT [FK_TGKH_MaHV_MaHV_HOCVIEN]
GO
ALTER TABLE [dbo].[THAMGIA_KHOAHOC]  WITH CHECK ADD  CONSTRAINT [FK_TGKH_MaLKH_MaLOPKHOAHOC_LOPKHOAHOC] FOREIGN KEY([MaLopKhoaHoc])
REFERENCES [dbo].[LOPKHOAHOC] ([MaLopKhoaHoc])
GO
ALTER TABLE [dbo].[THAMGIA_KHOAHOC] CHECK CONSTRAINT [FK_TGKH_MaLKH_MaLOPKHOAHOC_LOPKHOAHOC]
GO
ALTER TABLE [dbo].[THAMGIALOPHOC]  WITH CHECK ADD  CONSTRAINT [FK_TGLH_CCVB] FOREIGN KEY([MaChungChi])
REFERENCES [dbo].[CHUNGCHIVANBANG] ([MaChungChi])
GO
ALTER TABLE [dbo].[THAMGIALOPHOC] CHECK CONSTRAINT [FK_TGLH_CCVB]
GO
ALTER TABLE [dbo].[THAMGIALOPHOC]  WITH CHECK ADD  CONSTRAINT [FK_TGLH_HOADON] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[THAMGIALOPHOC] CHECK CONSTRAINT [FK_TGLH_HOADON]
GO
ALTER TABLE [dbo].[THAMGIALOPHOC]  WITH CHECK ADD  CONSTRAINT [FK_TGLH_HV] FOREIGN KEY([MaHocVien])
REFERENCES [dbo].[HOCVIEN] ([MaHocVien])
GO
ALTER TABLE [dbo].[THAMGIALOPHOC] CHECK CONSTRAINT [FK_TGLH_HV]
GO
ALTER TABLE [dbo].[THAMGIALOPHOC]  WITH CHECK ADD  CONSTRAINT [FK_TGLH_LOPHOC] FOREIGN KEY([MaLopMH])
REFERENCES [dbo].[LOPMONHOC] ([MaLop])
GO
ALTER TABLE [dbo].[THAMGIALOPHOC] CHECK CONSTRAINT [FK_TGLH_LOPHOC]
GO
ALTER TABLE [dbo].[THAMGIATHI]  WITH CHECK ADD  CONSTRAINT [FK_TGTHI_GIAOVIEN] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[THAMGIATHI] CHECK CONSTRAINT [FK_TGTHI_GIAOVIEN]
GO
ALTER TABLE [dbo].[THAMGIATHI]  WITH CHECK ADD  CONSTRAINT [FK_TGTHI_LICHTHI] FOREIGN KEY([MaLichThi])
REFERENCES [dbo].[LICHTHI] ([MaLichThi])
GO
ALTER TABLE [dbo].[THAMGIATHI] CHECK CONSTRAINT [FK_TGTHI_LICHTHI]
GO
ALTER TABLE [dbo].[THAMGIATHI]  WITH CHECK ADD  CONSTRAINT [FK_TGTHI_TGLOPHOC] FOREIGN KEY([MaHocVien], [MaLopMH])
REFERENCES [dbo].[THAMGIALOPHOC] ([MaHocVien], [MaLopMH])
GO
ALTER TABLE [dbo].[THAMGIATHI] CHECK CONSTRAINT [FK_TGTHI_TGLOPHOC]
GO
ALTER TABLE [dbo].[THAMGIATHI_TOTNGHIEP]  WITH CHECK ADD  CONSTRAINT [FK_TGTTN_MaGV_MaGV_GIAOVIEN] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[THAMGIATHI_TOTNGHIEP] CHECK CONSTRAINT [FK_TGTTN_MaGV_MaGV_GIAOVIEN]
GO
ALTER TABLE [dbo].[THAMGIATHI_TOTNGHIEP]  WITH CHECK ADD  CONSTRAINT [FK_TGTTN_MaHV_MaLopKH_MaHV_HOCVIEN] FOREIGN KEY([MaHocVien], [MaLopKhoaHoc])
REFERENCES [dbo].[THAMGIA_KHOAHOC] ([MaHocVien], [MaLopKhoaHoc])
GO
ALTER TABLE [dbo].[THAMGIATHI_TOTNGHIEP] CHECK CONSTRAINT [FK_TGTTN_MaHV_MaLopKH_MaHV_HOCVIEN]
GO
ALTER TABLE [dbo].[THAMGIATHI_TOTNGHIEP]  WITH CHECK ADD  CONSTRAINT [FK_TGTTN_MaLT_MaLT_LICHTHITN] FOREIGN KEY([MaLichThi])
REFERENCES [dbo].[LICH_THI_TOT_NGHIEP] ([MaLichThi])
GO
ALTER TABLE [dbo].[THAMGIATHI_TOTNGHIEP] CHECK CONSTRAINT [FK_TGTTN_MaLT_MaLT_LICHTHITN]
GO
/****** Object:  StoredProcedure [dbo].[sp_ChamDiemMonHoc]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_ChamDiemMonHoc] @MaLichThi nvarchar(50),@MaHocVien int,@Diem float
as 
begin 
update THAMGIATHI set Diem = @Diem 
where MaLichThi = @MaLichThi and MaHocVien =@MaHocVien;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_ChamDiemTotNghiep]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_ChamDiemTotNghiep] @MaLichThi nvarchar(50),@MaHocVien int,@Diem float
as 
begin 
update THAMGIATHI_TOTNGHIEP set Diem = @Diem 
where MaLichThi = @MaLichThi and MaHocVien =@MaHocVien;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Get_MonHoc_HocPhan]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Get_MonHoc_HocPhan] @TenHocPhan nvarchar(50)
as 
begin
select *from NHOMHOCPHAN as MHP,MONHOC as MH where MHP.MaHocPhan=MH.MaHocPhan and TenHocPhan=@TenHocPhan
end

GO
/****** Object:  StoredProcedure [dbo].[sp_GetDSLopKhoaHoc]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_GetDSLopKhoaHoc] @MaLopKhoaHoc nvarchar(50)
as 
begin 
select lttn.MaLichThi,hv.MaHocVien,hv.TenHocVien, 'ThiLai' = CASE when tgttn.MaLopKhoaHoc = lkh.MaLopKhoaHoc then 0 else 1 END,tgttn.Diem
from LOPKHOAHOC lkh join LICH_THI_TOT_NGHIEP lttn on lkh.MaLopKhoaHoc = lttn.MaLopKhoaHoc
join THAMGIATHI_TOTNGHIEP tgttn on tgttn.MaLichThi = lttn.MaLichThi 
join HOCVIEN hv on hv.MaHocVien = tgttn.MaHocVien
where lkh.MaLopKhoaHoc= @MaLopKhoaHoc;
end;

GO
/****** Object:  StoredProcedure [dbo].[sp_GetDSLopMonHoc]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_GetDSLopMonHoc] @MaLopMonHoc nvarchar(50)
as 
begin 
select tgt.MaLichThi,tgt.MaHocVien,hv.TenHocVien,'ThiLai' = CASE when tgt.MaLopMH = lmh.MaLop  then 0 else 1 END ,tgt.Diem
from LOPMONHOC lmh join LICHTHI lt on  lmh.MaLop=lt.MaLop 
join THAMGIATHI tgt on tgt.MaLichThi = lt.MaLichThi 
join HOCVIEN hv on hv.MaHocVien = tgt.MaHocVien 
where lmh.MaLop= @MaLopMonHoc
end;

GO
/****** Object:  StoredProcedure [dbo].[sp_GetKhoaHocChoNewbie]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetKhoaHocChoNewbie]
as
select MaLopKhoaHoc, TenKhoaHoc, NgayKhaiGiang, HocPhi, SoTietHoc from LOPKHOAHOC, KHOAHOC where LOPKHOAHOC.MaKhoaHoc = KHOAHOC.MaKhoaHoc

GO
/****** Object:  StoredProcedure [dbo].[sp_GetKhoaHocChoUsed]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetKhoaHocChoUsed]
@tentaikhoan nchar(10)
as
select LOPKHOAHOC.MaLopKhoaHoc, TenKhoaHoc, NgayKhaiGiang, HocPhi, SoTietHoc from LOPKHOAHOC, KHOAHOC, THAMGIA_KHOAHOC, HOCVIEN
where LOPKHOAHOC.MaKhoaHoc = KHOAHOC.MaKhoaHoc and THAMGIA_KHOAHOC.MaLopKhoaHoc = LOPKHOAHOC.MaLopKhoaHoc and THAMGIA_KHOAHOC.MaHocVien = HOCVIEN.MaHocVien
and HOCVIEN.TenTaiKhoan = @tentaikhoan
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLopHocChoNewbie]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetLopHocChoNewbie]
@MaLopKhoaHoc nvarchar(50)
as
select MaLop,TenMonHoc,ThoiGianHoc, SoTiet from LOPMONHOC, LOPKHOAHOC, MONHOC where LOPKHOAHOC.MaLopKhoaHoc = LOPMONHOC.MaLopKhoaHoc and MONHOC.MaMonHoc = LOPMONHOC.MaMonHoc and LOPMONHOC.MaLopKhoaHoc = @MaLopKhoaHoc


GO
/****** Object:  StoredProcedure [dbo].[sp_GetLopHocChoUsed]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetLopHocChoUsed]
@MaLopKhoaHoc nvarchar(50),
@TenTaiKhoan nchar(10)
as
select MaLop,TenMonHoc,ThoiGianHoc, SoTiet from LOPMONHOC, LOPKHOAHOC, MONHOC, THAMGIALOPHOC, HOCVIEN 
where LOPKHOAHOC.MaLopKhoaHoc = LOPMONHOC.MaLopKhoaHoc and MONHOC.MaMonHoc = LOPMONHOC.MaMonHoc and LOPMONHOC.MaLopKhoaHoc = @MaLopKhoaHoc 
and THAMGIALOPHOC.MaLopMH = LOPMONHOC.MaLop and THAMGIALOPHOC.MaHocVien = HOCVIEN.MaHocVien
and HOCVIEN.TenTaiKhoan = @TenTaiKhoan
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLopKhoaHoc]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_GetLopKhoaHoc] @MaGV int
as 
begin 
select MaLopKhoaHoc MaLop,NgayKhaiGiang,SiSo,MaKhoaHoc  from LOPKHOAHOC where MaGV=@MaGV;
end;

GO
/****** Object:  StoredProcedure [dbo].[sp_GetLopMonHoc]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_GetLopMonHoc] @MaGV int
as 
begin 
select MaLop,ThoiGianHoc,MaMonHoc,MaLopKhoaHoc from LOPMONHOC where MaGV=@MaGV;
end;

GO
/****** Object:  StoredProcedure [dbo].[sp_GetTenChuyenDe]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetTenChuyenDe] @MaKhoaHoc nvarchar(50)
as
begin 
 select CD.TenChuyenDe  from  KHOAHOC as kh,NHOMCHUYENDE as ncd,CHUYENDE as CD where kh.MaKhoaHoc=@MaKhoaHoc and kh.MaKhoaHoc=ncd.MaKhoaHocCD and ncd.MaKhoaHocCD=CD.MaKhoaHocCD;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_Insert_KyThuatVien]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Insert_KyThuatVien] @MaLopKhoaHoc nvarchar(50), @MaKhoaHoc nvarchar(50),@NgayKG date,@SiSo int,
@MaMonHoc nvarchar(50),@MaLop nvarchar(50),@ThoiGianHoc nvarchar(50),@MaGV int
as
 begin
 if not exists(select*from LOPKHOAHOC where MaLopKhoaHoc=@MaLopKhoaHoc)
 begin
  insert into LOPKHOAHOC(MaLopKhoaHoc,NgayKhaiGiang,SiSo,MaKhoaHoc) values(@MaLopKhoaHoc,@NgayKG,@SiSo,@MaKhoaHoc)
  insert into LOPMONHOC(MaLop,ThoiGianHoc,MaLopKhoaHoc,MaGV,MaMonHoc) values(@MaLop,@ThoiGianHoc,@MaLopKhoaHoc,@MaGV,@MaMonHoc);
  end;
else
begin

insert into LOPMONHOC(MaLop,ThoiGianHoc,MaLopKhoaHoc,MaGV,MaMonHoc) values(@MaLop,@ThoiGianHoc,@MaLopKhoaHoc,@MaGV,@MaMonHoc);
  end
 end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Insert_LopChuyenDe]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Insert_LopChuyenDe] @MaLopKhoaHoc nvarchar(50), @NgayKG date,@SiSo int,@MaGV int,@MaKhoaHoc nvarchar(50)
as
begin 
insert into LOPKHOAHOC(MaLopKhoaHoc,NgayKhaiGiang,SiSo,MaGV,MaKhoaHoc) values(@MaLopKhoaHoc,@NgayKG,@SiSo,@MaGV,@MaKhoaHoc);
end

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertHocVien]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertHocVien]
@TenHV nvarchar(50),
@NgaySinh date,
@GioiTinh nvarchar(3),
@SDT nvarchar(10),
@Email nvarchar(50),
@TenTaiKhoan nchar(10),
@MatKhau nchar(50)
as
insert into TaiKhoan(TenTaiKhoan,MatKhau) values (@TenTaiKhoan,@MatKhau)
declare @MaHV int
set @MaHV = (select max(MaHocVien) + 1 from HocVien) 
insert into HocVien(MaHocVien,TenHocVien,NgaySinh,GioiTinh,SDT,Email,TenTaiKhoan)
values(@MaHV,@TenHV,@NgaySinh,@GioiTinh,@SDT,@Email,@TenTaiKhoan)

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertHocVien_Logined]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertHocVien_Logined] 
@TenTaiKhoan nchar(10),
@MaLopKhoaHoc nvarchar(50)
as
begin
DECLARE @MaHV int 
set @MaHV = (select HOCVIEN.MaHocVien from HOCVIEN where HOCVIEN.TenTaiKhoan = @TenTaiKhoan)

	declare @makh nvarchar(50);
	set @makh= (select MaKhoaHoc from LOPKHOAHOC where MaLopKhoaHoc=@MaLopKhoaHoc);

	if exists (select * from NHOMCHUYENDE where MaKhoaHocCD = @makh)
		begin 
			insert into THAMGIA_KHOAHOC values(@MaLopKhoaHoc,NULL,@MaHV,null,NULL)
		end
	else 
		begin
			insert into THAMGIA_KHOAHOC values(@MaLopKhoaHoc,NULL,@MaHV,N'Đang học',NULL)
			INSERT INTO THAMGIALOPHOC SELECT @MaHV,null,MaLop,N'Chính thức', null
	FROM LopMonHoc where MaLopKhoaHoc = @MaLopKhoaHoc
		end	
end

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertHocVien_Newbie]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertHocVien_Newbie]
@TenHV nvarchar(50),
@NgaySinh date,
@GioiTinh nvarchar(3),
@SDT nvarchar(10),
@Email nvarchar(50),
@TenTaiKhoan nchar(10),
@MatKhau nchar(50),
@MaLopKhoaHoc nvarchar(50)
as
begin 
insert into TaiKhoan(TenTaiKhoan,MatKhau,LoaiTaiKhoan) values (@TenTaiKhoan,@MatKhau,'hocsinh')
declare @MaHV int
set @MaHV = (select max(MaHocVien) + 1 from HocVien) 

insert into HocVien(MaHocVien,TenHocVien,NgaySinh,GioiTinh,SDT,Email,TenTaiKhoan)
values(@MaHV,@TenHV,@NgaySinh,@GioiTinh,@SDT,@Email,@TenTaiKhoan)

declare @makh nvarchar(50);
set @makh= (select MaKhoaHoc from LOPKHOAHOC where MaLopKhoaHoc=@MaLopKhoaHoc);

if exists (select * from NHOMCHUYENDE where MaKhoaHocCD = @makh)
	begin 
		insert into THAMGIA_KHOAHOC values(@MaLopKhoaHoc,NULL,@MaHV,NULL,NULL)
	end
else 
	begin
		insert into THAMGIA_KHOAHOC values(@MaLopKhoaHoc,NULL,@MaHV,N'Đang học',NULL)
		INSERT INTO THAMGIALOPHOC SELECT @MaHV,null,MaLop,N'Chính thức', null
FROM LopMonHoc where MaLopKhoaHoc = @MaLopKhoaHoc
	end
end

GO
/****** Object:  StoredProcedure [dbo].[sp_TenHocPhan_KTV]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TenHocPhan_KTV] @MaKhoaHoc nvarchar(50)
as 
begin
select *from NHOMHOCPHAN where MaKhoaHoc=@MaKhoaHoc;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_View_KhoaHoc]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_View_KhoaHoc]
as
begin
select* from KHOAHOC as KH,NHOMCHUYENDE as NCD,CHUYENDE as CD where MaKhoaHoc=NCD.MaKhoaHocCD and NCD.MaKhoaHocCD=CD.MaKhoaHocCD;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_View_LopKhoaHoc]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_View_LopKhoaHoc]
as 
begin 
select* from LOPKHOAHOC as lkh, KHOAHOC kh where kh.MaKhoaHoc=lkh.MaKhoaHoc
end
GO
/****** Object:  StoredProcedure [dbo].[sp_View_LopKhoaHocCD]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_View_LopKhoaHocCD]
as
 begin
 select MaLopKhoaHoc,NgayKhaiGiang,SiSo,MaGV,HocPhi,SoTietHoc,SiSoToiThieu,SiSoToiDa from LOPKHOAHOC as lkh,KHOAHOC as kh,NHOMCHUYENDE as ncd where lkh.MaKhoaHoc=kh.MaKhoaHoc and kh.MaKhoaHoc=ncd.MaKhoaHocCD;
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_View_LopMonHocDTCD]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_View_LopMonHocDTCD] @MaKhoaHoc nvarchar(50)
as 
begin 
select* from LOPMONHOC as lmh,LOPKHOAHOC  as lkh where lmh.MaLopKhoaHoc=lkh.MaLopKhoaHoc and lkh.MaKhoaHoc=@MaKhoaHoc;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_View_LopMonHocKTV]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_View_LopMonHocKTV]
as 
begin 
select* from LOPMONHOC as lmh,LOPKHOAHOC  as lkh where lmh.MaLopKhoaHoc=lkh.MaLopKhoaHoc and lkh.MaKhoaHoc='MKH102'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ViewAll_GiaoVien]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ViewAll_GiaoVien]
as
begin
select MaGV,TenNhanVien,NgaySinh,GioiTinh,SDT,Email from GIAOVIEN as gv ,NHANVIEN as nv where gv.MaGV=nv.MaNhanVien
end;
select* from GIAOVIEN
GO
/****** Object:  StoredProcedure [dbo].[sp_XacNhanChuyenKhoa]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XacNhanChuyenKhoa]
@malopkhoahoc_Cu nvarchar(50),
@malopkhoahoc_Moi nvarchar(50),
@tentaikhoan nchar(10)
as
begin
declare @mahv int
set @mahv = (select HOCVIEN.MaHocVien from HOCVIEN where HOCVIEN.TenTaiKhoan = @tentaikhoan)

delete from THAMGIA_KHOAHOC where THAMGIA_KHOAHOC.MaHocVien = @mahv and THAMGIA_KHOAHOC.MaLopKhoaHoc = @malopkhoahoc_Cu 
delete from THAMGIALOPHOC where THAMGIALOPHOC.MaHocVien = @mahv 
and THAMGIALOPHOC.MaLopMH in (select MaLop from LOPMONHOC where LOPMONHOC.MaLopKhoaHoc = @malopkhoahoc_Cu)

exec sp_InsertHocVien_Logined @tentaikhoan,@malopkhoahoc_Moi

end
GO
/****** Object:  StoredProcedure [dbo].[sp_XemKhoaHocCungLoai]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_XemKhoaHocCungLoai]
@malopkhoahoc nvarchar(50)
as
begin

	select MaLopKhoaHoc, TenKhoaHoc, NgayKhaiGiang, HocPhi, SoTietHoc from LOPKHOAHOC,KHOAHOC where LopKhoaHoc.MaKhoaHoc in (select MaKhoaHoc from LOPKHOAHOC where MaLopKhoaHoc = @MaLopKhoaHoc) and NgayKhaiGiang > GETDATE() and LOPKHOAHOC.MaKhoaHoc = KHOAHOC.MaKhoaHoc and LopKhoaHoc.MaLopKhoaHoc != @malopkhoahoc
end
GO
/****** Object:  StoredProcedure [dbo].[spLayDiemThiTN]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spLayDiemThiTN](@tentk nchar(10), @malkh nvarchar(50))
as
begin
select Diem from THAMGIATHI_TOTNGHIEP t, HOCVIEN h where t.MaHocVien=h.MaHocVien and h.TenTaiKhoan =@tentk and t.MaLopKhoaHoc = @malkh
end
GO
/****** Object:  StoredProcedure [dbo].[spXemKQ]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spXemKQ](@tentk nchar(10),@malkh nvarchar(50))
as
begin

 select t.TinhTrangThamGia from THAMGIA_KHOAHOC t, HOCVIEN h
 where t.MaHocVien=h.MaHocVien and h.TenTaiKhoan= @tentk and MaLopKhoaHoc=@malkh
 end

GO
/****** Object:  StoredProcedure [dbo].[spXemKQHocPhan]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[spXemKQHocPhan] (@tentk nchar(10), @malkh nvarchar(50))
as
begin
select hp.MaHocPhan, hp.TenHocPhan, (sum(Diem)/count(t.MaLopMH)) as DiemTB
  from NhomHocPhan hp, THAMGIA_KHOAHOC tg, LopKhoaHoc lkh,MonHoc mh, ThamGiaThi t,LopMonHoc lmh, HOCVIEN h
  where tg.MaHocVien=h.MaHocVien and h.TenTaiKhoan=@tentk and tg.MaLopKhoaHoc= @malkh and hp.MaKhoaHoc= lkh.MaKhoaHoc and lkh.MaLopKhoaHoc=@malkh and mh.MaHocPhan=hp.MaHocPhan and
  mh.MaMonHoc= lmh.MaMonHoc and lmh.MaLopKhoaHoc=lkh.MaLopKhoaHoc and t.MaHocVien=h.MaHocVien and t.MaLopMH=lmh.MaLop
  group by hp.MaHocPhan, hp.TenHocPhan
end
GO
/****** Object:  StoredProcedure [dbo].[spXemKQLopCC]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spXemKQLopCC](@tentk nchar(10),@malkh nvarchar(50))
  as
  begin
   select m.MaMonHoc, TenMonHoc, MaLopMH,Diem
  from MonHoc m, ThamGiaThi t,LopMonHoc l, HOCVIEN h
  where t.MaHocVien=h.MaHocVien and h.TenTaiKhoan=@tentk and l.MaLopKhoaHoc= @malkh and m.MaMonHoc=l.MaMonHoc and t.MaLopMH=l.MaLop 
  end
GO
/****** Object:  StoredProcedure [dbo].[spXemKQMH]    Script Date: 7/12/2021 5:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spXemKQMH] (@tentk nchar(10), @malkh nvarchar(50), @mahp nvarchar(50))
as
begin

   select m.MaMonHoc, TenMonHoc, MaLopMH,Diem
  from MonHoc m, ThamGiaThi t,LopMonHoc l, HOCVIEN h
  where t.MaHocVien=h.MaHocVien and h.TenTaiKhoan=@tentk and l.MaLopKhoaHoc= @malkh and m.MaMonHoc=l.MaMonHoc and t.MaLopMH=l.MaLop and m.MaHocPhan=@mahp
end
GO
