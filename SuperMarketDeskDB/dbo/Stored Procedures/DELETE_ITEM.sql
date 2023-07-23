CREATE PROC [dbo].[DELETE_ITEM] 
	@ID INT
AS
BEGIN
	IF EXISTS (SELECT * FROM Inventory WHERE ItemId = @ID AND [Status] = 1)
    BEGIN
        -- Return the existing record
        SELECT I.Unit FROM Inventory "I" WHERE I.ItemId = @ID;
    END
	ELSE
	BEGIN
		UPDATE Item SET [Status] = 0 WHERE Id = @ID;
	END
END