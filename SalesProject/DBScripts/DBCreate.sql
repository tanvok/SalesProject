USE [master]
GO
/****** Object:  Database [DBTest]    Script Date: 22.05.2017 13:58:18 ******/
CREATE DATABASE [DBTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBTest', FILENAME = N'D:\MSSQL11.MSSQLSERVER\MSSQL\DATA\DBTest.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBTest_log', FILENAME = N'D:\MSSQL11.MSSQLSERVER\MSSQL\DATA\DBTest_log.ldf' , SIZE = 13312KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBTest] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBTest] SET RECOVERY FULL 
GO
ALTER DATABASE [DBTest] SET  MULTI_USER 
GO
ALTER DATABASE [DBTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBTest] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBTest', N'ON'
GO
USE [DBTest]
GO
/****** Object:  Table [dbo].[MeasureType]    Script Date: 22.05.2017 13:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MeasureType](
	[id] [int] NOT NULL,
	[MeasureTypeName] [varchar](50) NULL,
	[MeasureTypeSmallName] [varchar](50) NULL,
 CONSTRAINT [PK_MeasureType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Operation]    Script Date: 22.05.2017 13:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Operation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OperationDateTime] [datetime] NOT NULL,
	[Payment] [numeric](18, 2) NULL,
	[Delivery] [numeric](18, 2) NULL,
	[idOperationState] [int] NOT NULL,
	[idOperationType] [int] NOT NULL,
	[DocNumber] [varchar](50) NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OperationContent]    Script Date: 22.05.2017 13:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationContent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idProductPrice] [int] NOT NULL,
	[idOperation] [int] NOT NULL,
	[Count] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_SalePosition] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OperationState]    Script Date: 22.05.2017 13:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OperationState](
	[id] [int] NOT NULL,
	[OperationStateName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SaleState] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OperationType]    Script Date: 22.05.2017 13:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OperationType](
	[id] [int] NOT NULL,
	[OperationTypeName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_OperationType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 22.05.2017 13:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] NOT NULL,
	[ProductName] [varchar](500) NOT NULL,
	[idProductType] [int] NOT NULL,
	[idMeasureType] [int] NOT NULL,
	[Size] [numeric](18, 2) NULL,
	[Balance] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 22.05.2017 13:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[id] [int] NOT NULL,
	[ProductCategoryName] [varchar](500) NOT NULL,
 CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductPrice]    Script Date: 22.05.2017 13:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductPrice](
	[id] [int] NOT NULL,
	[idProduct] [int] NOT NULL,
	[Price] [numeric](18, 2) NOT NULL,
	[DateBegin] [date] NOT NULL,
	[DateEnd] [date] NULL,
 CONSTRAINT [PK_ProductPrice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 22.05.2017 13:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductType](
	[id] [int] NOT NULL,
	[ProductTypeName] [varchar](500) NOT NULL,
	[idProductCategory] [int] NULL,
 CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[MeasureType] ([id], [MeasureTypeName], [MeasureTypeSmallName]) VALUES (1, N'штуки', N'шт.')
INSERT [dbo].[MeasureType] ([id], [MeasureTypeName], [MeasureTypeSmallName]) VALUES (2, N'килограмм', N'кг.')
INSERT [dbo].[MeasureType] ([id], [MeasureTypeName], [MeasureTypeSmallName]) VALUES (3, N'грамм', N'г.')
INSERT [dbo].[MeasureType] ([id], [MeasureTypeName], [MeasureTypeSmallName]) VALUES (4, N'миллилитр', N'мл.')
INSERT [dbo].[OperationState] ([id], [OperationStateName]) VALUES (2, N'закрыт')
INSERT [dbo].[OperationState] ([id], [OperationStateName]) VALUES (1, N'открыт')
INSERT [dbo].[OperationState] ([id], [OperationStateName]) VALUES (3, N'отменен')
INSERT [dbo].[OperationType] ([id], [OperationTypeName]) VALUES (1, N'Продажа')
INSERT [dbo].[Product] ([id], [ProductName], [idProductType], [idMeasureType], [Size], [Balance]) VALUES (1, N'Морожение Пингвин', 1, 3, CAST(70.00 AS Numeric(18, 2)), CAST(200.00 AS Numeric(18, 2)))
INSERT [dbo].[Product] ([id], [ProductName], [idProductType], [idMeasureType], [Size], [Balance]) VALUES (2, N'Сок Кола', 2, 4, CAST(500.00 AS Numeric(18, 2)), CAST(144.00 AS Numeric(18, 2)))
INSERT [dbo].[Product] ([id], [ProductName], [idProductType], [idMeasureType], [Size], [Balance]) VALUES (3, N'Сок Кола', 2, 4, CAST(1500.00 AS Numeric(18, 2)), CAST(300.00 AS Numeric(18, 2)))
INSERT [dbo].[Product] ([id], [ProductName], [idProductType], [idMeasureType], [Size], [Balance]) VALUES (4, N'Морожение Пингвин', 1, 3, CAST(270.00 AS Numeric(18, 2)), CAST(245.00 AS Numeric(18, 2)))
INSERT [dbo].[Product] ([id], [ProductName], [idProductType], [idMeasureType], [Size], [Balance]) VALUES (5, N'Мороженое сливочное', 1, 2, NULL, CAST(10.00 AS Numeric(18, 2)))
INSERT [dbo].[ProductCategory] ([id], [ProductCategoryName]) VALUES (1, N'Мороженое')
INSERT [dbo].[ProductCategory] ([id], [ProductCategoryName]) VALUES (2, N'Сок')
INSERT [dbo].[ProductPrice] ([id], [idProduct], [Price], [DateBegin], [DateEnd]) VALUES (1, 1, CAST(20.00 AS Numeric(18, 2)), CAST(N'2016-01-01' AS Date), NULL)
INSERT [dbo].[ProductPrice] ([id], [idProduct], [Price], [DateBegin], [DateEnd]) VALUES (2, 2, CAST(50.00 AS Numeric(18, 2)), CAST(N'2016-01-01' AS Date), NULL)
INSERT [dbo].[ProductPrice] ([id], [idProduct], [Price], [DateBegin], [DateEnd]) VALUES (3, 3, CAST(80.00 AS Numeric(18, 2)), CAST(N'2017-01-01' AS Date), NULL)
INSERT [dbo].[ProductPrice] ([id], [idProduct], [Price], [DateBegin], [DateEnd]) VALUES (4, 4, CAST(100.00 AS Numeric(18, 2)), CAST(N'2017-01-01' AS Date), NULL)
INSERT [dbo].[ProductType] ([id], [ProductTypeName], [idProductCategory]) VALUES (1, N'Мороженое сливочное', 1)
INSERT [dbo].[ProductType] ([id], [ProductTypeName], [idProductCategory]) VALUES (2, N'Сок Кола', 2)
INSERT [dbo].[ProductType] ([id], [ProductTypeName], [idProductCategory]) VALUES (3, N'Бумага', NULL)
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MeasureType]    Script Date: 22.05.2017 13:58:19 ******/
ALTER TABLE [dbo].[MeasureType] ADD  CONSTRAINT [IX_MeasureType] UNIQUE NONCLUSTERED 
(
	[MeasureTypeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MeasureType_1]    Script Date: 22.05.2017 13:58:19 ******/
ALTER TABLE [dbo].[MeasureType] ADD  CONSTRAINT [IX_MeasureType_1] UNIQUE NONCLUSTERED 
(
	[MeasureTypeSmallName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_SaleState]    Script Date: 22.05.2017 13:58:19 ******/
ALTER TABLE [dbo].[OperationState] ADD  CONSTRAINT [IX_SaleState] UNIQUE NONCLUSTERED 
(
	[OperationStateName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_OperationType]    Script Date: 22.05.2017 13:58:19 ******/
ALTER TABLE [dbo].[OperationType] ADD  CONSTRAINT [IX_OperationType] UNIQUE NONCLUSTERED 
(
	[OperationTypeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product]    Script Date: 22.05.2017 13:58:19 ******/
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [IX_Product] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_ProductCategory]    Script Date: 22.05.2017 13:58:19 ******/
ALTER TABLE [dbo].[ProductCategory] ADD  CONSTRAINT [IX_ProductCategory] UNIQUE NONCLUSTERED 
(
	[ProductCategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductPrice]    Script Date: 22.05.2017 13:58:19 ******/
ALTER TABLE [dbo].[ProductPrice] ADD  CONSTRAINT [IX_ProductPrice] UNIQUE NONCLUSTERED 
(
	[idProduct] ASC,
	[DateBegin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductType]    Script Date: 22.05.2017 13:58:19 ******/
ALTER TABLE [dbo].[ProductType] ADD  CONSTRAINT [IX_ProductType] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Operation] ADD  CONSTRAINT [DF_Sale_SaleDateTime]  DEFAULT (getdate()) FOR [OperationDateTime]
GO
ALTER TABLE [dbo].[Operation]  WITH CHECK ADD  CONSTRAINT [FK_Operation_OperationState] FOREIGN KEY([idOperationState])
REFERENCES [dbo].[OperationState] ([id])
GO
ALTER TABLE [dbo].[Operation] CHECK CONSTRAINT [FK_Operation_OperationState]
GO
ALTER TABLE [dbo].[Operation]  WITH CHECK ADD  CONSTRAINT [FK_Sale_OperationType] FOREIGN KEY([idOperationType])
REFERENCES [dbo].[OperationType] ([id])
GO
ALTER TABLE [dbo].[Operation] CHECK CONSTRAINT [FK_Sale_OperationType]
GO
ALTER TABLE [dbo].[OperationContent]  WITH CHECK ADD  CONSTRAINT [FK_OperationContent_Operation] FOREIGN KEY([idOperation])
REFERENCES [dbo].[Operation] ([id])
GO
ALTER TABLE [dbo].[OperationContent] CHECK CONSTRAINT [FK_OperationContent_Operation]
GO
ALTER TABLE [dbo].[OperationContent]  WITH CHECK ADD  CONSTRAINT [FK_OperationContent_ProductPrice] FOREIGN KEY([idProductPrice])
REFERENCES [dbo].[ProductPrice] ([id])
GO
ALTER TABLE [dbo].[OperationContent] CHECK CONSTRAINT [FK_OperationContent_ProductPrice]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_MeasureType] FOREIGN KEY([idMeasureType])
REFERENCES [dbo].[MeasureType] ([id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_MeasureType]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductType] FOREIGN KEY([idProductType])
REFERENCES [dbo].[ProductType] ([id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ProductType]
GO
ALTER TABLE [dbo].[ProductPrice]  WITH CHECK ADD  CONSTRAINT [FK_ProductPrice_Product] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[ProductPrice] CHECK CONSTRAINT [FK_ProductPrice_Product]
GO
ALTER TABLE [dbo].[ProductType]  WITH CHECK ADD  CONSTRAINT [FK_ProductType_ProductCategory] FOREIGN KEY([idProductCategory])
REFERENCES [dbo].[ProductCategory] ([id])
GO
ALTER TABLE [dbo].[ProductType] CHECK CONSTRAINT [FK_ProductType_ProductCategory]
GO
USE [master]
GO
ALTER DATABASE [DBTest] SET  READ_WRITE 
GO
