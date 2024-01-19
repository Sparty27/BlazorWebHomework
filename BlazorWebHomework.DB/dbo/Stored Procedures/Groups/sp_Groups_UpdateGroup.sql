CREATE PROCEDURE [dbo].[sp_Groups_UpdateGroup]
	@groupId int,
	@groupName nvarchar(25),
	@groupFacultyId int
AS
	UPDATE Groups
	SET GroupName = @groupName,
		GroupFacultyId = @groupFacultyId
	WHERE GroupId = @groupId
RETURN 1
