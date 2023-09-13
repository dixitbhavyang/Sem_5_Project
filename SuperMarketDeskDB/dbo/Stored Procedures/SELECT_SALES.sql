CREATE PROCEDURE [dbo].[SELECT_SALES] AS
BEGIN
	SELECT 
		CB.[BillNo] "Bill Number",
		CMP.[Name] "Company",
		CAT.[Name] "Category",
		I.[Name] "Item",
		S.[Quantity],
		INV.[Unit] "Unit",
		S.SaleDate "Date"
	FROM
	Sales "S"
	LEFT JOIN CustomerBill "CB" ON S.[CustomerBillId] = CB.[Id]
	LEFT JOIN Item "I" ON S.[ItemId] = I.[Id]
	LEFT JOIN Company "CMP" ON I.[CompanyId] = CMP.[Id]
	LEFT JOIN Category "CAT" ON I.[CategoryId] = CAT.[Id]
	LEFT JOIN Inventory "INV" ON I.[Id] = INV.[ItemId]
END