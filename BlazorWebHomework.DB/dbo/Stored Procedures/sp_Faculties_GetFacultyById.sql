CREATE PROCEDURE [dbo].[sp_Faculties_GetFacultyById]
	@facultyId int
AS
	SELECT * FROM Faculties WHERE FacultyId = @facultyId
RETURN 0