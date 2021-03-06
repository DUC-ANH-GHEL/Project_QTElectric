USE [QTElectric]
GO
/****** Object:  Table [dbo].[tbl_category]    Script Date: 4/8/2021 8:23:09 AM ******/
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
/****** Object:  Table [dbo].[tbl_customer]    Script Date: 4/8/2021 8:23:09 AM ******/
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
/****** Object:  Table [dbo].[tbl_differenced]    Script Date: 4/8/2021 8:23:09 AM ******/
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
/****** Object:  Table [dbo].[tbl_order]    Script Date: 4/8/2021 8:23:09 AM ******/
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
/****** Object:  Table [dbo].[tbl_orderDetail]    Script Date: 4/8/2021 8:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_orderDetail](
	[or_detail_id] [varchar](max) NOT NULL,
	[order_id] [int] NOT NULL,
	[pro_id] [int] NOT NULL,
	[amount_in] [int] NOT NULL,
	[amount_out] [int] NOT NULL,
	[status] [bit] NULL,
	[date_create] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_product]    Script Date: 4/8/2021 8:23:09 AM ******/
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
	[qrname] [varchar](50) NOT NULL,
	[status] [bit] NULL,
	[date_create] [datetime] NULL,
 CONSTRAINT [PK_tbl_dproduct] PRIMARY KEY CLUSTERED 
(
	[pro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_types]    Script Date: 4/8/2021 8:23:09 AM ******/
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
/****** Object:  Table [dbo].[tbl_user]    Script Date: 4/8/2021 8:23:09 AM ******/
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
/****** Object:  Table [dbo].[values]    Script Date: 4/8/2021 8:23:09 AM ******/
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
