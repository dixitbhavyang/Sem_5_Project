CREATE PROC [dbo].[SELECT_USERS]
AS
BEGIN
SELECT 
	U1.Id, U1.FirstName, U1.LastName, U1.Username, U1.[Password], U1.ContactNo, U1.Email, U1.Gender, U1.City,	
	U1.CreatedDate, U3.Username "Created By", 
	U1.UpdatedDate, U2.Username "Updated By",
	U1.[Role], U1.[Status], U1.LastLogIn 
FROM Users AS "U1"
LEFT JOIN Users "U2" ON U1.UpdatedBy = U2.Id
LEFT JOIN Users "U3" ON U1.CreatedBy = U3.Id
END