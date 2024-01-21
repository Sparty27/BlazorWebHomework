CREATE PROCEDURE [dbo].[sp_Students_GetAllStudents]
    @searchText nvarchar(255) = NULL
AS
	SELECT StudentId, StudentRegistrationDate, StudentLastName, StudentFirstName, StudentGroupId, GroupName AS StudentGroupName, StudentAvgScore FROM Students 
	LEFT JOIN Groups ON GroupId = Students.StudentGroupId
    WHERE (@searchText IS NULL OR (StudentLastName + ' ' + StudentFirstName) LIKE '%' + @searchText + '%')
	ORDER BY StudentId
RETURN 0
