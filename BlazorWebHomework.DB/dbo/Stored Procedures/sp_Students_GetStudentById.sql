CREATE PROCEDURE [dbo].[sp_Students_GetStudentById]
	@studentId int
AS
	SELECT * FROM Students WHERE StudentId = @studentId
