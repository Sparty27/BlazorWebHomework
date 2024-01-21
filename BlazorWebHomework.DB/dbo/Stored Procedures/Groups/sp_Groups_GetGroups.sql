CREATE PROCEDURE [dbo].[sp_Groups_GetGroups]
    @Skip int,
    @Take int,
    @searchText nvarchar(255) = NULL
AS
    SELECT GroupId, GroupName, GroupFacultyId, FacultyName AS GroupFacultyName, GroupNumStudents, GroupAvgScore
    FROM Groups
    LEFT JOIN Faculties ON Faculties.FacultyId = Groups.GroupFacultyId
    WHERE (@searchText IS NULL OR GroupName LIKE '%' + @searchText + '%')
    ORDER BY GroupId, GroupFacultyName, GroupName
    OFFSET @Skip ROWS
    FETCH NEXT @Take ROWS ONLY;

    RETURN 0
