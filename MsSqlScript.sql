USE [master]
GO
/****** Object:  Database [EbeveynTakip]    Script Date: 13.01.2020 23:06:59 ******/
CREATE DATABASE [EbeveynTakip]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EbeveynTakip', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EbeveynTakip.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EbeveynTakip_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EbeveynTakip_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EbeveynTakip] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EbeveynTakip].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EbeveynTakip] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EbeveynTakip] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EbeveynTakip] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EbeveynTakip] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EbeveynTakip] SET ARITHABORT OFF 
GO
ALTER DATABASE [EbeveynTakip] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EbeveynTakip] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EbeveynTakip] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EbeveynTakip] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EbeveynTakip] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EbeveynTakip] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EbeveynTakip] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EbeveynTakip] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EbeveynTakip] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EbeveynTakip] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EbeveynTakip] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EbeveynTakip] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EbeveynTakip] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EbeveynTakip] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EbeveynTakip] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EbeveynTakip] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EbeveynTakip] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EbeveynTakip] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EbeveynTakip] SET  MULTI_USER 
GO
ALTER DATABASE [EbeveynTakip] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EbeveynTakip] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EbeveynTakip] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EbeveynTakip] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EbeveynTakip] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EbeveynTakip] SET QUERY_STORE = OFF
GO
USE [EbeveynTakip]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 13.01.2020 23:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mail]    Script Date: 13.01.2020 23:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adress] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Mail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Report]    Script Date: 13.01.2020 23:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SiteTitle] [nvarchar](500) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[BanID] [int] NOT NULL,
 CONSTRAINT [PK_Report] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 13.01.2020 23:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ban] ON 

INSERT [dbo].[Ban] ([Id], [Name]) VALUES (1, N'FACEBOOK')
INSERT [dbo].[Ban] ([Id], [Name]) VALUES (2, N'INSTAGRAM')
INSERT [dbo].[Ban] ([Id], [Name]) VALUES (3, N'TWİTTER')
INSERT [dbo].[Ban] ([Id], [Name]) VALUES (4, N'POKER')
INSERT [dbo].[Ban] ([Id], [Name]) VALUES (5, N'OKEY')
INSERT [dbo].[Ban] ([Id], [Name]) VALUES (6, N'TAVLA')
INSERT [dbo].[Ban] ([Id], [Name]) VALUES (7, N'SNAPCHAT')
SET IDENTITY_INSERT [dbo].[Ban] OFF
SET IDENTITY_INSERT [dbo].[Mail] ON 

INSERT [dbo].[Mail] ([Id], [Adress]) VALUES (1, N'abdullah-zengin@hotmail.com.tr')
SET IDENTITY_INSERT [dbo].[Mail] OFF
SET IDENTITY_INSERT [dbo].[Report] ON 

INSERT [dbo].[Report] ([Id], [SiteTitle], [DateTime], [BanID]) VALUES (3, N'Twitter', CAST(N'2019-09-22T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Report] ([Id], [SiteTitle], [DateTime], [BanID]) VALUES (4, N'Okey Oyna', CAST(N'2019-09-23T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Report] ([Id], [SiteTitle], [DateTime], [BanID]) VALUES (5, N'Kumar Siteleri Google', CAST(N'2019-09-22T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Report] ([Id], [SiteTitle], [DateTime], [BanID]) VALUES (8, N'okey — Yandex: 650 bin sonuç bulundu ‎- Microsoft Edge', CAST(N'2020-01-10T21:45:41.633' AS DateTime), 5)
INSERT [dbo].[Report] ([Id], [SiteTitle], [DateTime], [BanID]) VALUES (9, N'okey — Yandex: 650 bin sonuç bulundu ‎- Microsoft Edge', CAST(N'2020-01-10T21:52:10.580' AS DateTime), 5)
INSERT [dbo].[Report] ([Id], [SiteTitle], [DateTime], [BanID]) VALUES (10, N'okey — Yandex: 650 bin sonuç bulundu ‎- Microsoft Edge', CAST(N'2020-01-10T21:52:11.477' AS DateTime), 5)
INSERT [dbo].[Report] ([Id], [SiteTitle], [DateTime], [BanID]) VALUES (11, N'okey — Yandex: 651 bin sonuç bulundu ‎- Microsoft Edge', CAST(N'2020-01-10T21:52:52.670' AS DateTime), 5)
INSERT [dbo].[Report] ([Id], [SiteTitle], [DateTime], [BanID]) VALUES (12, N'okey — Yandex: 651 bin sonuç bulundu ‎- Microsoft Edge', CAST(N'2020-01-10T21:59:02.577' AS DateTime), 5)
INSERT [dbo].[Report] ([Id], [SiteTitle], [DateTime], [BanID]) VALUES (13, N'okey — Yandex: 651 bin sonuç bulundu ‎- Microsoft Edge', CAST(N'2020-01-10T22:03:06.083' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[Report] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Name], [Password]) VALUES (1, N'asd', N'qwe')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Report]  WITH CHECK ADD  CONSTRAINT [FK_Report_Ban] FOREIGN KEY([BanID])
REFERENCES [dbo].[Ban] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Report] CHECK CONSTRAINT [FK_Report_Ban]
GO
USE [master]
GO
ALTER DATABASE [EbeveynTakip] SET  READ_WRITE 
GO
