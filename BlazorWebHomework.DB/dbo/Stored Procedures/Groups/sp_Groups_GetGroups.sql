CREATE PROCEDURE [dbo].[sp_Groups_GetGroups]
	@Skip int,
	@Take int
AS
	SELECT GroupId, GroupName, GroupFacultyId, FacultyName AS GroupFacultyName, GroupNumStudents, GroupAvgScore
	FROM Groups LEFT JOIN Faculties ON Faculties.FacultyId = Groups.GroupFacultyId
	ORDER BY GroupId
	OFFSET @Skip ROWS
	FETCH NEXT @Take ROWS ONLY;
RETURN 0