CREATE TABLE [dbo].[Company] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (100) NULL,
    [ShortName]   VARCHAR (10)  NULL,
    [CreatedDate] DATETIME      NULL,
    [CreatedBy]   INT           NULL,
    [UpdatedDate] DATETIME      NULL,
    [UpdatedBy]   INT           NULL,
    [Address]     VARCHAR (100) NULL,
    [Status]      BIT           CONSTRAINT [DF_Company_Status] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CREATED_BY] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Users] ([Id])
);



