﻿CREATE PROCEDURE [dbo].[sp_Groups_GetCount]
AS
	SELECT COUNT(*) FROM Groups
RETURN 0
