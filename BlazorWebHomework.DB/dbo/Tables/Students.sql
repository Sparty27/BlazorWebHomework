CREATE TABLE [dbo].[Students] (
    [StudentId]        INT           IDENTITY (1, 1) NOT NULL,
    [StudentFirstName] NVARCHAR (50) NOT NULL,
    [StudentLastName]  NVARCHAR (50) NOT NULL,
    [StudentGroupId]   INT           NULL,
    [StudentAvgScore]  FLOAT (53)    NULL,
    [StudentRegistrationDate] DATE NULL, 
    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([StudentId] ASC),
    CONSTRAINT [FK_Students_Groups] FOREIGN KEY ([StudentGroupId]) REFERENCES [dbo].[Groups] ([GroupId]) ON DELETE SET NULL
);

