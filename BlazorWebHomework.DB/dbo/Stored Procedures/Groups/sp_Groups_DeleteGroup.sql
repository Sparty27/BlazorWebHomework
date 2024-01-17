CREATE PROCEDURE [dbo].[sp_Groups_DeleteGroup]
	@groupId int
AS
	DELETE FROM Groups WHERE GroupId = @groupId
RETURN @@ROWCOUNT
