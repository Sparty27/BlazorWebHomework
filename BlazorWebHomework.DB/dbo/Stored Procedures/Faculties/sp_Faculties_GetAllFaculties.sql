CREATE PROCEDURE [dbo].[sp_Faculties_GetAllFaculties]
AS
	SELECT FacultyId, FacultyName, DepartmentName, FacultyNotes FROM Faculties LEFT JOIN Departments ON DepartmentFacultyId = FacultyId