CREATE TABLE [dbo].[CustomerBill] (
    [Id]            INT            NOT NULL,
    [CustomerId]    INT            NULL,
    [ItemId]        INT            NULL,
    [Quantity]      DECIMAL (9, 2) NULL,
    [TotalAmount]   DECIMAL (9, 2) NULL,
    [Discount]      DECIMAL (9, 2) NULL,
    [Tax]           DECIMAL (9, 2) NULL,
    [PayableAmount] DECIMAL (9, 2) NULL,
    [BillDate]      DATETIME       NULL,
    [PaymentStatus] VARCHAR (10)   NULL,
    [CreatedDate]   DATETIME       NULL,
    [CreatedBy]     INT            NULL,
    [UpdatedDate]   DATETIME       NULL,
    [UpdatedBy]     INT            NULL,
    CONSTRAINT [PK_CustomerBill] PRIMARY KEY CLUSTERED ([Id] ASC)
);



