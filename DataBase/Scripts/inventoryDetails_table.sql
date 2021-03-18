create table InventoryItems(Item_Id int primary key identity(1,1) not null,
                            Item_Name nvarchar(max) not null,
							Item_Description nvarchar(max) not null,
							Item_Price decimal(18,3) not null,
							ImageUrl nvarchar(max))
