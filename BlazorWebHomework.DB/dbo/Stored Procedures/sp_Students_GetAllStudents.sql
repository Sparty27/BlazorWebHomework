CREATE PROCEDURE [dbo].[sp_Students_GetAllStudents]
AS
	SELECT StudentId, StudentRegistrationDate, StudentLastName, StudentFirstName, GroupName AS StudentGroupName, StudentAvgScore FROM Students LEFT JOIN Groups ON GroupId = Students.StudentGroupId
RETURN 0
