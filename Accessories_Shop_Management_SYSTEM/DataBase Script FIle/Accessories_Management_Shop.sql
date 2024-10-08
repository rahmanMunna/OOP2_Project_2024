USE [Accessories_Management_Shop]
GO
/****** Object:  Table [dbo].[InvoiceTb]    Script Date: 9/26/2024 12:01:40 PM ******/
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
/****** Object:  Table [dbo].[Product2TB]    Script Date: 9/26/2024 12:01:40 PM ******/
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
/****** Object:  Table [dbo].[TransactionTb]    Script Date: 9/26/2024 12:01:40 PM ******/
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
/****** Object:  Table [dbo].[UserTB]    Script Date: 9/26/2024 12:01:40 PM ******/
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
	[password] [varchar](50) NOT NULL,
	[Role] [varchar](20) NOT NULL,
 CONSTRAINT [PK_UserTB] PRIMARY KEY CLUSTERED 
(
	[SerialNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[InvoiceTb] ON 

INSERT [dbo].[InvoiceTb] ([SerialNo], [InvoiceId], [SalesPerson], [BillStatus], [Total], [Disccount], [NetTotal], [BillDate], [CustomerName], [CustomerPhone], [BillPreparedBy], [PaymentMethode]) VALUES (1, N'Invc-59040-1', N'Maria Rahman', N'Paid', 9000, 1000, 8000, N'2024/9/12', N'Munna', N'01928827372', N'Maria Rahman', N'Card')
INSERT [dbo].[InvoiceTb] ([SerialNo], [InvoiceId], [SalesPerson], [BillStatus], [Total], [Disccount], [NetTotal], [BillDate], [CustomerName], [CustomerPhone], [BillPreparedBy], [PaymentMethode]) VALUES (2, N'Invc-45770-2', N'SaleMan', N'Paid', 200000, 26000, 174000, N'Wednesday, September 25, 2024', N'munna', N'55435353', N'Maria', N'Cash')
INSERT [dbo].[InvoiceTb] ([SerialNo], [InvoiceId], [SalesPerson], [BillStatus], [Total], [Disccount], [NetTotal], [BillDate], [CustomerName], [CustomerPhone], [BillPreparedBy], [PaymentMethode]) VALUES (1002, N'Invc-35077-2', N'Maria Rahman Shoshi', N'Paid', 25000, 3250, 21750, N'Wednesday, September 25, 2024', N'Munna', N'0182839323', N'Maria Rahman Shoshi', N'Cash')
INSERT [dbo].[InvoiceTb] ([SerialNo], [InvoiceId], [SalesPerson], [BillStatus], [Total], [Disccount], [NetTotal], [BillDate], [CustomerName], [CustomerPhone], [BillPreparedBy], [PaymentMethode]) VALUES (1003, N'Invc-4208-1003', N'Maria Rahman Shoshi', N'Paid', 100000, 13000, 87000, N'Wednesday, September 25, 2024', N'munna', N'0192030133', N'Maria Rahman Shoshi', N'Bkash')
INSERT [dbo].[InvoiceTb] ([SerialNo], [InvoiceId], [SalesPerson], [BillStatus], [Total], [Disccount], [NetTotal], [BillDate], [CustomerName], [CustomerPhone], [BillPreparedBy], [PaymentMethode]) VALUES (2002, N'Invc-2661-1004', N'Maria Rahman Shoshi', N'Paid', 50000, 6500, 43500, N'Thursday, September 26, 2024', N'Shoshi', N'01298938933', N'Maria Rahman Shoshi', N'Cash')
INSERT [dbo].[InvoiceTb] ([SerialNo], [InvoiceId], [SalesPerson], [BillStatus], [Total], [Disccount], [NetTotal], [BillDate], [CustomerName], [CustomerPhone], [BillPreparedBy], [PaymentMethode]) VALUES (3002, N'Invc-14285-2003', N'Hasibul Hassan', N'Paid', 156800, 19240, 137560, N'Thursday, September 26, 2024', N'Munna', N'01928374654', N'Hasibul Hassan', N'Cash')
SET IDENTITY_INSERT [dbo].[InvoiceTb] OFF
GO
SET IDENTITY_INSERT [dbo].[Product2TB] ON 

INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (5, N'p-64236-5', N'RAM', N'Kingston', N'FURY Renegade', N'32 GB', N'DDR4-3200 MHz', 4, 20, 5000, 6000, 30, 7000, N'InStock', N'Munna', N'22/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (6, N'p-94413-5', N'Proccessor', N'AMD', N'Ryzen 7 5800X', N'', N'', 3, 17, 23000, 25000, 13, 25000, N'Available', N'Munna', N'24/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (7, N'p-21249-6', N'Proccessor', N'Intel', N'Core i9-13900KF', N'', N'', 3, 11, 72000, 74000, 13, 64380, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (8, N'p-80003-7', N'GPU', N'ASUS', N'ROG Strix GeForce RTX 4090', N'', N'', 3, 7, 50000, 55000, 12, 55000, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 1)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1008, N'p-35352-8', N'Mouse', N'Corsair', N'Glaive RGB', N'', N'', 3, 7, 4000, 4400, 0, 4400, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1009, N'p-24631-9', N'SSD', N'ADATA', N'XPG GAMMIX S5', N'', N'', 2, 12, 7000, 7200, 5, 6840, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1010, N'p-57360-10', N'Motherboard', N'Biostar', N'B450GT3', N'', N'', 3, 8, 12000, 14000, 0, 14000, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1011, N'p-93921-11', N'Proccessor', N'Intel', N'Core i5-12400F', N'', N'', 3, 15, 25000, 27000, 0, 27000, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1012, N'p-45888-12', N'SSD', N'Crucial', N'MX500', N'1 TB', N'', 1, 10, 9000, 9200, 12, 8096, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1013, N'p-75687-13', N'Keyboard', N'Apple', N'Apple Magic Keyboard', N'', N'', 2, 10, 6000, 6300, 5, 5985, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1014, N'p-81072-1013', N'RAM', N'G.Skill', N'Trident Z RGB', N'16 GB', N'DDR4-3200 MHz', 2, 10, 6000, 6200, 0, 6200, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1015, N'p-81117-1014', N'SSD', N'Kingston', N'A2000', N'512 GB', N'', 3, 13, 7000, 7400, 3, 7178, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1016, N'p-19317-1015', N'Keyboard', N'Logitech', N'K800', N'', N'', 2, 8, 2000, 2200, 0, 2200, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1017, N'p-74122-1016', N'Monitor', N'Dell', N'Alienware AW2521H', N'', N'', 2, 14, 20000, 22000, 0, 22000, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1018, N'p-34574-1017', N'GPU', N'Gigabyte', N'AORUS GeForce RTX 4090', N'', N'', 3, 8, 90000, 96000, 0, 96000, N'In Stock', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1019, N'p-21764-1018', N'Keyboard', N'Razer', N'Razer Huntsman', N'', N'', 3, 14, 5000, 5200, 0, 5200, N'UpComming', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1020, N'p-69798-1019', N'RAM', N'Corsair', N'Vengeance RGB Pro', N'16 GB', N'DDR4-3200 MHz', 3, 8, 4000, 4000, 0, 4000, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
INSERT [dbo].[Product2TB] ([SerialNo], [Barcode], [ComponentName], [BrandName], [Model], [Capacity], [Frequency], [Warranty], [Quantity], [buyingPrice], [RegularPrice], [Discount], [UpdatedPrice], [Status], [AddedBy], [AssignDate], [OutOfStockStatus]) VALUES (1021, N'p-28281-1020', N'Monitor', N'Acer', N'XR342CK', N'', N'', 2, 15, 21000, 24000, 10, 21600, N'Available', N'Habibur  Rahman Munna', N'26/09/2024', 0)
SET IDENTITY_INSERT [dbo].[Product2TB] OFF
GO
SET IDENTITY_INSERT [dbo].[TransactionTb] ON 

INSERT [dbo].[TransactionTb] ([TransactionId], [Date], [TotalAmmount], [Type], [ProductName]) VALUES (1, N'9', 100, N'9', N'9')
SET IDENTITY_INSERT [dbo].[TransactionTb] OFF
GO
SET IDENTITY_INSERT [dbo].[UserTB] ON 

INSERT [dbo].[UserTB] ([SerialNo], [UserId], [FirstName], [LastName], [Email], [PhoneNumber], [Nid], [Gender], [Age], [DOB], [JoiningDate], [Salary], [Address], [AssignedBy], [password], [Role]) VALUES (6, N'A-Rahman-6', N'Habibur  Rahman', N'Munna', N'rahman0@gmail.com', N'01604518573', N'1902398902', N'male', 21, N'11/10/2003', N'10/09/2024', 100000, N'Uttara,Dhaka', N'Admin', N'rahmanChanged', N'Admin')
INSERT [dbo].[UserTB] ([SerialNo], [UserId], [FirstName], [LastName], [Email], [PhoneNumber], [Nid], [Gender], [Age], [DOB], [JoiningDate], [Salary], [Address], [AssignedBy], [password], [Role]) VALUES (2003, N'E-Hassan-9', N'Hasibul', N'Hassan', N'hassan@gmail.com', N'010283939292', N'424556342423424', N'Male', 20, N'Wednesday, June 19, 2002', N'Wednesday, September 4, 2024', 50000, N'Gulshan-2,Dhaka', N'Munna', N'1234', N'Employee')
INSERT [dbo].[UserTB] ([SerialNo], [UserId], [FirstName], [LastName], [Email], [PhoneNumber], [Nid], [Gender], [Age], [DOB], [JoiningDate], [Salary], [Address], [AssignedBy], [password], [Role]) VALUES (2007, N'E-Yosuf-10', N'Md', N'Yosuf', N'yousuf@gmail.com', N'01929374754', N'56352424', N'Male', 21, N'Thursday, March 6, 2003', N'Thursday, September 26, 2024', 30000, N'Kuril,Dhaka', N'Munna', N'E-Yosuf@E-Yosuf-10-21P@$$word', N'Employee')
INSERT [dbo].[UserTB] ([SerialNo], [UserId], [FirstName], [LastName], [Email], [PhoneNumber], [Nid], [Gender], [Age], [DOB], [JoiningDate], [Salary], [Address], [AssignedBy], [password], [Role]) VALUES (2008, N'E-Mizan-11', N'MD', N'Mizan', N'mizan@gmail.com', N'01928374922', N'53243535', N'Male', 22, N'Thursday, July 11, 2002', N'Thursday, September 26, 2024', 12000, N'Uttara,Dhaka', N'Habibur  Rahman Munna', N'E-Mizan@E-Mizan-11-22P@$$word', N'Employee')
SET IDENTITY_INSERT [dbo].[UserTB] OFF
GO
