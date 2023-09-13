CREATE PROC SELECT_ITEM_INVENTORY
	@ID INT
AS
BEGIN
	SELECT
		I.Id, 
		I.Quantity, 
		I.Unit, 
		I.[Status]
	FROM Inventory "I" WHERE [ItemId]=@ID;
END