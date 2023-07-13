CREATE PROC SELECT_ACTIVE_CATEGORIES AS
BEGIN
	SELECT  C.Id, C.[Name], C.ShortName, C.CreatedDate, U.Username "Created By", C.UpdatedDate, U2.Username "Updated By",C2.[Name] "Company", C.[Status]
	FROM Category "C"
	LEFT JOIN Users "U" ON C.CreatedBy = U.Id
	LEFT JOIN Users "U2" ON C.UpdatedBy = U2.Id 
	LEFT JOIN Company "C2" ON C.CompanyId = C2.Id WHERE C.[Status] = 1;
END