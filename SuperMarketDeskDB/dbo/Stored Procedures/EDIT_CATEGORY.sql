﻿CREATE PROC [dbo].[EDIT_CATEGORY] @ID INT
AS
BEGIN
SELECT *FROM Category WHERE Id=@ID AND [Status] = 1;
END