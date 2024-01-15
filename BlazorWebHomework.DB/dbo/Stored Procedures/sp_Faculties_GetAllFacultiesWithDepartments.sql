CREATE PROCEDURE sp_Faculties_GetAllFacultiesWithDepartments
AS
BEGIN
    SELECT FacultyId,
           FacultyName,
           STRING_AGG(DepartmentName, '<br><br>') AS Departments,
           CAST(FacultyNotes AS NVARCHAR(MAX)) AS FacultyNotes
    FROM Faculties
    LEFT JOIN Departments ON DepartmentFacultyId = FacultyId
    GROUP BY FacultyId, FacultyName, CAST(FacultyNotes AS NVARCHAR(MAX));
END;
