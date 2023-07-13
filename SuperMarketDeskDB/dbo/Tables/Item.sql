CREATE TABLE [dbo].[Item] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [CategoryId]  INT            NOT NULL,
    [Name]        VARCHAR (100)  NULL,
    [ShortName]   VARCHAR (10)   NULL,
    [Price]       DECIMAL (9, 2) NULL,
    [Discount]    DECIMAL (9, 2) NULL,
    [Tax]         DECIMAL (9, 2) NULL,
    [CreatedDate] DATETIME       NULL,
    [CreatedBy]   INT            NULL,
    [UpdatedDate] DATETIME       NULL,
    [UpdatedBy]   INT            NULL,
    [Status]      BIT            CONSTRAINT [DF_Item_Status] DEFAULT ((1)) NULL,
    [ExpiryDate]  DATETIME       NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Users] ([Id]),
    FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Item__CategoryId__3864608B] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id])
);





