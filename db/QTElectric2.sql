USE [QTElectric]
GO
/****** Object:  Table [dbo].[tbl_category]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_category](
	[cat_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_name] [nvarchar](50) NOT NULL,
	[status] [bit] NULL,
	[date_ceate] [datetime] NULL,
 CONSTRAINT [PK_tbl_category] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_customer]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_customer](
	[cus_id] [int] IDENTITY(1,1) NOT NULL,
	[fullName] [nvarchar](50) NOT NULL,
	[mobile] [nchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[address] [nvarchar](250) NULL,
	[gender] [bit] NULL,
	[status] [bit] NULL,
	[date_create] [datetime] NULL,
 CONSTRAINT [PK_tbl_customer] PRIMARY KEY CLUSTERED 
(
	[cus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_differenced]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_differenced](
	[diff_id] [int] IDENTITY(1,1) NOT NULL,
	[diff_name] [varchar](3) NOT NULL,
	[val_id] [int] NOT NULL,
	[status] [bit] NULL,
	[date_create] [datetime] NULL,
 CONSTRAINT [PK_tbl_differenced] PRIMARY KEY CLUSTERED 
(
	[diff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_order]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_order](
	[or_id] [int] IDENTITY(1,1) NOT NULL,
	[cus_id] [int] NOT NULL,
	[or_name] [nvarchar](100) NOT NULL,
	[status] [bit] NULL,
	[date_create] [datetime] NULL,
 CONSTRAINT [PK_tbl_order] PRIMARY KEY CLUSTERED 
(
	[or_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_orderDetail]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_orderDetail](
	[or_detail_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[pro_id] [int] NOT NULL,
	[type_id] [int] NOT NULL,
	[amount_in] [int] NOT NULL,
	[amount_out] [int] NOT NULL,
	[status] [bit] NULL,
	[date_create] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_product]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_product](
	[pro_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_id] [int] NOT NULL,
	[type_id] [int] NOT NULL,
	[val_id] [int] NOT NULL,
	[diff_id] [int] NOT NULL,
	[status] [bit] NULL,
	[date_create] [datetime] NULL,
 CONSTRAINT [PK_tbl_dproduct] PRIMARY KEY CLUSTERED 
(
	[pro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_types]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_types](
	[type_id] [int] IDENTITY(1,1) NOT NULL,
	[type_name] [nvarchar](50) NOT NULL,
	[cat_id] [int] NOT NULL,
	[status] [bit] NULL,
	[date_create] [datetime] NULL,
 CONSTRAINT [PK_tbl_types] PRIMARY KEY CLUSTERED 
(
	[type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[u_id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](10) NOT NULL,
	[password] [char](32) NOT NULL,
	[mobile] [char](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[gender] [bit] NULL,
	[full_name] [nvarchar](50) NOT NULL,
	[status] [bit] NULL,
	[date_create] [datetime] NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[u_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[values]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[values](
	[val_id] [int] IDENTITY(1,1) NOT NULL,
	[val_name] [nvarchar](50) NOT NULL,
	[type_id] [int] NOT NULL,
	[status] [bit] NULL,
	[date_create] [datetime] NULL,
 CONSTRAINT [PK_values] PRIMARY KEY CLUSTERED 
(
	[val_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_category] ADD  CONSTRAINT [DF_tbl_category_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[tbl_customer] ADD  CONSTRAINT [DF_tbl_customer_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[tbl_differenced] ADD  CONSTRAINT [DF_tbl_differenced_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[tbl_order] ADD  CONSTRAINT [DF_tbl_order_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[tbl_types] ADD  CONSTRAINT [DF_tbl_types_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[tbl_user] ADD  CONSTRAINT [DF_tbl_user_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[values] ADD  CONSTRAINT [DF_values_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[tbl_differenced]  WITH CHECK ADD  CONSTRAINT [FK_tbl_differenced_values] FOREIGN KEY([val_id])
REFERENCES [dbo].[values] ([val_id])
GO
ALTER TABLE [dbo].[tbl_differenced] CHECK CONSTRAINT [FK_tbl_differenced_values]
GO
ALTER TABLE [dbo].[tbl_order]  WITH CHECK ADD  CONSTRAINT [FK_tbl_order_tbl_customer] FOREIGN KEY([cus_id])
REFERENCES [dbo].[tbl_customer] ([cus_id])
GO
ALTER TABLE [dbo].[tbl_order] CHECK CONSTRAINT [FK_tbl_order_tbl_customer]
GO
ALTER TABLE [dbo].[tbl_orderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_orderDetail_tbl_order] FOREIGN KEY([order_id])
REFERENCES [dbo].[tbl_order] ([or_id])
GO
ALTER TABLE [dbo].[tbl_orderDetail] CHECK CONSTRAINT [FK_tbl_orderDetail_tbl_order]
GO
ALTER TABLE [dbo].[tbl_orderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_orderDetail_tbl_product] FOREIGN KEY([pro_id])
REFERENCES [dbo].[tbl_product] ([pro_id])
GO
ALTER TABLE [dbo].[tbl_orderDetail] CHECK CONSTRAINT [FK_tbl_orderDetail_tbl_product]
GO
ALTER TABLE [dbo].[tbl_orderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_orderDetail_tbl_types] FOREIGN KEY([type_id])
REFERENCES [dbo].[tbl_types] ([type_id])
GO
ALTER TABLE [dbo].[tbl_orderDetail] CHECK CONSTRAINT [FK_tbl_orderDetail_tbl_types]
GO
ALTER TABLE [dbo].[tbl_product]  WITH CHECK ADD  CONSTRAINT [FK_tbl_product_tbl_category] FOREIGN KEY([cat_id])
REFERENCES [dbo].[tbl_category] ([cat_id])
GO
ALTER TABLE [dbo].[tbl_product] CHECK CONSTRAINT [FK_tbl_product_tbl_category]
GO
ALTER TABLE [dbo].[tbl_product]  WITH CHECK ADD  CONSTRAINT [FK_tbl_product_tbl_differenced] FOREIGN KEY([diff_id])
REFERENCES [dbo].[tbl_differenced] ([diff_id])
GO
ALTER TABLE [dbo].[tbl_product] CHECK CONSTRAINT [FK_tbl_product_tbl_differenced]
GO
ALTER TABLE [dbo].[tbl_product]  WITH CHECK ADD  CONSTRAINT [FK_tbl_product_tbl_types] FOREIGN KEY([type_id])
REFERENCES [dbo].[tbl_types] ([type_id])
GO
ALTER TABLE [dbo].[tbl_product] CHECK CONSTRAINT [FK_tbl_product_tbl_types]
GO
ALTER TABLE [dbo].[tbl_product]  WITH CHECK ADD  CONSTRAINT [FK_tbl_product_values] FOREIGN KEY([val_id])
REFERENCES [dbo].[values] ([val_id])
GO
ALTER TABLE [dbo].[tbl_product] CHECK CONSTRAINT [FK_tbl_product_values]
GO
ALTER TABLE [dbo].[tbl_types]  WITH CHECK ADD  CONSTRAINT [FK_tbl_types_tbl_category] FOREIGN KEY([cat_id])
REFERENCES [dbo].[tbl_category] ([cat_id])
GO
ALTER TABLE [dbo].[tbl_types] CHECK CONSTRAINT [FK_tbl_types_tbl_category]
GO
ALTER TABLE [dbo].[values]  WITH CHECK ADD  CONSTRAINT [FK_values_tbl_types] FOREIGN KEY([type_id])
REFERENCES [dbo].[tbl_types] ([type_id])
GO
ALTER TABLE [dbo].[values] CHECK CONSTRAINT [FK_values_tbl_types]
GO
/****** Object:  StoredProcedure [dbo].[CheckPass]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CheckPass](@user_name varchar(10), @password char(32))
AS
BEGIN
SELECT * FROM tbl_user WHERE user_name = @user_name AND password = @password
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Category]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Category](@id int)
AS
BEGIN
DELETE FROM tbl_category WHERE cat_id = @id
DELETE FROM tbl_product WHERE cat_id = @id
DELETE FROM tbl_types WHERE cat_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Customer]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Customer](@id int)
AS
BEGIN
DELETE FROM tbl_customer WHERE cus_id = @id
DELETE FROM tbl_order WHERE cus_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Differenced]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Differenced](@id int)
AS
BEGIN
DELETE FROM tbl_differenced WHERE diff_id = @id;
DELETE FROM tbl_product WHERE diff_id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Order]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Order](@id int)
AS
BEGIN
DELETE FROM tbl_order WHERE or_id = @id
DELETE FROM tbl_orderDetail WHERE order_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_OrderDetail]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_OrderDetail](@id int)
AS
BEGIN
DELETE FROM tbl_orderDetail WHERE or_detail_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Product]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Product](@id int)
AS
BEGIN
DELETE FROM tbl_product WHERE pro_id = @id
DELETE FROM tbl_orderDetail WHERE pro_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Types]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Types](@id int)
AS
BEGIN
DELETE FROM tbl_types WHERE type_id = @id
DELETE FROM tbl_orderDetail WHERE type_id = @id
DELETE FROM tbl_product WHERE type_id = @id
DELETE FROM [values] WHERE type_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_User]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_User](@id int)
AS
BEGIN
DELETE FROM tbl_user WHERE u_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Values]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Values](@id int)
AS
BEGIN
DELETE FROM tbl_differenced WHERE val_id = @id
DELETE FROM tbl_product WHERE val_id = @id
DELETE FROM [values] WHERE val_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Get_Category]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_Category]
AS
BEGIN
SELECT * FROM tbl_category
END
GO
/****** Object:  StoredProcedure [dbo].[Get_Customer]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_Customer]
AS
BEGIN
SELECT * FROM tbl_customer
END
GO
/****** Object:  StoredProcedure [dbo].[Get_Differenced]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_Differenced]
AS
BEGIN
SELECT * FROM tbl_differenced
END
GO
/****** Object:  StoredProcedure [dbo].[Get_Order]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_Order]
AS
BEGIN
SELECT * FROM tbl_order
END
GO
/****** Object:  StoredProcedure [dbo].[Get_OrderDetail]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Get_OrderDetail]
AS
BEGIN
SELECT * FROM tbl_orderDetail
END
GO
/****** Object:  StoredProcedure [dbo].[Get_Types]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_Types]
AS
BEGIN
SELECT * FROM tbl_types
END
GO
/****** Object:  StoredProcedure [dbo].[Get_User]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_User]
AS
BEGIN
SELECT * FROM tbl_user
END
GO
/****** Object:  StoredProcedure [dbo].[Get_Values]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_Values]
AS
BEGIN
SELECT * FROM [values]
END
GO
/****** Object:  StoredProcedure [dbo].[GetByValues]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetByValues]
AS
BEGIN
SELECT v.val_name, t.type_name, c.cat_name, d.diff_name From [values] as v INNER JOIN tbl_types as t  ON v.val_id = t.type_id INNER JOIN tbl_category as c ON t.cat_id = c.cat_id INNER JOIN tbl_differenced as d ON v.val_id = d.val_id
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Category]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Category](@cat_name nvarchar(50), @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_category(cat_name, status, date_ceate) VALUES (@cat_name, @status, @date_create)
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Customer]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Customer](@fullname nvarchar(50), @mobile nchar(10), @email varchar(50), @address nvarchar(250), @gender bit, @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_customer(fullName, mobile, email,[address], gender, [status], date_create) VALUES (@fullname, @mobile, @email, @address, @gender, @status, @date_create) 
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Differenced]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Differenced](@diff_name varchar(3), @val_id int, @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_differenced(diff_name, val_id, status, date_create) VALUES (@diff_name, @val_id, @status, @date_create)
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Order]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Order](@cus_id int, @or_name nvarchar(100), @status bit, @date_create datetime )
AS
BEGIN
INSERT INTO tbl_order(cus_id, or_name, status, date_create) VALUES (@cus_id, @or_name, @status, @date_create)
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_OrderDetail]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_OrderDetail](@order_id int, @pro_id int, @type_id int, @value_id int, @amount_in int, @amount_out int, @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_orderDetail(order_id, pro_id, type_id, amount_in, amount_out, status, date_create) VALUES (@order_id, @pro_id, @type_id,  @amount_in, @amount_out, @status, @date_create)
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Product]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Product](@cat_id int, @type_id int, @val_id int, @diff_id int, @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_product(cat_id, [type_id], val_id, diff_id, [status], date_create) VALUES (@cat_id , @type_id , @val_id , @diff_id , @status , @date_create)
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Types]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Types](@type_name nvarchar(50), @cat_id int, @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_types([type_name] , cat_id, [status], date_create) VALUES (@type_name, @cat_id, @status, @date_create)
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_User]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_User](@user_name varchar(10),	@password char(32),	@mobile char(10),@email varchar(50),@gender bit,@full_name nvarchar(50),@status bit,@date_create datetime)
AS
BEGIN
INSERT INTO tbl_user(user_name, password, mobile, email, gender, full_name, status, date_create) VALUES (@user_name ,	@password ,	@mobile ,@email ,@gender ,@full_name ,@status ,@date_create )
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Values]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Values](@val_name varchar(10),@type_id int,@status bit,@date_create datetime)
AS
BEGIN
INSERT INTO [values](val_name, type_id,  status, date_create) VALUES (@val_name,@type_id ,@status ,@date_create )
END
GO
/****** Object:  StoredProcedure [dbo].[Select_Product]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Select_Product]
AS
BEGIN
SELECT * FROM tbl_product
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Category]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Category](@id int, @cat_name nvarchar(50), @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_category
SET cat_name = @cat_name, status = @status, date_ceate = @date_create
WHERE cat_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Customer]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Customer](@id int, @fullname nvarchar(50), @mobile nchar(10), @email varchar(50), @address nvarchar(250), @gender bit, @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_customer
SET fullName = @fullname, mobile = @mobile, email = @email, address = @address, gender = @gender, [status] = @status, date_create = @date_create
WHERE cus_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Differenced]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Differenced](@id int,@diff_name varchar(3), @val_id int, @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_differenced
SET diff_name = @diff_name, val_id = @val_id, [status] = @status, date_create = @date_create
WHERE diff_id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Order]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Order](@id int, @cus_id int, @or_name nvarchar(100), @status bit, @date_create datetime )
AS
BEGIN
UPDATE tbl_order
SET cus_id = @cus_id, or_name = @or_name, status = @status, date_create = @date_create
WHERE or_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Update_OrderDetail]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_OrderDetail](@id int, @order_id int, @pro_id int, @type_id int,  @amount_in int, @amount_out int, @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_orderDetail
SET order_id = @order_id, pro_id = @pro_id, type_id = @type_id, amount_in = @amount_in, amount_out = @amount_out, status = @status, date_create = @date_create
WHERE or_detail_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Product]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Product](@id int , @cat_id int, @type_id int, @val_id int, @diff_id int, @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_product
SET cat_id = @cat_id, type_id = @type_id, val_id = @val_id, diff_id = @diff_id, status = @status, date_create = @date_create
WHERE pro_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Types]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Types](@id int,@type_name nvarchar(50), @cat_id int, @status bit, @date_create datetime )
AS
BEGIN
UPDATE tbl_types
SET type_name = @type_name, cat_id = @cat_id, [status] = @status, date_create = @date_create
WHERE type_id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[Update_User]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_User](@id int ,@user_name varchar(10),	@password char(32),	@mobile char(10),@email nvarchar(50),@gender bit,@full_name nvarchar(50),@status bit,@date_create datetime)
AS
BEGIN
UPDATE tbl_user
SET [user_name] = @user_name, [password] = @password, mobile = @mobile, email = @email, gender = @gender, full_name = @full_name, [status] = @status, date_create = @date_create
WHERE u_id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Values]    Script Date: 4/1/2021 11:08:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Values](@id int,@val_name nvarchar, @type_id int , @status bit, @date_create datetime)
AS
BEGIN
UPDATE [values]
SET val_name = @val_name,[type_id] = @type_id, [status] = @status, date_create = @date_create
WHERE val_id = @id
END
GO
