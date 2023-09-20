CREATE TABLE [dbo].[Users] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (15)  NULL,
    [LastName]    VARCHAR (15)  NULL,
    [Username]    VARCHAR (20)  NULL,
    [Password]    VARCHAR (8)   NULL,
    [ContactNo]   VARCHAR (10)  NULL,
    [Email]       VARCHAR (150) NULL,
    [Gender]      BIT           CONSTRAINT [DF_Users_Gender] DEFAULT ((1)) NULL,
    [City]        VARCHAR (15)  NULL,
    [CreatedDate] DATETIME      NULL,
    [CreatedBy]   INT           NULL,
    [UpdatedDate] DATETIME      NULL,
    [UpdatedBy]   INT           NULL,
    [Role]        VARCHAR (19)  NULL,
    [Status]      BIT           CONSTRAINT [DF_Users_Status] DEFAULT ((1)) NULL,
    [LastLogIn]   DATETIME      NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__Users__Id__45F365D3] FOREIGN KEY ([Id]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Users__Id__46E78A0C] FOREIGN KEY ([Id]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Users__Id__47DBAE45] FOREIGN KEY ([Id]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Users__Id__48CFD27E] FOREIGN KEY ([Id]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Users__Id__49C3F6B7] FOREIGN KEY ([Id]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Users_Users1] FOREIGN KEY ([Id]) REFERENCES [dbo].[Users] ([Id])
);







