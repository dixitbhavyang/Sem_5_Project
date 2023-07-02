CREATE TABLE [dbo].[Category] (
    [Id]          INT          NOT NULL,
    [CompanyId]   INT          NULL,
    [Name]        VARCHAR (20) NULL,
    [ShortName]   VARCHAR (20) NULL,
    [CreatedDate] DATETIME     NULL,
    [CreatedBy]   INT          NULL,
    [UpdatedDate] DATETIME     NULL,
    [Updatedby]   INT          NULL,
    [Status]      BIT          NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Id] ASC)
);



