CREATE PROC [dbo].[SELECT_ACTIVE_ITEMS] AS
BEGIN
	SELECT  
	I.Id, I.[Name], I.ShortName, I.Price, I.Discount, I.Tax, I.ExpiryDate, C.[Name] "Category", C2.[Name] "Company",
	I.CreatedDate, U.[Username] "Created By", 
	I.UpdatedDate, U2.[Username] "Updated By", I.[Status]
	FROM Item "I"
	LEFT JOIN Users "U" ON I.CreatedBy = U.Id
	LEFT JOIN Users "U2" ON I.UpdatedBy = U2.Id
	LEFT JOIN Category "C" ON I.CategoryId = C.Id
	LEFT JOIN Company "C2" ON I.CompanyId = C2.Id WHERE I.[Status] = 1
END