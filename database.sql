USE [CoffeeManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](100) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK__Account__C9F284571973CBF3] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountType]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountType](
	[id] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_AccountType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TableID] [int] NOT NULL,
	[DrinkID] [int] NOT NULL,
	[Counts] [int] NOT NULL,
	[Cashier] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drink]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drink](
	[id] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[idType] [int] NOT NULL,
	[price] [real] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DrinkType]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DrinkType](
	[id] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableList]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableList](
	[id] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Status] [nvarchar](100) NOT NULL,
	[Total] [float] NOT NULL,
 CONSTRAINT [PK_TableList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'1', N'1', N'1', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'duy', N'Lê Mạnh Duy', N'1', 0)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'faker', N'Thánh Nerf', N'1', 0)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'hoang', N'Nguyễn Khoa Hoàng', N'1', 0)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'phuoc', N'Trương Minh Phước', N'1', 0)
GO
INSERT [dbo].[AccountType] ([id], [Name]) VALUES (0, N'Staff')
INSERT [dbo].[AccountType] ([id], [Name]) VALUES (1, N'Admin')
GO
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (1, N'Phin Sữa Đá', 1, 40000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (2, N'Phin Đen Đá', 1, 35000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (3, N'Phin Sữa Nóng', 1, 39000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (4, N'Phin Đen Nóng', 1, 34000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (5, N'Espresso/Americano', 2, 45000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (6, N'Capuchino/Latte', 2, 55000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (7, N'Caramen Machiatlo', 2, 40000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (8, N'Caramel Phin Freeze', 3, 50000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (9, N'Classic Phin Freeze', 3, 66000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (10, N'Freeze Trà Xanh', 3, 57000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (11, N'Freeze Sô-cô-la', 3, 60000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (12, N'Cookies & Cream', 3, 72000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (13, N'Trà Sen Vàng', 5, 55000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (14, N'Trà Thạch Đào', 5, 40000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (15, N'Trà Thanh Đào', 5, 45000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (16, N'Trà Thạch Vải', 5, 55000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (17, N'Trà Xanh Đậu Đỏ', 5, 35000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (18, N'Chanh Đá Xay', 6, 25000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (19, N'Sô-cô-la', 6, 45000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (20, N'Bánh Mì Thịt', 7, 17000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (21, N'Bánh Mì Gà Xé', 7, 25000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (22, N'Bánh Mì Chả Lụa', 7, 20000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (23, N'Bánh Mì Xíu Mại', 7, 15000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (24, N'Trà Sữa Trân Châu', 8, 20000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (25, N'Trà Sữa Oreo', 8, 30000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (26, N'Trà Sữa Kem', 8, 35000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (27, N'Sữa Chua Đá', 9, 15000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (28, N'Sữa Chua Trái Cây', 9, 25000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (29, N'Soda Đào', 10, 20000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (30, N'Soda Dâu', 10, 20000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (31, N'Soda Chanh', 10, 20000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (32, N'Soda Việt Quất', 10, 20000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (33, N'Soda Táo', 10, 20000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (34, N'Gin', 11, 100000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (35, N'Vodka', 11, 80000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (36, N'Bourbon', 11, 90000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (37, N'Cherry', 11, 120000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (38, N'Vermouth', 11, 70000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (39, N'Bò Húc', 4, 15000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (40, N'Number One', 4, 11000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (41, N'Sting Dâu', 4, 9000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (42, N'Sting Vàng', 4, 9000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (43, N'Mountain Dew', 4, 7000)
INSERT [dbo].[Drink] ([id], [Name], [idType], [price]) VALUES (44, N'Monster', 4, 32000)
GO
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (1, N'Cà phê')
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (2, N'Cà Phê Espresso')
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (3, N'Freeze')
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (4, N'Nước Ngọt')
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (5, N'Trà')
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (6, N'Thức Uống Khác')
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (7, N'Đồ Ăn Kèm')
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (8, N'Trà Sữa')
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (9, N'Sữa Chua')
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (10, N'Soda')
INSERT [dbo].[DrinkType] ([id], [Name]) VALUES (11, N'Rượu')
GO
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (1, N'Bàn 1 ', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (2, N'Bàn 2', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (3, N'Bàn 3', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (4, N'Bàn 4', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (5, N'Bàn 5', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (6, N'Bàn 6', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (7, N'Bàn 7', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (8, N'Bàn 8', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (9, N'Bàn 9', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (10, N'Bàn 10', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (11, N'Bàn 11', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (12, N'Bàn 12', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (13, N'Bàn 13', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (14, N'Bàn 14', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (15, N'Bàn 15', N'Empty', 0)
INSERT [dbo].[TableList] ([id], [Name], [Status], [Total]) VALUES (16, N'Bàn 16', N'Empty', 0)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNIQUE_DRINK]    Script Date: 12/24/2020 10:54:37 PM ******/
ALTER TABLE [dbo].[Drink] ADD  CONSTRAINT [UNIQUE_DRINK] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TableName]    Script Date: 12/24/2020 10:54:37 PM ******/
ALTER TABLE [dbo].[TableList] ADD  CONSTRAINT [UK_TableName] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'No Name') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF__Account__PassWor__2F10007B]  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Drink] ADD  DEFAULT (N'No Name') FOR [Name]
GO
ALTER TABLE [dbo].[Drink] ADD  CONSTRAINT [DF__Drink__price__34C8D9D1]  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[DrinkType] ADD  DEFAULT (N'No Name') FOR [Name]
GO
ALTER TABLE [dbo].[TableList] ADD  CONSTRAINT [DF_TableList_Total]  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Type] FOREIGN KEY([Type])
REFERENCES [dbo].[AccountType] ([id])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Type]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Cashier] FOREIGN KEY([Cashier])
REFERENCES [dbo].[Account] ([UserName])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Cashier]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_DrinkID] FOREIGN KEY([DrinkID])
REFERENCES [dbo].[Drink] ([id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_DrinkID]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_TableID] FOREIGN KEY([TableID])
REFERENCES [dbo].[TableList] ([id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_TableID]
GO
ALTER TABLE [dbo].[Drink]  WITH CHECK ADD FOREIGN KEY([idType])
REFERENCES [dbo].[DrinkType] ([id])
GO
/****** Object:  StoredProcedure [dbo].[AddDrinkToBill]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddDrinkToBill]
	@TableName nvarchar(100)
	,@DrinkName nvarchar(100)
	,@Counts int
	,@CashierDN nvarchar(100)
AS
BEGIN
	DECLARE @TableID int,
			@DrinkID int,
			@CashierUN nvarchar(100)
	SELECT @TableID=id FROM TableList
	WHERE @TableName=Name
	SELECT @DrinkID=id FROM Drink
	WHERE @DrinkName=Name
	SELECT @CashierUN=UserName FROM Account
	WHERE @CashierDN=DisplayName

	INSERT INTO Bill(TableID,DrinkID,Counts,Cashier) 
	VALUES (@TableID, @DrinkID, @Counts,@CashierUN);
END

GO
/****** Object:  StoredProcedure [dbo].[CheckDrinkTable]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckDrinkTable]
	@TableName nvarchar(100)
	,@DrinkName nvarchar(100)
AS
BEGIN
	DECLARE @TableID int,
			@DrinkID int
	SELECT @TableID=id FROM TableList
	WHERE @TableName=Name
	SELECT @DrinkID=id FROM Drink
	WHERE @DrinkName=Name

	SELECT Counts FROM Bill 
	WHERE TableID=@TableID AND DrinkID=@DrinkID
END

GO
/****** Object:  StoredProcedure [dbo].[ClearBill]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ClearBill]
	@TableName nvarchar(100)
AS
BEGIN
	DECLARE @TableID int
	SELECT @TableID=id FROM TableList
	WHERE @TableName=Name
	
	DELETE FROM Bill 
	WHERE TableID = @TableID
END

GO
/****** Object:  StoredProcedure [dbo].[ClearTable]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ClearTable]
	@TableName nvarchar(100)
AS
BEGIN
	UPDATE TableList 
	SET 
		Status = N'Empty', 
		Total = 0 
	WHERE Name = @TableName
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteAccount]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteAccount]
	@UserName nvarchar(100)
AS
BEGIN
	DELETE FROM Account
    WHERE UserName = @UserName
END

		

GO
/****** Object:  StoredProcedure [dbo].[DeleteDrink]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteDrink]
	@id int
AS
BEGIN
	DELETE FROM Drink
    WHERE id = @id
END

		

		

GO
/****** Object:  StoredProcedure [dbo].[DeleteDrinkType]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteDrinkType]
	@id int
AS
BEGIN
	DELETE FROM DrinkType
    WHERE id = @id
END


		

GO
/****** Object:  StoredProcedure [dbo].[DeleteTable]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteTable]
	@id int
AS
BEGIN
	DELETE FROM TableList
    WHERE id = @id
END

		

		

GO
/****** Object:  StoredProcedure [dbo].[GetAccount]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAccount]
AS
BEGIN	
	SELECT UserName,DisplayName,PassWord,Name AS 'Type'
	FROM Account
	INNER JOIN AccountType ON Type=id	
END

		

GO
/****** Object:  StoredProcedure [dbo].[GetBillByTable]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBillByTable]
	@TableName nvarchar(100)
AS
BEGIN
	DECLARE @TableID int
	SELECT @TableID=id
	FROM TableList 
	WHERE @TableName=Name

	SELECT TableList.Name AS 'TableName',Drink.Name AS 'DrinkName',Counts,Account.DisplayName AS 'Cashier'
	FROM Bill
	INNER JOIN TableList ON TableList.id=Bill.TableID
	INNER JOIN Drink ON Drink.id=Bill.DrinkID	
	INNER JOIN Account ON Account.UserName=Bill.Cashier
	WHERE Bill.TableID=@TableID
END

		

GO
/****** Object:  StoredProcedure [dbo].[GetDrink]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDrink]
AS
BEGIN
	SELECT Drink.id,Drink.Name,DrinkType.Name AS 'Type',price
	FROM Drink 
	INNER JOIN DrinkType 
	ON Drink.idType=DrinkType.id
END

		

GO
/****** Object:  StoredProcedure [dbo].[GetDrinkType]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDrinkType]
AS
BEGIN
	SELECT * FROM DrinkType
END

		


		

GO
/****** Object:  StoredProcedure [dbo].[GetTable]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTable]
AS
BEGIN	
	SELECT * FROM TableList
END


		

GO
/****** Object:  StoredProcedure [dbo].[IncreaseDrink]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IncreaseDrink]
	@TableName nvarchar(100)
	,@DrinkName nvarchar(100)
	,@Counts int
AS
BEGIN
DECLARE @TableID int,
		@DrinkID int
	SELECT @TableID=id FROM TableList
	WHERE @TableName=Name
	SELECT @DrinkID=id FROM Drink
	WHERE @DrinkName=Name
	
	UPDATE BILL 
	SET 
		Counts += @Counts 
		WHERE TableID = @TableID AND DrinkID = @DrinkID
END

GO
/****** Object:  StoredProcedure [dbo].[InsertAccount]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertAccount]
	@UserName nvarchar(100),
	@DisplayName nvarchar(100),
	@PassWord nvarchar(100),
	@Type nvarchar(100)
AS
BEGIN
	DECLARE @idType int
	SELECT @idType=id FROM AccountType
	WHERE @Type=Name

	INSERT INTO  Account ( UserName, DisplayName, PassWord, Type )  
    VALUES ( @UserName , @DisplayName , @PassWord , @idType )
END

		

GO
/****** Object:  StoredProcedure [dbo].[InsertDrink]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertDrink]
	@id int,
	@Name nvarchar(100),
	@Type nvarchar(100),	
	@Price real
AS
BEGIN
	DECLARE @idType int
	SELECT @idType=id
	FROM DrinkType 
	WHERE @Type=Name	
	
	INSERT INTO  Drink ( id, Name, idType, Price )  
    VALUES ( @id , @Name , @idType , @Price )
END


		

GO
/****** Object:  StoredProcedure [dbo].[InsertDrinkType]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertDrinkType]
	@id int,
	@Name nvarchar(100)
AS
BEGIN
	INSERT INTO  DrinkType ( id, Name)  
    VALUES ( @id , @Name)
END




		

GO
/****** Object:  StoredProcedure [dbo].[InsertTable]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertTable]
	@id int,
	@Name nvarchar(100),
	@Status nvarchar(100)
AS
BEGIN
	INSERT INTO TableList ( id, Name, Status )  
    VALUES ( @id , @Name , @Status )
END

		

GO
/****** Object:  StoredProcedure [dbo].[MoveTable]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MoveTable]
	@TableNameFrom nvarchar(100)
	,@TableNameTo nvarchar(100)
	,@Total float
AS
BEGIN
	UPDATE TableList 
	SET Status = N'Online', Total = @Total 
	WHERE Name = @TableNameTo
	
	UPDATE TableList 
	SET Status = N'Empty', Total = 0 
	WHERE Name = @TableNameFrom 
END



GO
/****** Object:  StoredProcedure [dbo].[SEARCHDRINK]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SEARCHDRINK]
	@DrinkName nvarchar(100)
AS
BEGIN
	SELECT Drink.id, Drink.Name, DrinkType.Name AS 'Type', price
	FROM Drink 
	INNER JOIN DrinkType 
	ON Drink.idType = DrinkType.id
	WHERE Drink.Name LIKE @DrinkName + '%'
END

		

GO
/****** Object:  StoredProcedure [dbo].[SetTableOnline]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SetTableOnline]
	@TableName nvarchar(100)
AS
BEGIN
	UPDATE TableList
		SET Status = N'Online'
		WHERE Name=@TableName
END

		

GO
/****** Object:  StoredProcedure [dbo].[SetTotal]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SetTotal]
	@TableName nvarchar(100)
	,@Total float
AS
BEGIN
	UPDATE TableList
	SET 
		Total += @Total 
	WHERE Name = @TableName
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateAccount]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateAccount]
	@UserName nvarchar(100),
	@DisplayName nvarchar(100),
	@PassWord nvarchar(100),
	@Type nvarchar(100),
	@oldUserName nvarchar(100)
AS
BEGIN
	DECLARE @idType int
	SELECT @idType=id FROM AccountType
	WHERE @Type=Name

	UPDATE Account
    SET
   		UserName = @UserName,
        DisplayName = @DisplayName,
        PassWord = @PassWord,
        Type = @idType
        WHERE UserName = @oldUserName
END

		

GO
/****** Object:  StoredProcedure [dbo].[UpdateDrink]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDrink]
	@id int,
	@Name nvarchar(100),
	@Type nvarchar(100),	
	@Price real,
	@oldID int
AS
BEGIN
	DECLARE @idType int
	SELECT @idType=id
	FROM DrinkType 
	WHERE @Type=Name	
	
	UPDATE Drink
    SET
   		id = @id,
        Name = @Name,
        idType = @idType,
        price = @Price
        WHERE id = @oldID
END


		

GO
/****** Object:  StoredProcedure [dbo].[UpdateDrinkType]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDrinkType]
	@id int,
	@Name nvarchar(100),
	@oldID int
AS
BEGIN
	UPDATE DrinkType
    SET
   		id = @id,
        Name = @Name
        WHERE id = @oldID
END



		

GO
/****** Object:  StoredProcedure [dbo].[UpdateTable]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateTable]
	@id int,
	@Name nvarchar(100),
	@Status nvarchar(100),
	@oldID int
AS
BEGIN
	UPDATE TableList
    SET
   		id = @id,
        Name = @Name,
        Status = @Status
        WHERE id = @oldID
END


		

GO
/****** Object:  StoredProcedure [dbo].[UpdateTableInBill]    Script Date: 12/24/2020 10:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateTableInBill]
	@TableNameFrom nvarchar(100),
	@TableNameTo nvarchar(100)
AS
BEGIN
	DECLARE @TableIDFrom int,
			@TableIDTo int
			
	SELECT @TableIDFrom=id FROM TableList
	WHERE @TableNameFrom=Name
	
	SELECT @TableIDTo=id FROM TableList
	WHERE @TableNameTo=Name
	
	UPDATE Bill
	SET
		TableID=@TableIDTo
	WHERE TableID=@TableIDFrom
END

GO
