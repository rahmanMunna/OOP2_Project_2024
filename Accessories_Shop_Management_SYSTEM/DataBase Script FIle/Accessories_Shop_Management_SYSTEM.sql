USE [Accessories_Management_Shop]
GO
/****** Object:  Table [dbo].[InvoiceTb]    Script Date: 9/22/2024 1:45:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceTb](
	[SerialNo] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [varchar](50) NOT NULL,
	[SalesPerson] [varchar](50) NOT NULL,
	[BillStatus] [varchar](50) NOT NULL,
	[Total] [int] NOT NULL,
	[Disccount] [int] NOT NULL,
	[NetTotal] [int] NOT NULL,
	[BillDate] [varchar](50) NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[CustomerPhone] [varchar](15) NOT NULL,
	[BillPreparedBy] [varchar](50) NOT NULL,
	[PaymentMethode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_InvoiceTb] PRIMARY KEY CLUSTERED 
(
	[SerialNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product2TB]    Script Date: 9/22/2024 1:45:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product2TB](
	[SerialNo] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [varchar](50) NULL,
	[ComponentName] [varchar](50) NOT NULL,
	[BrandName] [varchar](50) NOT NULL,
	[Model] [varchar](50) NOT NULL,
	[Capacity] [varchar](50) NULL,
	[Frequency] [varchar](50) NULL,
	[Warranty] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[buyingPrice] [int] NOT NULL,
	[RegularPrice] [int] NOT NULL,
	[Discount] [int] NOT NULL,
	[UpdatedPrice] [int] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[AddedBy] [varchar](50) NOT NULL,
	[AssignDate] [varchar](50) NOT NULL,
	[OutOfStockStatus] [int] NOT NULL,
 CONSTRAINT [PK_Product2TB] PRIMARY KEY CLUSTERED 
(
	[SerialNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionTb]    Script Date: 9/22/2024 1:45:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionTb](
	[TransactionId] [int] IDENTITY(1,1) NOT NULL,
	[Date] [varchar](50) NOT NULL,
	[TotalAmmount] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[ProductName] [varchar](200) NOT NULL,
 CONSTRAINT [PK_TransactionTb] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTB]    Script Date: 9/22/2024 1:45:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTB](
	[SerialNo] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[Nid] [varchar](15) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[Age] [int] NOT NULL,
	[DOB] [varchar](50) NOT NULL,
	[JoiningDate] [varchar](50) NOT NULL,
	[Salary] [int] NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[AssignedBy] [varchar](50) NOT NULL,
	[UpdatePasswordRequestStatus] [int] NOT NULL,
	[password] [varchar](20) NOT NULL,
	[Role] [varchar](20) NOT NULL,
 CONSTRAINT [PK_UserTB] PRIMARY KEY CLUSTERED 
(
	[SerialNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product2TB] ON 

INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1, N'p-41134-1', N'Keyboard', N'Apple', N'Apple Magic Keyboard', N'', N'', 3, 10, 14000, 15500, 5, 14725, N'Available', N'Munna', N'22/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (2, N'p-27944-2', N'Proccessor', N'AMD', N'Ryzen 7 5700G', N'', N'', 5, 20, 17000, 20000, 0, 20000, N'Available', N'Munna', N'22/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (3, N'p-82976-3', N'Proccessor', N'Intel', N'Core i5-12600KF', N'', N'', 4, 10, 23000, 25000, 15, 21250, N'Upcomming', N'Munna', N'22/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (4, N'p-28950-4', N'Motherboard', N'MSI', N'MAG B550M MORTAR', N'', N'', 5, 4, 18000, 20000, 10, 18000, N'Available', N'Munna', N'22/09/2024', 1)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (5, N'p-64236-5', N'RAM', N'Kingston', N'FURY Renegade', N'32 GB', N'DDR4-3200 MHz', 3, 15, 5000, 5500, 10, 4950, N'Available', N'Munna', N'22/09/2024', 0)
SET IDENTITY_INSERT [dbo].[Product2TB] OFF
GO
SET IDENTITY_INSERT [dbo].[TransactionTb] ON 

INSERT [dbo].[TransactionTb] ([TransactionId], [Date], [TotalAmmount], [Type], [ProductName]) VALUES (1, N'9', 100, N'9', N'9')
SET IDENTITY_INSERT [dbo].[TransactionTb] OFF
GO
SET IDENTITY_INSERT [dbo].[UserTB] ON 

INSERT [dbo].[UserTB] ([SerialNo], [UserId], [FirstName], [LastName], [Email], [PhoneNumber], [Nid], [Gender], [Age], [DOB], [JoiningDate], [Salary], [Address], [AssignedBy], [UpdatePasswordRequestStatus], [password], [Role]) VALUES (6, N'Admin-Rahman-1', N'Habibur  Rahman', N'Munna', N'rahman0@gmail.com', N'01604518573', N'1902398902', N'male', 21, N'11/10/2003', N'10/09/2024', 100000, N'Uttara,Dhaka', N'Admin', 0, N'rahmanP@$$word', N'Admin')
SET IDENTITY_INSERT [dbo].[UserTB] OFF
GO
