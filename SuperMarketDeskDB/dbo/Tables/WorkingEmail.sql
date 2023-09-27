CREATE TABLE [dbo].[WorkingEmail] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Email]    VARCHAR (200) NULL,
    [Password] VARCHAR (100) NULL,
    CONSTRAINT [PK_WorkingEmail] PRIMARY KEY CLUSTERED ([Id] ASC)
);

