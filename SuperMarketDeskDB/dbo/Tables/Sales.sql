CREATE TABLE [dbo].[Sales] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [CustomerBillId] INT            NULL,
    [CompanyId]      INT            NULL,
    [CategoryId]     INT            NULL,
    [ItemId]         INT            NULL,
    [Quantity]       DECIMAL (9, 2) NULL,
    [SaleDate]       DATETIME       NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CustomerBillId]) REFERENCES [dbo].[CustomerBill] ([Id])
);



