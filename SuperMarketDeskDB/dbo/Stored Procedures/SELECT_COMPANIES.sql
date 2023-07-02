CREATE PROC [dbo].[SELECT_COMPANIES] 
AS
BEGIN
SELECT  C.Id, C.[Name], C.ShortName, C.CreatedDate, U.Username "Created By", C.UpdatedDate, U2.Username "Updated By", C.[Address], C.[Status]
FROM Company "C"
LEFT JOIN Users "U" ON C.CreatedBy = U.Id
LEFT JOIN Users "U2" ON C.UpdatedBy = U2.Id WHERE C.[Status]=1
END