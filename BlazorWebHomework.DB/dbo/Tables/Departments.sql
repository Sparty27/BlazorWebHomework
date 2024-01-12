CREATE TABLE [dbo].[Departments] (
    [DepartmentId]        INT            IDENTITY (1, 1) NOT NULL,
    [DepartmentName]      NVARCHAR (100) NOT NULL,
    [DepartmentFacultyId] INT            NOT NULL,
    CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED ([DepartmentId] ASC),
    CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY ([DepartmentFacultyId]) REFERENCES [dbo].[Faculties] ([FacultyId])
);

