CREATE PROCEDURE [dbo].[sp_Faculties_CreateFaculty]
  @facultyname nvarchar(100),
  @facultynotes text
AS
  INSERT INTO Faculties VALUES (@facultyname, @facultynotes);
RETURN @@rowcount