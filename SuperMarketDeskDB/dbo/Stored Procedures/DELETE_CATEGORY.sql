CREATE PROCEDURE [dbo].[DELETE_CATEGORY]
    @ID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the record exists
    IF EXISTS (SELECT * FROM Item WHERE CategoryId = @ID AND [Status]=1)
    BEGIN
        -- Return the existing record
        SELECT NAME FROM Item WHERE CategoryId = @ID;
    END
    ELSE
    BEGIN
        -- Update the record with the new value
        UPDATE Category SET [Status] = 0 WHERE ID = @ID;
    END
END