﻿--IF NOT EXISTS (SELECT * FROM [Groups])
--BEGIN
--	SET IDENTITY_INSERT [dbo].[Groups] ON;
--	INSERT INTO Groups VALUES ('Test', 8, 54, 94.8);
--	SET IDENTITY_INSERT [dbo].[Groups] ON;
--END