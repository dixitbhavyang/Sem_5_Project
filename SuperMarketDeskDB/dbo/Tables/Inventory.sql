CREATE TABLE [dbo].[Inventory] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CompanyId]    INT            NULL,
    [CategoryId]   INT            NULL,
    [ItemId]       INT            NULL,
    [Quantity]     DECIMAL (9, 2) NULL,
    [Unit]         INT            NULL,
    [CreatedDate]  DATETIME       NULL,
    [CreatedBy]    INT            NULL,
    [LastUpdated]  DATETIME       NULL,
    [UpdatedBy]    INT            NULL,
    [MinimumStock] INT            NULL,
    [MaximumStock] INT            NULL,
    [Status]       BIT            CONSTRAINT [DF_Inventory_Status] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id]),
    FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([Id]),
    FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Users] ([Id]),
    FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Inventory__ItemI__793DFFAF] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([Id])
);





