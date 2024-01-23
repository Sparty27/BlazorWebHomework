CREATE PROCEDURE [dbo].[sp_Groups_GetGroupsByFacultyId]
	@facultyId int
AS
	SELECT * FROM Groups WHERE GroupFacultyId = @facultyId
RETURN 0
