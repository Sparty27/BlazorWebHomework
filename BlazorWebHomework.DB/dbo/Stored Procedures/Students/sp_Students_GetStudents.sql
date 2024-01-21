CREATE PROCEDURE [dbo].[sp_Students_GetStudents]
	@Skip int,
	@Take int
AS
	SELECT * FROM Students
	ORDER BY StudentId
	OFFSET @Skip ROWS
	FETCH NEXT @Take ROWS ONLY;
RETURN 0
