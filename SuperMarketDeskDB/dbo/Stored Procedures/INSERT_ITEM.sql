CREATE PROCEDURE [dbo].[INSERT_ITEM] 
	@COMPANYID INT,
	@CATEGORYID INT,
	@NAME VARCHAR(100), 
	@SHORTNAME VARCHAR(10),
	@PRICE DECIMAL(9,2),
	@DISCOUNT DECIMAL(9,3),
	@DISCOUNTTYPE BIT,
	@TAX DECIMAL(9,3),
	@TAXTYPE BIT,
	@CREATEDDATE DATETIME,
	@CREATEDBY INT,
	@UPDATEDDATE DATETIME,
	@UPDATEDBY INT
AS
BEGIN
	INSERT INTO [dbo].[Item]
           ([CompanyId]
		   ,[CategoryId]
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
           ,[UpdatedBy])
     VALUES
           (@COMPANYID
		   ,@CATEGORYID
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
		   ,@UPDATEDBY);
END