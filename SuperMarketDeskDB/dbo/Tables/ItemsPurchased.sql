CREATE TABLE [dbo].[ItemsPurchased] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [BillId]        VARCHAR (16)   NULL,
    [CustomerId]    INT            NULL,
    [ItemId]        INT            NULL,
    [Quantity]      DECIMAL (9, 2) NULL,
    [TotalAmount]   DECIMAL (9, 2) NULL,
    [Discount]      DECIMAL (9, 2) NULL,
    [Tax]           DECIMAL (9, 2) NULL,
    [PayableAmount] DECIMAL (9, 2) NULL,
    CONSTRAINT [PK_ItemsPurchased] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([Id]),
    CONSTRAINT [FK__ItemsPurc__ItemI__3F9B6DFF] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([Id])
);

