CREATE TABLE [dbo].[Sales] (
    [Id]             INT            NOT NULL,
    [CustomerBillId] INT            NULL,
    [CompanyId]      INT            NULL,
    [CategoryId]     INT            NULL,
    [ItemId]         INT            NULL,
    [InventoryId]    INT            NULL,
    [Quantity]       DECIMAL (9, 2) NULL,
    [SaleDate]       DATETIME       NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED ([Id] ASC)
);

