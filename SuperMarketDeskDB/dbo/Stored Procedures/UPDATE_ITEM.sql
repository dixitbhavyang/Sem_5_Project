﻿CREATE PROC [dbo].[UPDATE_ITEM] 
@ID INT,
@COMPANYID INT,
@CATEGORYID INT,
@NAME VARCHAR(100),
@SHORTNAME VARCHAR(12),
@PRICE DECIMAL(9,2),
@DISCOUNT DECIMAL(9,2),
@DISCOUNTTYPE BIT,
@TAX DECIMAL(9,2),
@TAXTYPE BIT,
@UPDATEDDATE DATETIME,
@UPDATEDBY INT,
@EXPIRYDATE DATETIME
AS
BEGIN
	UPDATE Item SET 
		CompanyId = @COMPANYID,
		CategoryId = @CATEGORYID,
		[Name] = @NAME,
		ShortName = @SHORTNAME,
		Price = @PRICE,
		Discount = @DISCOUNT,
		DiscountType = @DISCOUNTTYPE,
		Tax = @TAX,
		TaxType = @TAXTYPE,
		UpdatedDate = @UPDATEDDATE,
		UpdatedBy = @UPDATEDBY,
		ExpiryDate = @EXPIRYDATE
	WHERE ID = @ID;
END