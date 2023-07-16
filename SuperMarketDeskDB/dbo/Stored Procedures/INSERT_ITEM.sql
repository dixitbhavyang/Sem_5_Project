CREATE PROCEDURE [dbo].[INSERT_ITEM] 
	@CATEGORYID INT,
	@NAME VARCHAR(100), 
	@SHORTNAME VARCHAR(10),
	@PRICE DECIMAL(9,2),
	@DISCOUNT DECIMAL(9,2),
	@DISCOUNTTYPE BIT,
	@TAX DECIMAL(9,2),
	@TAXTYPE BIT,
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
		   ,[DiscountType]
           ,[Tax]
		   ,[TaxType]
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
		   ,@DISCOUNTTYPE
		   ,@TAX
		   ,@TAXTYPE
		   ,@CREATEDDATE
		   ,@CREATEDBY
		   ,@UPDATEDDATE
		   ,@UPDATEDBY
		   ,@EXPIRYDATE);
END