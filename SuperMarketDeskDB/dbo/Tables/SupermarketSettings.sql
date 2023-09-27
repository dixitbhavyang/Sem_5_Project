CREATE TABLE [dbo].[SupermarketSettings] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (100) NULL,
    [Address] TEXT          NULL,
    [CIty]    VARCHAR (20)  NULL,
    [Pincode] VARCHAR (6)   NULL,
    [Phone]   VARCHAR (10)  NULL,
    [Email]   VARCHAR (200) NULL,
    [Logo]    VARCHAR (MAX) NULL,
    CONSTRAINT [PK_CompanySettings] PRIMARY KEY CLUSTERED ([Id] ASC)
);

