CREATE TABLE [dbo].[Item] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CompanyId]    INT            NULL,
    [CategoryId]   INT            NOT NULL,
    [Name]         VARCHAR (100)  NULL,
    [ShortName]    VARCHAR (10)   NULL,
    [Price]        DECIMAL (9, 2) NULL,
    [Discount]     DECIMAL (9, 3) NULL,
    [DiscountType] BIT            NULL,
    [Tax]          DECIMAL (9, 3) NULL,
    [TaxType]      BIT            NULL,
    [CreatedDate]  DATETIME       NULL,
    [CreatedBy]    INT            NULL,
    [UpdatedDate]  DATETIME       NULL,
    [UpdatedBy]    INT            NULL,
    [Status]       BIT            CONSTRAINT [DF_Item_Status] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__Item__CategoryId__3864608B] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id]),
    CONSTRAINT [FK__Item__CompanyId__04AFB25B] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([Id]),
    CONSTRAINT [FK__Item__CreatedBy__44CA3770] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Item__UpdatedBy__45BE5BA9] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[Users] ([Id])
);











