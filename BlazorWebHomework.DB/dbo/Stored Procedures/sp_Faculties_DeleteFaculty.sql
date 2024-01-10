CREATE PROCEDURE [dbo].[sp_Faculties_DeleteFaculty]
	@facultyId int
AS
	DELETE FROM Faculties WHERE Faculties.FacultyId = @facultyId
RETURN @@ROWCOUNT
