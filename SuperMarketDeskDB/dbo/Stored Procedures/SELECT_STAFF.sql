CREATE PROC [dbo].[SELECT_STAFF] AS
BEGIN
	SELECT
		S.[Id], 
		S.[FirstName], 
		S.[LastName], 
		S.[Phone], 
		S.[Email],
		S.[Gender],
		S.[Address],
		D.ShortName "Department",
		S.[Salary],
		S.[JoinDate],
		S.[CreatedDate],
		U.[Username] "Created By",
		S.[LastUpdated],
		U2.[Username] "Updated By",
		S.[Status]
	FROM Staff "S"
	LEFT JOIN Users "U" ON S.[CreatedBy] = U.[Id]
	LEFT JOIN Users "U2" ON S.[UpdatedBy] = U2.[Id]
	LEFT JOIN Department "D" ON S.[DepartmentId]=D.[Id];
END