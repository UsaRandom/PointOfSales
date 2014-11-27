CREATE DATABASE PosData
GO
USE [PosData]
GO
CREATE LOGIN [PosUser] WITH PASSWORD = 'pospass';
GO
USE master
GRANT CONTROL SERVER TO PosUser
GO
Use [PosData]
GO
/****** Object:  User [PosUser]    Script Date: 12/16/2008 16:29:00 ******/
CREATE USER [PosUser] FOR LOGIN [PosUser] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 12/16/2008 16:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[Stock Number] [int] NOT NULL,
	[Item Name] [ntext] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Cost] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Discontinued] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Stock Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Inventory] ([Stock Number], [Item Name], [Quantity], [Cost], [Price], [Discontinued]) VALUES (1, N'Milk', 20, 150, 200, 0)
INSERT [dbo].[Inventory] ([Stock Number], [Item Name], [Quantity], [Cost], [Price], [Discontinued]) VALUES (2, N'Bread', 15, 095., 150, 0)
INSERT [dbo].[Inventory] ([Stock Number], [Item Name], [Quantity], [Cost], [Price], [Discontinued]) VALUES (3, N'Steak', 17, 595., 850, 0)
INSERT [dbo].[Inventory] ([Stock Number], [Item Name], [Quantity], [Cost], [Price], [Discontinued]) VALUES (4, N'Dog food', 5, 1500, 1995, 0)
INSERT [dbo].[Inventory] ([Stock Number], [Item Name], [Quantity], [Cost], [Price], [Discontinued]) VALUES (5, N'Apples', 100, 15, 25, 0)
INSERT [dbo].[Inventory] ([Stock Number], [Item Name], [Quantity], [Cost], [Price], [Discontinued]) VALUES (6, N'Snickers', 16, 35, 55, 0)
INSERT [dbo].[Inventory] ([Stock Number], [Item Name], [Quantity], [Cost], [Price], [Discontinued]) VALUES (7, N'Butter', 6, 195, 295, 0)
INSERT [dbo].[Inventory] ([Stock Number], [Item Name], [Quantity], [Cost], [Price], [Discontinued]) VALUES (8, N'Tomato', 18, 35, 45, 0)
INSERT [dbo].[Inventory] ([Stock Number], [Item Name], [Quantity], [Cost], [Price], [Discontinued]) VALUES (9, N'Yogurt', 22, 22, 33, 0)
INSERT [dbo].[Inventory] ([Stock Number], [Item Name], [Quantity], [Cost], [Price], [Discontinued]) VALUES (10, N'Chicken', 12, 69, 99, 0)
