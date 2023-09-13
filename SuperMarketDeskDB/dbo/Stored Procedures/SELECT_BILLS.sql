CREATE PROC [dbo].[SELECT_BILLS]
AS	
BEGIN
	SELECT 
		CB.[Id],
		CB.[BillNo],
		C.[FirstName] + ' ' + C.[LastName] "Customer",
		CB.[TotalAmount],
		CB.[Discount],
		CB.[Tax],
		CB.[PayableAmount],
		CB.[BillDate],
		CB.[CreatedDate],
		U.[Username] "Created By"
	FROM CustomerBill "CB"
	LEFT JOIN Customer "C" ON CB.[CustomerId]=C.[Id]
	LEFT JOIN Users "U" ON CB.[CreatedBy]=U.[Id]
END