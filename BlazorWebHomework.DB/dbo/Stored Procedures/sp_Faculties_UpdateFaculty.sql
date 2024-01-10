CREATE PROCEDURE [dbo].[sp_Faculties_UpdateFaculty]
	@facultyId int,
	@facultyName nvarchar(100),
	@facultyNotes text
AS
	UPDATE Faculties
	SET FacultyName = @facultyName,
		FacultyNotes = @facultyNotes
	WHERE FacultyId = @facultyId
RETURN @@ROWCOUNT
