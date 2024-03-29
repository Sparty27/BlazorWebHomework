﻿CREATE PROCEDURE [dbo].[sp_Students_GetStudentById]
	@studentId int
AS
	SELECT StudentId, StudentRegistrationDate, StudentLastName, StudentFirstName, StudentGroupId, GroupName AS StudentGroupName, StudentAvgScore FROM Students 
	LEFT JOIN Groups ON GroupId = Students.StudentGroupId
	WHERE StudentId = @studentId
