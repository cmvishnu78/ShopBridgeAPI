
CREATE PROCEDURE PostInventoryItems_SP
	-- Add the parameters for the stored procedure here
	@Item_Name nvarchar(max),
	@Item_Description nvarchar(max),
	@Item_Price decimal(18,3),
	@ImageUrl nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into InventoryItems(Item_Name,Item_Description,Item_Price,ImageUrl)
     values (@Item_Name,@Item_Description,@Item_Price,@ImageUrl)
END
GO
