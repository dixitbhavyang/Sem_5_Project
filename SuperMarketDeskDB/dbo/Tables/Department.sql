CREATE TABLE [dbo].[Department] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NULL,
    [ShortName]   VARCHAR (10) NULL,
    [Phone]       VARCHAR (10) NULL,
    [Description] TEXT         NULL,
    [CreatedDate] DATETIME     NULL,
    [CreatedBy]   INT          NULL,
    [LastUpdated] DATETIME     NULL,
    [UpdatedBy]   INT          NULL,
    [Status]      BIT          CONSTRAINT [DF_Department_Status] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__Departmen__Creat__4E1E9780] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Departmen__Updat__53D770D6] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Departmen__Updat__54CB950F] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[Users] ([Id])
);



