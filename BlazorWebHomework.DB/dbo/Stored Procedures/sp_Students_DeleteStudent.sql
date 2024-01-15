CREATE PROCEDURE [dbo].[sp_Students_DeleteStudent]
	@studentId int
AS
	DELETE FROM Students WHERE Students.StudentId = @studentId
RETURN @@ROWCOUNT

