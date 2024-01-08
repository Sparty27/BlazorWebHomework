CREATE TABLE [dbo].[Students] (
    [StudentId]        INT           IDENTITY (1, 1) NOT NULL,
    [StudentFirstName] NVARCHAR (50) NOT NULL,
    [StudentLastName]  NVARCHAR (50) NOT NULL,
    [StudentGroupId]   INT           NOT NULL,
    [StudentAvgScore]  FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([StudentId] ASC)
);

