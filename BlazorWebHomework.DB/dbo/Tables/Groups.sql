CREATE TABLE [dbo].[Groups] (
    [GroupId]          INT           IDENTITY (1, 1) NOT NULL,
    [GroupName]        NVARCHAR (50) NOT NULL,
    [GroupFacultyId]   INT           NOT NULL,
    [GroupNumStudents] INT           NOT NULL,
    [GroupAvgScore]    FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED ([GroupId] ASC)
);

