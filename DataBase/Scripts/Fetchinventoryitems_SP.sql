
-- =============================================
-- Author:		<Vishnu CM>
-- Create date: <17.03.2021,>
-- Description:	<For Fetching Inventoryitems>
-- =============================================
Alter PROCEDURE Fetchinventoryitems_SP
	-- Add the parameters for the stored procedure here
	@ItemID int=0,
	@Mode nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @Mode='AllItems'
	   begin
	      select Item_Id,Item_Name,Item_Description,Item_Price,ImageUrl from InventoryItems
	   end
   else if @Mode='SpecificItems'
      begin
         select Item_Id,Item_Name,Item_Description,Item_Price,ImageUrl from InventoryItems where Item_Id=@ItemID
      end
	else 
	  begin
	  delete from InventoryItems where Item_Id=@ItemID
	  end
END
GO
