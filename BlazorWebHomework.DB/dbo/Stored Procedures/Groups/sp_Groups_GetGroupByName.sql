CREATE PROCEDURE [dbo].[sp_Groups_GetGroupByName]
	@groupName nvarchar(25)
AS
	SELECT COUNT(*) FROM Groups WHERE GroupName = @groupName
RETURN 0
