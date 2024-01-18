CREATE PROCEDURE [dbo].[sp_Groups_CreateGroup]
	@groupName nvarchar(25),
	@groupFacultyId int
AS
	INSERT INTO Groups VALUES (@groupName, @groupFacultyId, DEFAULT, DEFAULT)
SELECT SCOPE_IDENTITY();
