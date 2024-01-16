CREATE PROCEDURE [dbo].[sp_Students_UpdateStudent]
	@studentId int,
	@studentFirstName nvarchar(50),
	@studentLastName nvarchar(50),
	@studentGroupId int,
	@studentAvgScore float,
	@studentRegistrationDate date
AS
	UPDATE Students
	SET
		StudentFirstName = @studentFirstName,
		StudentLastName = @studentLastName,
		StudentGroupId = @studentGroupId,
		StudentAvgScore = @studentAvgScore,
		StudentRegistrationDate = @studentRegistrationDate
	WHERE StudentId = @studentId
RETURN @@ROWCOUNT
