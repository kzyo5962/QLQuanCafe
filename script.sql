USE [QuanLyQuanCaFe]
GO
/****** Object:  StoredProcedure [dbo].[GetBill]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetBill] @maBan int
as 
begin 
select TenMenu,GiaBan,sum(SoLuong) SoLuong,sum(soluong * GiaBan) ThanhTien
from CHITIETHOADON ct,HOADON hd ,BAN b,MENU m
where ct.MaHD=hd.Id and ct.MaMenu=m.ID and hd.MaBan=b.ID and hd.trangthai=1 and b.ID=@maBan
group by TenMenu,GiaBan,SoLuong
end 
GO
/****** Object:  StoredProcedure [dbo].[inserBill]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[inserBill] @idTable int, @maNv int
as
begin
	insert into HOADON(NgayLap,CheckOut,trangthai,MaNV,MaBan)
	 values(getdate(),null,0,@maNv,@idTable)
	
end
GO
/****** Object:  StoredProcedure [dbo].[inserBillInfo]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[inserBillInfo] @MaHd int,@MaMenu int,@SoLuong int,@GiamGia float,@GiaBan float
as
begin
	insert into CHITIETHOADON(MaHD,MaMenu,SoLuong,GiamGia,GiaBan) 
	values(@MaHd,@MaMenu,@SoLuong,@GiamGia,@GiaBan)
	
end
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SoGhe] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHD] [int] NOT NULL,
	[MaMenu] [int] NOT NULL,
	[NgayLap] [datetime] NULL,
	[SoLuong] [int] NOT NULL,
	[GiamGia] [float] NULL,
	[GiaBan] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MaNL] [int] NOT NULL,
	[MaPhieuNhap] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayLap] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONDATHANG]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONDATHANG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[MaNCC] [int] NOT NULL,
	[Manv] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [datetime] NULL,
	[trangthai] [int] NOT NULL,
	[MaNV] [int] NOT NULL,
	[MaBan] [int] NOT NULL,
	[CheckOut] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIMENU]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIMENU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](255) NULL,
	[TrangThai] [int] NOT NULL,
 CONSTRAINT [PK__LOAIMENU__3214EC27943276C0] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAITK]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAITK](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
	[Quyen] [int] NOT NULL,
 CONSTRAINT [PK__LOAITK__3214EC271257DE3A] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MENU]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MENU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenMenu] [nvarchar](255) NULL,
	[MaLoai] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
 CONSTRAINT [PK__MENU__3214EC27AF3F25F0] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNL] [nvarchar](255) NULL,
	[DVT] [nvarchar](20) NULL,
	[DonGia] [float] NOT NULL,
 CONSTRAINT [pk_manl] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SDT] [varchar](11) NOT NULL,
	[Soluong] [int] NULL,
	[MaNL] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](255) NULL,
	[NgayVaoLam] [datetime] NULL,
	[SDT] [varchar](11) NOT NULL,
	[diachi] [nvarchar](255) NULL,
	[HinhAnh] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NOT NULL,
	[NgayLap] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 06/21/2020 8:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[MaLoai] [int] NOT NULL,
	[MaNV] [int] NOT NULL,
 CONSTRAINT [PK__TAIKHOAN__3214EC271AB5CEFF] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BAN] ON 

INSERT [dbo].[BAN] ([ID], [SoGhe], [TrangThai]) VALUES (1, 5, 0)
INSERT [dbo].[BAN] ([ID], [SoGhe], [TrangThai]) VALUES (2, 7, 1)
INSERT [dbo].[BAN] ([ID], [SoGhe], [TrangThai]) VALUES (3, 8, 1)
INSERT [dbo].[BAN] ([ID], [SoGhe], [TrangThai]) VALUES (4, 2, 0)
INSERT [dbo].[BAN] ([ID], [SoGhe], [TrangThai]) VALUES (5, 5, 0)
INSERT [dbo].[BAN] ([ID], [SoGhe], [TrangThai]) VALUES (6, 5, 0)
INSERT [dbo].[BAN] ([ID], [SoGhe], [TrangThai]) VALUES (7, 5, 0)
SET IDENTITY_INSERT [dbo].[BAN] OFF
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMenu], [NgayLap], [SoLuong], [GiamGia], [GiaBan]) VALUES (2, 1, CAST(0x0000ABE100FF681F AS DateTime), 3, 0.3, 25000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMenu], [NgayLap], [SoLuong], [GiamGia], [GiaBan]) VALUES (2, 3, CAST(0x0000ABE100FF7E37 AS DateTime), 1, 0.3, 29000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMenu], [NgayLap], [SoLuong], [GiamGia], [GiaBan]) VALUES (3, 3, CAST(0x0000ABE100FFA50D AS DateTime), 1, 0.3, 29000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMenu], [NgayLap], [SoLuong], [GiamGia], [GiaBan]) VALUES (3, 4, CAST(0x0000ABE100FFB726 AS DateTime), 1, 0.3, 24000)
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([ID], [NgayLap], [trangthai], [MaNV], [MaBan], [CheckOut]) VALUES (2, CAST(0x0000ABE100FE5885 AS DateTime), 1, 1, 1, NULL)
INSERT [dbo].[HOADON] ([ID], [NgayLap], [trangthai], [MaNV], [MaBan], [CheckOut]) VALUES (3, CAST(0x0000ABE100FF8E67 AS DateTime), 1, 1, 3, NULL)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[LOAIMENU] ON 

INSERT [dbo].[LOAIMENU] ([ID], [TenLoai], [TrangThai]) VALUES (1, N'CÀ Phê', 0)
INSERT [dbo].[LOAIMENU] ([ID], [TenLoai], [TrangThai]) VALUES (2, N'Sinh Tố', 0)
INSERT [dbo].[LOAIMENU] ([ID], [TenLoai], [TrangThai]) VALUES (3, N'Hải Sản', 0)
SET IDENTITY_INSERT [dbo].[LOAIMENU] OFF
SET IDENTITY_INSERT [dbo].[LOAITK] ON 

INSERT [dbo].[LOAITK] ([ID], [TenLoai], [Quyen]) VALUES (1, N'Chủ', 0)
INSERT [dbo].[LOAITK] ([ID], [TenLoai], [Quyen]) VALUES (2, N'Bán Hàng', 1)
INSERT [dbo].[LOAITK] ([ID], [TenLoai], [Quyen]) VALUES (3, N'admin', 2)
SET IDENTITY_INSERT [dbo].[LOAITK] OFF
SET IDENTITY_INSERT [dbo].[MENU] ON 

INSERT [dbo].[MENU] ([ID], [TenMenu], [MaLoai], [TrangThai]) VALUES (1, N'Cà Phê Đen', 1, 0)
INSERT [dbo].[MENU] ([ID], [TenMenu], [MaLoai], [TrangThai]) VALUES (2, N'Cà Phê Không Đường', 1, 0)
INSERT [dbo].[MENU] ([ID], [TenMenu], [MaLoai], [TrangThai]) VALUES (3, N'Cà Phê Đá', 1, 0)
INSERT [dbo].[MENU] ([ID], [TenMenu], [MaLoai], [TrangThai]) VALUES (4, N'Sinh Tố Dừa', 2, 0)
INSERT [dbo].[MENU] ([ID], [TenMenu], [MaLoai], [TrangThai]) VALUES (5, N'Sinh Tố Bơ', 2, 0)
INSERT [dbo].[MENU] ([ID], [TenMenu], [MaLoai], [TrangThai]) VALUES (6, N'Sinh Tố Dâu', 2, 0)
SET IDENTITY_INSERT [dbo].[MENU] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([ID], [TenNV], [NgayVaoLam], [SDT], [diachi], [HinhAnh]) VALUES (1, N'Tô Minh Hải', CAST(0x0000ABE100B36037 AS DateTime), N'0306181222', N'Củ chi', NULL)
INSERT [dbo].[NHANVIEN] ([ID], [TenNV], [NgayVaoLam], [SDT], [diachi], [HinhAnh]) VALUES (2, N'Trương Quang Huy', CAST(0x0000ABE100B39C40 AS DateTime), N'0306181222', N'Tân Phú', NULL)
INSERT [dbo].[NHANVIEN] ([ID], [TenNV], [NgayVaoLam], [SDT], [diachi], [HinhAnh]) VALUES (3, N'Nguyễn Quốc Trọng', CAST(0x0000ABE100B39C45 AS DateTime), N'0306181222', N'Tây Ninh', NULL)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON 

INSERT [dbo].[TAIKHOAN] ([ID], [username], [pass], [MaLoai], [MaNV]) VALUES (2, N'MinhHai', N'123456', 1, 1)
INSERT [dbo].[TAIKHOAN] ([ID], [username], [pass], [MaLoai], [MaNV]) VALUES (4, N'QuangHuy', N'123456', 2, 2)
INSERT [dbo].[TAIKHOAN] ([ID], [username], [pass], [MaLoai], [MaNV]) VALUES (5, N'QuocTrong', N'123456', 3, 3)
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [ui_user]    Script Date: 06/21/2020 8:50:44 PM ******/
ALTER TABLE [dbo].[TAIKHOAN] ADD  CONSTRAINT [ui_user] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETHOADON] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[DONDATHANG] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  DEFAULT (getdate()) FOR [NgayVaoLam]
GO
ALTER TABLE [dbo].[PHIEUNHAP] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [fk_mahd_cthd] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([ID])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [fk_mahd_cthd]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [fk_mamenu_cthd] FOREIGN KEY([MaMenu])
REFERENCES [dbo].[MENU] ([ID])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [fk_mamenu_cthd]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [fk_manl] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NGUYENLIEU] ([ID])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [fk_manl]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [fk_maphieunhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAP] ([ID])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [fk_maphieunhap]
GO
ALTER TABLE [dbo].[DONDATHANG]  WITH CHECK ADD  CONSTRAINT [fk_mancc] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([ID])
GO
ALTER TABLE [dbo].[DONDATHANG] CHECK CONSTRAINT [fk_mancc]
GO
ALTER TABLE [dbo].[DONDATHANG]  WITH CHECK ADD  CONSTRAINT [fk_manv_dondh] FOREIGN KEY([Manv])
REFERENCES [dbo].[NHANVIEN] ([ID])
GO
ALTER TABLE [dbo].[DONDATHANG] CHECK CONSTRAINT [fk_manv_dondh]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk_maban] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BAN] ([ID])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk_maban]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk_manv_hd] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([ID])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk_manv_hd]
GO
ALTER TABLE [dbo].[MENU]  WITH CHECK ADD  CONSTRAINT [fk_maloai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAIMENU] ([ID])
GO
ALTER TABLE [dbo].[MENU] CHECK CONSTRAINT [fk_maloai]
GO
ALTER TABLE [dbo].[NHACUNGCAP]  WITH CHECK ADD  CONSTRAINT [fk_manl_nguyenlieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NGUYENLIEU] ([ID])
GO
ALTER TABLE [dbo].[NHACUNGCAP] CHECK CONSTRAINT [fk_manl_nguyenlieu]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [fk_manV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([ID])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [fk_manV]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [fk_maloaitk] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAITK] ([ID])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [fk_maloaitk]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [fk_manv_tk] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([ID])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [fk_manv_tk]
GO
