CREATE PROCEDURE [dbo].[SELECT_INVENTORY_RECORDS] AS
BEGIN
	SELECT
	I.Id, C2.[Name] "Company", C.[Name] "Category", I2.[Name] "Item", 
	I.Quantity,I.Unit,
	I.CreatedDate, U.[Username] "Created By", 
	I.LastUpdated, U2.[Username] "Updated By",
	I.MinimumStock, I.MaximumStock,
	I.[Status]
	FROM Inventory "I"
	LEFT JOIN Users "U" ON I.CreatedBy = U.Id
	LEFT JOIN Users "U2" ON I.UpdatedBy = U2.Id
	LEFT JOIN Category "C" ON I.CategoryId = C.Id
	LEFT JOIN Company "C2" ON I.CompanyId = C2.Id
	LEFT JOIN Item I2 ON I.ItemId = I2.Id
END;