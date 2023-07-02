CREATE TABLE [dbo].[Item] (
    [Id]          NCHAR (10)     NOT NULL,
    [CategoryId]  INT            NULL,
    [Name]        VARCHAR (100)  NULL,
    [ShortName]   VARCHAR (10)   NULL,
    [Price]       DECIMAL (9, 2) NULL,
    [Discount]    DECIMAL (9, 2) NULL,
    [Tax]         DECIMAL (9, 2) NULL,
    [CreatedDate] DATETIME       NULL,
    [UpdatedDate] DATETIME       NULL,
    [Status]      BIT            CONSTRAINT [DF_Item_Status] DEFAULT ((1)) NULL,
    [ExpiryDate]  DATETIME       NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([Id] ASC)
);



