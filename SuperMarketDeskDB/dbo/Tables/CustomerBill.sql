CREATE TABLE [dbo].[CustomerBill] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [BillNo]        VARCHAR (16)   NOT NULL,
    [CustomerId]    INT            NULL,
    [TotalAmount]   DECIMAL (9, 2) NULL,
    [Discount]      DECIMAL (9, 3) NULL,
    [Tax]           DECIMAL (9, 3) NULL,
    [PayableAmount] DECIMAL (9, 2) NULL,
    [BillDate]      DATETIME       NULL,
    [CreatedDate]   DATETIME       NULL,
    [CreatedBy]     INT            NULL,
    CONSTRAINT [PK_CustomerBill] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([Id]),
    CONSTRAINT [FK__CustomerB__Custo__67DE6983] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([Id])
);





