CREATE PROCEDURE [dbo].[sp_Students_CreateStudent]
	@studentFirstName nvarchar(50),
	@studentLastName nvarchar(50),
	@studentGroupId int,
	@studentAvgScore float, 
	@studentRegistrationDate date
AS
  INSERT INTO Students VALUES (@studentFirstName, @studentLastName,
		@studentGroupId, @studentAvgScore, @studentRegistrationDate);
SELECT SCOPE_IDENTITY();