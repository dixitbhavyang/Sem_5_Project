CREATE TABLE [dbo].[CompanySettings] (
    [Id]      INT           NOT NULL,
    [Name]    VARCHAR (100) NULL,
    [Contact] VARCHAR (10)  NULL,
    [Email]   VARCHAR (50)  NULL,
    [Logo]    VARCHAR (MAX) NULL,
    [CIty]    VARCHAR (20)  NULL,
    [Pincode] INT           NULL,
    [Country] VARCHAR (20)  NULL,
    CONSTRAINT [PK_CompanySettings] PRIMARY KEY CLUSTERED ([Id] ASC)
);

