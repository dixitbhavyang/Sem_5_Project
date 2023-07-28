CREATE PROC [dbo].[SELECT_DEPARTMENTS] AS
BEGIN	
	SELECT 
		D.[Id],
		D.[Name], 
		D.[ShortName],
		D.[Phone],
		D.[Description],
		D.[CreatedDate],
		U.[Username] "Created By",
		D.[LastUpdated],
		U2.[Username] "Updated By",
		D.[Status]
	FROM 
	Department "D" 
	LEFT JOIN Users "U" ON  D.CreatedBy = U.Id
	LEFT JOIN Users "U2" ON D.UpdatedBy = U2.Id;
END;