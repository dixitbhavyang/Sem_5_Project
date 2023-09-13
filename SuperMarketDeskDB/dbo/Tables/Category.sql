CREATE TABLE [dbo].[Category] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [CompanyId]   INT          NULL,
    [Name]        VARCHAR (20) NULL,
    [ShortName]   VARCHAR (20) NULL,
    [CreatedDate] DATETIME     NULL,
    [CreatedBy]   INT          NULL,
    [UpdatedDate] DATETIME     NULL,
    [Updatedby]   INT          NULL,
    [Status]      BIT          CONSTRAINT [DF_Category_Status] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([Id]),
    CONSTRAINT [FK__Category__Create__2CF2ADDF] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Category__Update__2DE6D218] FOREIGN KEY ([Updatedby]) REFERENCES [dbo].[Users] ([Id])
);







