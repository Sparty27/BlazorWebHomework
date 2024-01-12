CREATE TABLE [dbo].[Groups] (
    [GroupId]          INT           IDENTITY (1, 1) NOT NULL,
    [GroupName]        NVARCHAR (50) NOT NULL,
    [GroupFacultyId]   INT           NOT NULL,
    [GroupNumStudents] INT           NULL,
    [GroupAvgScore]    FLOAT (53)    NULL,
    CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED ([GroupId] ASC),
    CONSTRAINT [FK_Groups_Faculties] FOREIGN KEY ([GroupFacultyId]) REFERENCES [dbo].[Faculties] ([FacultyId])
);

