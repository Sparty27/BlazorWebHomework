CREATE PROCEDURE [dbo].[sp_Faculties_GetAllFaculties]
AS
    SELECT
        f.FacultyId,
        f.FacultyName,
        STUFF((
            SELECT '&&' + d.DepartmentName
            FROM Departments d
            WHERE d.DepartmentFacultyId = f.FacultyId
            FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS FacultyDepartments,
        f.FacultyNotes
    FROM
        Faculties f