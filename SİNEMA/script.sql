USE [master]
GO
/****** Object:  Database [SinemaaDb]    Script Date: 18.11.2019 19:52:53 ******/
CREATE DATABASE [SinemaaDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SinemaaDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SinemaaDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SinemaaDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SinemaaDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SinemaaDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SinemaaDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SinemaaDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SinemaaDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SinemaaDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SinemaaDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SinemaaDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [SinemaaDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SinemaaDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SinemaaDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SinemaaDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SinemaaDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SinemaaDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SinemaaDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SinemaaDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SinemaaDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SinemaaDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SinemaaDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SinemaaDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SinemaaDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SinemaaDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SinemaaDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SinemaaDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SinemaaDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SinemaaDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SinemaaDb] SET  MULTI_USER 
GO
ALTER DATABASE [SinemaaDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SinemaaDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SinemaaDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SinemaaDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SinemaaDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SinemaaDb] SET QUERY_STORE = OFF
GO
USE [SinemaaDb]
GO
/****** Object:  Table [dbo].[blgFilm]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blgFilm](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FilmTabloId] [int] NULL,
	[SalonId] [int] NULL,
	[SeansId] [int] NULL,
	[TurId] [int] NULL,
	[Fiyat] [float] NULL,
	[ResimUrl] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blgFilmTablo]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blgFilmTablo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FilmAdi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blgIcecek]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blgIcecek](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IcecekAdi] [nvarchar](50) NULL,
	[Fiyat] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blgKoltuk]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blgKoltuk](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KoltukNo] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blgPersonel]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blgPersonel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blgSalon]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blgSalon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SalonNo] [nvarchar](50) NULL,
	[KoltukSayisi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blgSeans]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blgSeans](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Seans] [nvarchar](50) NULL,
	[SalonId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blgTur]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blgTur](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TurAdi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blgYiyecek]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blgYiyecek](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YiyecekAdi] [nvarchar](50) NULL,
	[Fiyat] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blgYonetici]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blgYonetici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCiro]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCiro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ToplamBilet] [int] NULL,
	[Tarih] [datetime] NULL,
	[Ciro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSatis]    Script Date: 18.11.2019 19:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSatis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](100) NULL,
	[TurId] [int] NULL,
	[FilmId] [int] NULL,
	[SalonId] [int] NULL,
	[SeansId] [int] NULL,
	[YiyecekId] [int] NULL,
	[IcecekId] [int] NULL,
	[BiletAdet] [int] NULL,
	[BiletNo] [nvarchar](10) NULL,
	[PersonelId] [int] NULL,
	[KoltukId] [int] NULL,
	[Tarih] [datetime] NULL,
	[Tutar] [float] NULL,
 CONSTRAINT [PK_tblFilmler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[blgFilm] ON 

INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (9, 1, 1, 1, 1, 17, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (10, 1, 1, 3, 1, 20, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (11, 1, 2, 2, 1, 18, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (12, 1, 2, 4, 1, 21, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (13, 2, 3, 1, 1, 17, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (14, 2, 3, 2, 1, 18, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (15, 2, 3, 4, 1, 21, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (16, 2, 1, 2, 1, 18, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (17, 2, 1, 4, 1, 20, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (18, 3, 2, 1, 5, 17, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (19, 3, 2, 3, 5, 20, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (20, 3, 3, 3, 5, 20, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (21, 3, 4, 2, 5, 18, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (22, 3, 4, 3, 5, 20, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (23, 4, 4, 1, 6, 17, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (24, 4, 4, 4, 6, 17, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (25, 4, 5, 2, 6, 18, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (26, 8, 6, 1, 1, 17, NULL)
INSERT [dbo].[blgFilm] ([Id], [FilmTabloId], [SalonId], [SeansId], [TurId], [Fiyat], [ResimUrl]) VALUES (27, 10, 5, 1, 6, 17, NULL)
SET IDENTITY_INSERT [dbo].[blgFilm] OFF
SET IDENTITY_INSERT [dbo].[blgFilmTablo] ON 

INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (1, N'Mucize 2')
INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (2, N'7. Koğuştaki Mucize')
INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (3, N'Joker')
INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (4, N'Cep Herkül: Naim Süleymanoğlu')
INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (5, N'Hababam Sınıfı')
INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (6, N'Banker Bilo')
INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (7, N'3 idiot')
INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (8, N'Aşk Tesadüfleri Sever')
INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (9, N'Dangal')
INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (10, N'Asfaltın Kralları')
INSERT [dbo].[blgFilmTablo] ([Id], [FilmAdi]) VALUES (11, N'İnanılmaz Aile')
SET IDENTITY_INSERT [dbo].[blgFilmTablo] OFF
SET IDENTITY_INSERT [dbo].[blgIcecek] ON 

INSERT [dbo].[blgIcecek] ([Id], [IcecekAdi], [Fiyat]) VALUES (1, N'Belirtilmemiş', 0)
INSERT [dbo].[blgIcecek] ([Id], [IcecekAdi], [Fiyat]) VALUES (2, N'Coca-Cola', 4)
INSERT [dbo].[blgIcecek] ([Id], [IcecekAdi], [Fiyat]) VALUES (3, N'Fanta', 4)
INSERT [dbo].[blgIcecek] ([Id], [IcecekAdi], [Fiyat]) VALUES (4, N'Lipton Ice Tea', 3)
INSERT [dbo].[blgIcecek] ([Id], [IcecekAdi], [Fiyat]) VALUES (5, N'Çamlıca Gazoz', 3)
INSERT [dbo].[blgIcecek] ([Id], [IcecekAdi], [Fiyat]) VALUES (6, N'Kızılay Sade Soda', 2)
INSERT [dbo].[blgIcecek] ([Id], [IcecekAdi], [Fiyat]) VALUES (7, N'Fresha', 3)
INSERT [dbo].[blgIcecek] ([Id], [IcecekAdi], [Fiyat]) VALUES (8, N'Su', 1)
INSERT [dbo].[blgIcecek] ([Id], [IcecekAdi], [Fiyat]) VALUES (9, N'Schweppes', 12)
SET IDENTITY_INSERT [dbo].[blgIcecek] OFF
SET IDENTITY_INSERT [dbo].[blgKoltuk] ON 

INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (1, N'1')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (2, N'2')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (3, N'3')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (4, N'4')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (5, N'5')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (6, N'6')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (7, N'7')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (8, N'8')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (9, N'9')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (10, N'10')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (11, N'11')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (12, N'12')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (13, N'13')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (14, N'14')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (15, N'15')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (16, N'16')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (17, N'17')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (18, N'18')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (19, N'19')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (20, N'20')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (21, N'21')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (22, N'22')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (23, N'23')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (24, N'24')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (25, N'25')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (26, N'26')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (27, N'27')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (28, N'28')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (29, N'29')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (30, N'30')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (31, N'31')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (32, N'32')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (33, N'33')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (34, N'34')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (35, N'35')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (36, N'36')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (37, N'37')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (38, N'38')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (39, N'39')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (40, N'40')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (41, N'41')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (42, N'42')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (43, N'43')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (44, N'44')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (45, N'45')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (46, N'46')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (47, N'47')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (48, N'48')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (49, N'49')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (50, N'50')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (51, N'51')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (52, N'52')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (53, N'53')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (54, N'54')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (55, N'55')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (56, N'56')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (57, N'57')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (58, N'58')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (59, N'59')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (60, N'60')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (61, N'61')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (62, N'62')
INSERT [dbo].[blgKoltuk] ([Id], [KoltukNo]) VALUES (63, N'63')
SET IDENTITY_INSERT [dbo].[blgKoltuk] OFF
SET IDENTITY_INSERT [dbo].[blgPersonel] ON 

INSERT [dbo].[blgPersonel] ([Id], [PersonelAdi], [Sifre], [KullaniciAdi]) VALUES (1, N'Eda Balçın', N'12345', N'ebalcin')
INSERT [dbo].[blgPersonel] ([Id], [PersonelAdi], [Sifre], [KullaniciAdi]) VALUES (2, N'Melike Arıkan', N'12345', N'marikan')
INSERT [dbo].[blgPersonel] ([Id], [PersonelAdi], [Sifre], [KullaniciAdi]) VALUES (3, N'Muhammed Tiryaki', N'12345', N'mtiryaki')
INSERT [dbo].[blgPersonel] ([Id], [PersonelAdi], [Sifre], [KullaniciAdi]) VALUES (4, N'Sinem Özmen', N'12345', N'sozmen')
INSERT [dbo].[blgPersonel] ([Id], [PersonelAdi], [Sifre], [KullaniciAdi]) VALUES (5, N'Selvi Yağışan', N'12345', N'syagisan')
INSERT [dbo].[blgPersonel] ([Id], [PersonelAdi], [Sifre], [KullaniciAdi]) VALUES (6, N'Ülkü Biderci', N'12345', N'ubiderci')
INSERT [dbo].[blgPersonel] ([Id], [PersonelAdi], [Sifre], [KullaniciAdi]) VALUES (7, N'Yasin Akdoğan', N'12345', N'yakdogan')
INSERT [dbo].[blgPersonel] ([Id], [PersonelAdi], [Sifre], [KullaniciAdi]) VALUES (8, N'Yasin Karagöz', N'12345', N'ykaragoz')
SET IDENTITY_INSERT [dbo].[blgPersonel] OFF
SET IDENTITY_INSERT [dbo].[blgSalon] ON 

INSERT [dbo].[blgSalon] ([Id], [SalonNo], [KoltukSayisi]) VALUES (1, N'Salon1', 30)
INSERT [dbo].[blgSalon] ([Id], [SalonNo], [KoltukSayisi]) VALUES (2, N'Salon2', 20)
INSERT [dbo].[blgSalon] ([Id], [SalonNo], [KoltukSayisi]) VALUES (3, N'Salon3', 15)
INSERT [dbo].[blgSalon] ([Id], [SalonNo], [KoltukSayisi]) VALUES (4, N'Salon 4', 27)
INSERT [dbo].[blgSalon] ([Id], [SalonNo], [KoltukSayisi]) VALUES (5, N'Salon 5', 18)
INSERT [dbo].[blgSalon] ([Id], [SalonNo], [KoltukSayisi]) VALUES (6, N'Salon 6', 22)
INSERT [dbo].[blgSalon] ([Id], [SalonNo], [KoltukSayisi]) VALUES (7, N'Salon 7', 23)
SET IDENTITY_INSERT [dbo].[blgSalon] OFF
SET IDENTITY_INSERT [dbo].[blgSeans] ON 

INSERT [dbo].[blgSeans] ([Id], [Seans], [SalonId]) VALUES (1, N'11.00', NULL)
INSERT [dbo].[blgSeans] ([Id], [Seans], [SalonId]) VALUES (2, N'15.00', NULL)
INSERT [dbo].[blgSeans] ([Id], [Seans], [SalonId]) VALUES (3, N'19.00', NULL)
INSERT [dbo].[blgSeans] ([Id], [Seans], [SalonId]) VALUES (4, N'21.00', NULL)
SET IDENTITY_INSERT [dbo].[blgSeans] OFF
SET IDENTITY_INSERT [dbo].[blgTur] ON 

INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (1, N'Dram')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (2, N'Komedi')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (3, N'Aile')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (4, N'Gerilim')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (5, N'Fantastik')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (6, N'Biyografi')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (7, N'Animasyon')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (8, N'Korku')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (9, N'Aksiyon')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (10, N'Macera')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (11, N'Polisiye')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (12, N'Savaş')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (13, N'Romantik')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (14, N'Gizem')
INSERT [dbo].[blgTur] ([Id], [TurAdi]) VALUES (15, N'Müzikal')
SET IDENTITY_INSERT [dbo].[blgTur] OFF
SET IDENTITY_INSERT [dbo].[blgYiyecek] ON 

INSERT [dbo].[blgYiyecek] ([Id], [YiyecekAdi], [Fiyat]) VALUES (1, N'Belirtilmemiş', 0)
INSERT [dbo].[blgYiyecek] ([Id], [YiyecekAdi], [Fiyat]) VALUES (2, N'Çikolata', 5)
INSERT [dbo].[blgYiyecek] ([Id], [YiyecekAdi], [Fiyat]) VALUES (3, N'Cips', 8)
INSERT [dbo].[blgYiyecek] ([Id], [YiyecekAdi], [Fiyat]) VALUES (4, N'Kek', 3)
INSERT [dbo].[blgYiyecek] ([Id], [YiyecekAdi], [Fiyat]) VALUES (5, N'Jelibon', 4)
INSERT [dbo].[blgYiyecek] ([Id], [YiyecekAdi], [Fiyat]) VALUES (6, N'Sandviç', 6)
INSERT [dbo].[blgYiyecek] ([Id], [YiyecekAdi], [Fiyat]) VALUES (7, N'Bisküvi Çeşitleri', 5)
INSERT [dbo].[blgYiyecek] ([Id], [YiyecekAdi], [Fiyat]) VALUES (8, N'Soslu Fıstık', 4)
INSERT [dbo].[blgYiyecek] ([Id], [YiyecekAdi], [Fiyat]) VALUES (9, N'Patlamış Mısır', 14)
INSERT [dbo].[blgYiyecek] ([Id], [YiyecekAdi], [Fiyat]) VALUES (10, N'Nutella', 20)
SET IDENTITY_INSERT [dbo].[blgYiyecek] OFF
SET IDENTITY_INSERT [dbo].[blgYonetici] ON 

INSERT [dbo].[blgYonetici] ([Id], [KullaniciAdi], [Sifre]) VALUES (1, N'ebalcin', N'12345')
INSERT [dbo].[blgYonetici] ([Id], [KullaniciAdi], [Sifre]) VALUES (2, N'marikan', N'12345')
INSERT [dbo].[blgYonetici] ([Id], [KullaniciAdi], [Sifre]) VALUES (3, N'mtiryaki', N'12345')
INSERT [dbo].[blgYonetici] ([Id], [KullaniciAdi], [Sifre]) VALUES (4, N'sozmen', N'12345')
INSERT [dbo].[blgYonetici] ([Id], [KullaniciAdi], [Sifre]) VALUES (5, N'syagisan', N'12345')
INSERT [dbo].[blgYonetici] ([Id], [KullaniciAdi], [Sifre]) VALUES (6, N'ubiderci', N'12345')
INSERT [dbo].[blgYonetici] ([Id], [KullaniciAdi], [Sifre]) VALUES (7, N'yakdogan', N'12345')
INSERT [dbo].[blgYonetici] ([Id], [KullaniciAdi], [Sifre]) VALUES (8, N'ykaragoz', N'12345')
SET IDENTITY_INSERT [dbo].[blgYonetici] OFF
SET IDENTITY_INSERT [dbo].[tblCiro] ON 

INSERT [dbo].[tblCiro] ([Id], [ToplamBilet], [Tarih], [Ciro]) VALUES (1, 6, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 106)
SET IDENTITY_INSERT [dbo].[tblCiro] OFF
SET IDENTITY_INSERT [dbo].[tblSatis] ON 

INSERT [dbo].[tblSatis] ([Id], [AdSoyad], [TurId], [FilmId], [SalonId], [SeansId], [YiyecekId], [IcecekId], [BiletAdet], [BiletNo], [PersonelId], [KoltukId], [Tarih], [Tutar]) VALUES (18, N'selvinur', NULL, 2, 3, 1, 1, 1, 1, N'0000000001', 8, 13, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 17)
INSERT [dbo].[tblSatis] ([Id], [AdSoyad], [TurId], [FilmId], [SalonId], [SeansId], [YiyecekId], [IcecekId], [BiletAdet], [BiletNo], [PersonelId], [KoltukId], [Tarih], [Tutar]) VALUES (19, N'selvinur', NULL, 2, 3, 1, 1, 1, 1, N'0000000001', 8, 14, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 17)
INSERT [dbo].[tblSatis] ([Id], [AdSoyad], [TurId], [FilmId], [SalonId], [SeansId], [YiyecekId], [IcecekId], [BiletAdet], [BiletNo], [PersonelId], [KoltukId], [Tarih], [Tutar]) VALUES (20, N'yavuz', NULL, 2, 1, 2, 1, 1, 1, N'0000000002', 8, 22, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 18)
INSERT [dbo].[tblSatis] ([Id], [AdSoyad], [TurId], [FilmId], [SalonId], [SeansId], [YiyecekId], [IcecekId], [BiletAdet], [BiletNo], [PersonelId], [KoltukId], [Tarih], [Tutar]) VALUES (21, N'yavuz', NULL, 2, 1, 2, 1, 1, 1, N'0000000002', 8, 23, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 18)
INSERT [dbo].[tblSatis] ([Id], [AdSoyad], [TurId], [FilmId], [SalonId], [SeansId], [YiyecekId], [IcecekId], [BiletAdet], [BiletNo], [PersonelId], [KoltukId], [Tarih], [Tutar]) VALUES (22, N'yavuz', NULL, 2, 1, 2, 1, 1, 1, N'0000000002', 8, 24, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 18)
INSERT [dbo].[tblSatis] ([Id], [AdSoyad], [TurId], [FilmId], [SalonId], [SeansId], [YiyecekId], [IcecekId], [BiletAdet], [BiletNo], [PersonelId], [KoltukId], [Tarih], [Tutar]) VALUES (23, N'yavuz', NULL, 2, 1, 2, 1, 1, 1, N'0000000002', 8, 25, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 18)
INSERT [dbo].[tblSatis] ([Id], [AdSoyad], [TurId], [FilmId], [SalonId], [SeansId], [YiyecekId], [IcecekId], [BiletAdet], [BiletNo], [PersonelId], [KoltukId], [Tarih], [Tutar]) VALUES (24, N'asd', NULL, 1, 1, 1, 2, 2, 1, N'0000000003', 1, 16, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 21.5)
INSERT [dbo].[tblSatis] ([Id], [AdSoyad], [TurId], [FilmId], [SalonId], [SeansId], [YiyecekId], [IcecekId], [BiletAdet], [BiletNo], [PersonelId], [KoltukId], [Tarih], [Tutar]) VALUES (25, N'asd', NULL, 1, 1, 1, 2, 2, 1, N'0000000003', 1, 19, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 21.5)
INSERT [dbo].[tblSatis] ([Id], [AdSoyad], [TurId], [FilmId], [SalonId], [SeansId], [YiyecekId], [IcecekId], [BiletAdet], [BiletNo], [PersonelId], [KoltukId], [Tarih], [Tutar]) VALUES (26, N'Melike', NULL, 2, 3, 1, 2, 2, 1, N'0000000004', 1, 7, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 21.5)
INSERT [dbo].[tblSatis] ([Id], [AdSoyad], [TurId], [FilmId], [SalonId], [SeansId], [YiyecekId], [IcecekId], [BiletAdet], [BiletNo], [PersonelId], [KoltukId], [Tarih], [Tutar]) VALUES (27, N'Melike', NULL, 2, 3, 1, 2, 2, 1, N'0000000004', 1, 8, CAST(N'2019-11-18T00:00:00.000' AS DateTime), 21.5)
SET IDENTITY_INSERT [dbo].[tblSatis] OFF
ALTER TABLE [dbo].[blgFilm]  WITH CHECK ADD  CONSTRAINT [FK_blgFilm_blgFilmTablo] FOREIGN KEY([FilmTabloId])
REFERENCES [dbo].[blgFilmTablo] ([Id])
GO
ALTER TABLE [dbo].[blgFilm] CHECK CONSTRAINT [FK_blgFilm_blgFilmTablo]
GO
ALTER TABLE [dbo].[blgFilm]  WITH CHECK ADD  CONSTRAINT [FK_blgFilm_blgSalon] FOREIGN KEY([SalonId])
REFERENCES [dbo].[blgSalon] ([Id])
GO
ALTER TABLE [dbo].[blgFilm] CHECK CONSTRAINT [FK_blgFilm_blgSalon]
GO
ALTER TABLE [dbo].[blgFilm]  WITH CHECK ADD  CONSTRAINT [FK_blgFilm_blgSeans] FOREIGN KEY([SeansId])
REFERENCES [dbo].[blgSeans] ([Id])
GO
ALTER TABLE [dbo].[blgFilm] CHECK CONSTRAINT [FK_blgFilm_blgSeans]
GO
ALTER TABLE [dbo].[blgFilm]  WITH CHECK ADD  CONSTRAINT [FK_blgFilm_blgTur] FOREIGN KEY([TurId])
REFERENCES [dbo].[blgTur] ([Id])
GO
ALTER TABLE [dbo].[blgFilm] CHECK CONSTRAINT [FK_blgFilm_blgTur]
GO
ALTER TABLE [dbo].[blgSeans]  WITH CHECK ADD  CONSTRAINT [FK_blgSeans_blgSalon] FOREIGN KEY([SalonId])
REFERENCES [dbo].[blgSalon] ([Id])
GO
ALTER TABLE [dbo].[blgSeans] CHECK CONSTRAINT [FK_blgSeans_blgSalon]
GO
ALTER TABLE [dbo].[tblSatis]  WITH CHECK ADD  CONSTRAINT [FK_tblSatis_blgFilmTablo] FOREIGN KEY([FilmId])
REFERENCES [dbo].[blgFilmTablo] ([Id])
GO
ALTER TABLE [dbo].[tblSatis] CHECK CONSTRAINT [FK_tblSatis_blgFilmTablo]
GO
ALTER TABLE [dbo].[tblSatis]  WITH CHECK ADD  CONSTRAINT [FK_tblSatis_blgIcecek] FOREIGN KEY([IcecekId])
REFERENCES [dbo].[blgIcecek] ([Id])
GO
ALTER TABLE [dbo].[tblSatis] CHECK CONSTRAINT [FK_tblSatis_blgIcecek]
GO
ALTER TABLE [dbo].[tblSatis]  WITH CHECK ADD  CONSTRAINT [FK_tblSatis_blgKoltuk] FOREIGN KEY([KoltukId])
REFERENCES [dbo].[blgKoltuk] ([Id])
GO
ALTER TABLE [dbo].[tblSatis] CHECK CONSTRAINT [FK_tblSatis_blgKoltuk]
GO
ALTER TABLE [dbo].[tblSatis]  WITH CHECK ADD  CONSTRAINT [FK_tblSatis_blgPersonel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[blgPersonel] ([Id])
GO
ALTER TABLE [dbo].[tblSatis] CHECK CONSTRAINT [FK_tblSatis_blgPersonel]
GO
ALTER TABLE [dbo].[tblSatis]  WITH CHECK ADD  CONSTRAINT [FK_tblSatis_blgSalon] FOREIGN KEY([SalonId])
REFERENCES [dbo].[blgSalon] ([Id])
GO
ALTER TABLE [dbo].[tblSatis] CHECK CONSTRAINT [FK_tblSatis_blgSalon]
GO
ALTER TABLE [dbo].[tblSatis]  WITH CHECK ADD  CONSTRAINT [FK_tblSatis_blgSeans] FOREIGN KEY([SeansId])
REFERENCES [dbo].[blgSeans] ([Id])
GO
ALTER TABLE [dbo].[tblSatis] CHECK CONSTRAINT [FK_tblSatis_blgSeans]
GO
ALTER TABLE [dbo].[tblSatis]  WITH CHECK ADD  CONSTRAINT [FK_tblSatis_blgTur] FOREIGN KEY([TurId])
REFERENCES [dbo].[blgTur] ([Id])
GO
ALTER TABLE [dbo].[tblSatis] CHECK CONSTRAINT [FK_tblSatis_blgTur]
GO
ALTER TABLE [dbo].[tblSatis]  WITH CHECK ADD  CONSTRAINT [FK_tblSatis_blgYiyecek] FOREIGN KEY([YiyecekId])
REFERENCES [dbo].[blgYiyecek] ([Id])
GO
ALTER TABLE [dbo].[tblSatis] CHECK CONSTRAINT [FK_tblSatis_blgYiyecek]
GO
USE [master]
GO
ALTER DATABASE [SinemaaDb] SET  READ_WRITE 
GO
