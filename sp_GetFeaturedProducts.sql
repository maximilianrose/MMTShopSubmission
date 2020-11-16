USE [MMTShop]
GO

/****** Object:  StoredProcedure [dbo].[GetFeaturedProducts]    Script Date: 16/11/2020 10:04:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[GetFeaturedProducts] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	
	Select ProductName from  Product
	WHERE SKU LIKE '1%%%%'
	OR SKU like '2%%%%'
	or SKU like '3%%%%'



END
GO


