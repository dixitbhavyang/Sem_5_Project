CREATE PROC [dbo].[DELETE_DEPARTMENT]
	@ID INT
AS
BEGIN
	IF EXISTS (SELECT *FROM Staff WHERE [DepartmentId]=@ID AND [Status]=1)
		BEGIN
			SELECT [FirstName] FROM Staff WHERE [DepartmentId]=@ID AND [Status]=1;
		END
	ELSE
		BEGIN
			UPDATE Department SET [Status]=0 WHERE [Id]=@ID;
		END
END