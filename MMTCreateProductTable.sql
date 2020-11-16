USE [MMTShop]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 16/11/2020 10:01:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[SKU] [int] NOT NULL,
	[ProductName] [varchar](25) NULL,
	[ProductDescription] [varchar](100) NULL,
	[Price] [decimal](5, 2) NULL,
	[Category] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([Category])
REFERENCES [dbo].[Category] ([CategoryName])
GO


