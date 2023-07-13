﻿CREATE PROC [dbo].[SELECT_ITEMS]
AS
BEGIN
	SELECT  
	I.Id, I.[Name], I.ShortName, I.Price, I.Discount, I.Tax, I.ExpiryDate, C.[Name] "Category", 
	I.CreatedDate, U.[Username] "Created By", 
	I.UpdatedDate, U2.[Username] "Updated By", I.[Status]
	FROM Item "I"
	LEFT JOIN Users "U" ON I.CreatedBy = U.Id
	LEFT JOIN Users "U2" ON I.UpdatedBy = U2.Id
	LEFT JOIN Category "C" ON I.CategoryId = C.Id
END