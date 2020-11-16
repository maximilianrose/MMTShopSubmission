USE [MMTShop]
GO

/****** Object:  StoredProcedure [dbo].[GetItemsInCategory]    Script Date: 16/11/2020 10:04:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
CREATE PROCEDURE [dbo].[GetItemsInCategory] 
	-- Add the parameters for the stored procedure here
	@Category Varchar(50)
AS
BEGIN
	
	Select ProductName from  Product where Category=  @Category
	



END
GO


