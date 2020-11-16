USE [MMTShop]
GO

/****** Object:  StoredProcedure [dbo].[GetCategoriesList]    Script Date: 16/11/2020 10:03:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
CREATE PROCEDURE [dbo].[GetCategoriesList] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	
	Select Distinct CategoryName from  Category
	



END
GO


