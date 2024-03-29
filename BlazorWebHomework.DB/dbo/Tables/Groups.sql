﻿CREATE TABLE [dbo].[Groups] (
    [GroupId]          INT           IDENTITY (1, 1) NOT NULL,
    [GroupName]        NVARCHAR (25) NOT NULL,
    [GroupFacultyId]   INT           NULL,
    [GroupNumStudents] INT           NULL DEFAULT 0,
    [GroupAvgScore]    FLOAT (53)    NULL DEFAULT 0,
    CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED ([GroupId] ASC),
    CONSTRAINT [FK_Groups_Faculties] FOREIGN KEY ([GroupFacultyId]) REFERENCES [dbo].[Faculties] ([FacultyId]) ON DELETE SET NULL
);

