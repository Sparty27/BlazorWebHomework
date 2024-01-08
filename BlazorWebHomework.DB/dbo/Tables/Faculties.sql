CREATE TABLE [dbo].[Faculties] (
    [FacultyId]    INT            IDENTITY (1, 1) NOT NULL,
    [FacultyName]  NVARCHAR (100) NOT NULL,
    [FacultyNotes] TEXT           NULL,
    CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED ([FacultyId] ASC)
);

