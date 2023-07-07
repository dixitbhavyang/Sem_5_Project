CREATE PROCEDURE DELETE_COMPANY
    @ID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the record exists
    IF EXISTS (SELECT * FROM Category WHERE CompanyId = @ID)
    BEGIN
        -- Return the existing record
        SELECT NAME FROM Category WHERE CompanyId = @ID;
    END
    ELSE
    BEGIN
        -- Update the record with the new value
        UPDATE Company SET [Status] = 0 WHERE ID = @ID;
    END
END