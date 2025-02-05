USE [master]
GO
/****** Object:  Database [libaray]    Script Date: 7/11/2020 11:20:58 PM ******/
CREATE DATABASE [libaray]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'libaray', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\libaray.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'libaray_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\libaray_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [libaray] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [libaray].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [libaray] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [libaray] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [libaray] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [libaray] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [libaray] SET ARITHABORT OFF 
GO
ALTER DATABASE [libaray] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [libaray] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [libaray] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [libaray] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [libaray] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [libaray] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [libaray] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [libaray] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [libaray] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [libaray] SET  DISABLE_BROKER 
GO
ALTER DATABASE [libaray] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [libaray] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [libaray] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [libaray] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [libaray] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [libaray] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [libaray] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [libaray] SET RECOVERY FULL 
GO
ALTER DATABASE [libaray] SET  MULTI_USER 
GO
ALTER DATABASE [libaray] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [libaray] SET DB_CHAINING OFF 
GO
ALTER DATABASE [libaray] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [libaray] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [libaray] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'libaray', N'ON'
GO
ALTER DATABASE [libaray] SET QUERY_STORE = OFF
GO
USE [libaray]
GO
/****** Object:  Table [dbo].[tbl_author]    Script Date: 7/11/2020 11:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_author](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[country] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_author] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_books_borwer]    Script Date: 7/11/2020 11:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_books_borwer](
	[id] [int] NOT NULL,
	[bower_id] [int] NULL,
	[book_id] [int] NULL,
	[start_date] [nvarchar](50) NULL,
	[return_date] [nvarchar](50) NULL,
	[notes] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_books_borwer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_books_data]    Script Date: 7/11/2020 11:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_books_data](
	[id] [int] NOT NULL,
	[book_name] [nvarchar](50) NULL,
	[category_id] [int] NULL,
	[author_id] [int] NULL,
	[country_id] [int] NULL,
	[writehouse_id] [int] NULL,
	[subcat] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[pages_num] [int] NULL,
	[place_id] [int] NULL,
	[book_status] [nvarchar](50) NULL,
	[book_price] [real] NULL,
 CONSTRAINT [PK_tbl_books_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_borwers]    Script Date: 7/11/2020 11:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_borwers](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_borwers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_category]    Script Date: 7/11/2020 11:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_category](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_country]    Script Date: 7/11/2020 11:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_country](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_country] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_places]    Script Date: 7/11/2020 11:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_places](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_palces] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_writehouse]    Script Date: 7/11/2020 11:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_writehouse](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[country] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_writehouse] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_books_borwer]  WITH CHECK ADD  CONSTRAINT [FK_tbl_books_borwer_tbl_books_data] FOREIGN KEY([book_id])
REFERENCES [dbo].[tbl_books_data] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_books_borwer] CHECK CONSTRAINT [FK_tbl_books_borwer_tbl_books_data]
GO
ALTER TABLE [dbo].[tbl_books_borwer]  WITH CHECK ADD  CONSTRAINT [FK_tbl_books_borwer_tbl_borwers] FOREIGN KEY([bower_id])
REFERENCES [dbo].[tbl_borwers] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_books_borwer] CHECK CONSTRAINT [FK_tbl_books_borwer_tbl_borwers]
GO
ALTER TABLE [dbo].[tbl_books_data]  WITH CHECK ADD  CONSTRAINT [FK_tbl_books_data_tbl_author] FOREIGN KEY([author_id])
REFERENCES [dbo].[tbl_author] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_books_data] CHECK CONSTRAINT [FK_tbl_books_data_tbl_author]
GO
ALTER TABLE [dbo].[tbl_books_data]  WITH CHECK ADD  CONSTRAINT [FK_tbl_books_data_tbl_category] FOREIGN KEY([category_id])
REFERENCES [dbo].[tbl_category] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_books_data] CHECK CONSTRAINT [FK_tbl_books_data_tbl_category]
GO
ALTER TABLE [dbo].[tbl_books_data]  WITH CHECK ADD  CONSTRAINT [FK_tbl_books_data_tbl_country] FOREIGN KEY([country_id])
REFERENCES [dbo].[tbl_country] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_books_data] CHECK CONSTRAINT [FK_tbl_books_data_tbl_country]
GO
ALTER TABLE [dbo].[tbl_books_data]  WITH CHECK ADD  CONSTRAINT [FK_tbl_books_data_tbl_places] FOREIGN KEY([place_id])
REFERENCES [dbo].[tbl_places] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_books_data] CHECK CONSTRAINT [FK_tbl_books_data_tbl_places]
GO
ALTER TABLE [dbo].[tbl_books_data]  WITH CHECK ADD  CONSTRAINT [FK_tbl_books_data_tbl_writehouse] FOREIGN KEY([writehouse_id])
REFERENCES [dbo].[tbl_writehouse] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_books_data] CHECK CONSTRAINT [FK_tbl_books_data_tbl_writehouse]
GO
USE [master]
GO
ALTER DATABASE [libaray] SET  READ_WRITE 
GO
