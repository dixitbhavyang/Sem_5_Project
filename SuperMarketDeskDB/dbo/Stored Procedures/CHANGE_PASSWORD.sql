﻿CREATE PROCEDURE CHANGE_PASSWORD 
	@ID INT,
	@NEWPASSWORD VARCHAR(8)
AS
BEGIN
	UPDATE Users SET [Password] = @NEWPASSWORD WHERE [Id] = @ID;
END