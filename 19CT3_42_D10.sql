USE [19CT3_42_D10]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 31/5/2022 8:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[IDAcoount] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[IDAcoount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 31/5/2022 8:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDG] [nvarchar](50) NOT NULL,
	[TenDG] [nvarchar](50) NOT NULL,
	[EmailDG] [nvarchar](50) NULL,
	[DiaChiDG] [nvarchar](50) NULL,
	[SdtDG] [nvarchar](50) NULL,
	[NgayLap] [nvarchar](50) NULL,
 CONSTRAINT [PK_DocGia_1] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 31/5/2022 8:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPM] [int] NOT NULL,
	[MaDG] [nvarchar](50) NOT NULL,
	[IDSach] [int] NOT NULL,
	[NgayMuon] [nvarchar](50) NULL,
	[NgayTra] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 31/5/2022 8:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[IDSach] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[MoTa] [nvarchar](50) NULL,
	[Gia] [float] NULL,
	[NgayLap] [nvarchar](50) NULL,
	[MaTL] [int] NULL,
 CONSTRAINT [PK_ThemSach] PRIMARY KEY CLUSTERED 
(
	[IDSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 31/5/2022 8:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTL] [int] IDENTITY(1,1) NOT NULL,
	[TenTL] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([IDAcoount], [Username], [Password]) VALUES (1, N'trongngoc', N'06122001')
GO
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [EmailDG], [DiaChiDG], [SdtDG], [NgayLap]) VALUES (N'10001     ', N'Trần Đại Phúc', N'daiphuc@gmail.com', N'Biến Hòa', N'0987654321     ', N'21/4/2022')
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [EmailDG], [DiaChiDG], [SdtDG], [NgayLap]) VALUES (N'10002     ', N'Nguyễn Trọng Đại', N'trongdai2001@gmail.com', N'Đồng Nai', N'0123456789     ', N'22/4/2022')
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [EmailDG], [DiaChiDG], [SdtDG], [NgayLap]) VALUES (N'10003     ', N'Dương Thị Mỹ Liên', N'mlien@gmail.com', N'Tp.HCM', N'0246813579     ', N'22/4/2022')
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [EmailDG], [DiaChiDG], [SdtDG], [NgayLap]) VALUES (N'10004     ', N'Vỡ Trần Mỹ Linh', N'vtml@gmail.com', N'Bình Dương', N'0258134679     ', N'24/4/2002')
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [EmailDG], [DiaChiDG], [SdtDG], [NgayLap]) VALUES (N'10005     ', N'Nguyễn Văn Minh', N'minh@gmail.com', N'Cà Mau', N'0456789123     ', N'29/4/2022')
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [EmailDG], [DiaChiDG], [SdtDG], [NgayLap]) VALUES (N'10006', N'Trần My', N'tranmy@gmail.com', N'Nghệ An', N'0123456788', N'30/4/2022')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [MaDG], [IDSach], [NgayMuon], [NgayTra], [GhiChu]) VALUES (1, N'10001', 7, N'21/4/2022', N'28/4/2022', N'Không')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaDG], [IDSach], [NgayMuon], [NgayTra], [GhiChu]) VALUES (2, N'10002', 9, N'22/4/2022', N'29/4/2022', N'Không')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaDG], [IDSach], [NgayMuon], [NgayTra], [GhiChu]) VALUES (3, N'10003', 10, N'2/5/2022', N'16/5/2022', N'Gia Hạn 1 Lần')
GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (7, N'Java Script', N'sách công nghệ thông tin', 35000, N'20/4/2022', 1)
INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (8, N'Java', N'sách công nghê thông tin', 40000, N'20/4/2022', 1)
INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (9, N'Cutting Edge 1', N'sách tiếng anh', 35000, N'20/4/2022', 2)
INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (10, N'Dế mèn phiêu lưu ký', N'sách văn học', 45000, N'21/4/2022', 3)
INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (11, N'Đại số và Giải tích 12', N'sách toán học', 25000, N'22/4/2022', 4)
INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (12, N'Hình học nâng cao', N'sách toán học', 35000, N'22/4/2022', 4)
INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (13, N'C/C++', N'sách công nghệ thông tin', 40000, N'23/4/2022', 1)
INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (14, N'Lão Hạc', N'sách văn học', 35000, N'23/4/2022', 3)
INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (15, N'CSDL', N'sách CNTT', 35000, N'25/4/2022', 1)
INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (16, N'Làm đĩ', N'sách văn học', 25000, N'26/4/2022', 3)
INSERT [dbo].[Sach] ([IDSach], [TenSach], [MoTa], [Gia], [NgayLap], [MaTL]) VALUES (17, N'Toán cao cấp', N'sách toán', 45000, N'26/4/2022', 4)
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
SET IDENTITY_INSERT [dbo].[TheLoai] ON 

INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [MoTa], [GhiChu]) VALUES (1, N'CNTT', N'Công nghệ thông tin', N'CT')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [MoTa], [GhiChu]) VALUES (2, N'Tiếng Anh', N'Ngoại Ngữ', N'EN')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [MoTa], [GhiChu]) VALUES (3, N'Văn Học', N'Văn học', N'LT')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [MoTa], [GhiChu]) VALUES (4, N'Toán', N'Toán phổ thông', N'Math')
SET IDENTITY_INSERT [dbo].[TheLoai] OFF
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_DocGia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_DocGia]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_Sach] FOREIGN KEY([IDSach])
REFERENCES [dbo].[Sach] ([IDSach])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_Sach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TheLoai] FOREIGN KEY([MaTL])
REFERENCES [dbo].[TheLoai] ([MaTL])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TheLoai]
GO
/****** Object:  StoredProcedure [dbo].[sp_rptPM]    Script Date: 31/5/2022 8:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_rptPM]
@MaPM as int
as
if @MaPM=0
select ROW_NUMBER() OVER (order by PhieuMuon.MaPM asc) AS STT, DocGia.TenDG , Sach.TenSach, [NgayMuon], [NgayTra], GhiChu
from PhieuMuon, DocGia, Sach
where PhieuMuon.MaDG = DocGia.MaDG and PhieuMuon.IDSach = Sach.IDSach
select ROW_NUMBER() OVER (order by PhieuMuon.MaPM asc) AS STT, DocGia.TenDG , Sach.TenSach, [NgayMuon], [NgayTra], GhiChu
from PhieuMuon, DocGia, Sach
where PhieuMuon.MaDG = DocGia.MaDG and PhieuMuon.IDSach = Sach.IDSach and MaPM = @MaPM
GO
/****** Object:  StoredProcedure [dbo].[sp_rptSach]    Script Date: 31/5/2022 8:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_rptSach]
@MaSach as nvarchar
as
if @MaSach=0
select ROW_NUMBER() OVER (order by Sach.MaTL desc) AS MaSach, TenSach, Sach.MoTa, [Gia], [NgayLap]
from Sach, TheLoai
where Sach.MaTL = TheLoai.MaTL
else
select ROW_NUMBER() OVER (order by Sach.MaTL desc) AS MaSach, TenSach, Sach.MoTa, [Gia], [NgayLap]
from Sach, TheLoai
where Sach.MaTL = TheLoai.MaTL and MaSach=@MaSach
GO
