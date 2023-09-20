CREATE TABLE [dbo].[Company] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (100) NULL,
    [ShortName]   VARCHAR (10)  NULL,
    [Address]     VARCHAR (100) NULL,
    [CreatedDate] DATETIME      NULL,
    [CreatedBy]   INT           NULL,
    [UpdatedDate] DATETIME      NULL,
    [UpdatedBy]   INT           NULL,
    [Status]      BIT           CONSTRAINT [DF_Company_Status] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__Company__Created__2EDAF651] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Company__Updated__2FCF1A8A] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_CREATED_BY] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Users] ([Id])
);









