CREATE PROC GET_ITEMS_GETTING_OUT_OF_STOCK AS
BEGIN
	SELECT 
		CMP.[Name] "Company",
		CAT.[Name] "Category",
		IT.[Name] "Item",
		I.[Quantity] "Quantity"
	FROM 
	Inventory "I" 
	LEFT JOIN Item "IT" ON I.[ItemId] = IT.[Id]
	LEFT JOIN Category "CAT" ON IT.[CategoryId] = CAT.[Id]
	LEFT JOIN Company "CMP" ON IT.[CompanyId] = CMP.[Id]
	WHERE I.[Quantity] <= I.[MinimumStock];
END