CREATE PROCEDURE [dbo].[sp_Groups_GetCount]
	@searchText nvarchar(255) = NULL
AS
	SELECT COUNT(*) FROM Groups
    WHERE (@searchText IS NULL OR GroupName LIKE '%' + @searchText + '%')
RETURN 0
