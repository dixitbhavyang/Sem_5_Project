CREATE PROCEDURE INSERT_ITEM 
	@CATEGORYID INT,
	@NAME VARCHAR(100), 
	@SHORTNAME VARCHAR(10),
	@PRICE DECIMAL(9,2),
	@DISCOUNT DECIMAL(9,2),
	@TAX DECIMAL(9,2),
	@CREATEDDATE DATETIME,
	@CREATEDBY INT,
	@UPDATEDDATE DATETIME,
	@UPDATEDBY INT,
	@EXPIRYDATE DATETIME
AS
BEGIN
	INSERT INTO [dbo].[Item]
           ([CategoryId]
           ,[Name]
           ,[ShortName]
           ,[Price]
           ,[Discount]
           ,[Tax]
           ,[CreatedDate]
           ,[CreatedBy]
           ,[UpdatedDate]
           ,[UpdatedBy]
           ,[ExpiryDate])
     VALUES
           (@CATEGORYID
		   ,@NAME
		   ,@SHORTNAME
		   ,@PRICE
		   ,@DISCOUNT
		   ,@TAX
		   ,@CREATEDDATE
		   ,@CREATEDBY
		   ,@UPDATEDDATE
		   ,@UPDATEDBY
		   ,@EXPIRYDATE);
END