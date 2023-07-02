CREATE TABLE [dbo].[Inventory] (
    [Id]           INT            NOT NULL,
    [ComapnyId]    INT            NULL,
    [CategoryId]   INT            NULL,
    [ItemId]       INT            NULL,
    [ItemName]     VARCHAR (50)   NULL,
    [Qauntity]     DECIMAL (9, 2) NULL,
    [Unit]         INT            NULL,
    [CreatedDate]  DATETIME       NULL,
    [Status]       BIT            CONSTRAINT [DF_Inventory_Status] DEFAULT ((1)) NULL,
    [MinimumStock] INT            NULL,
    [MaximumStock] INT            NULL,
    [LastUpdated]  DATETIME       NULL,
    CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED ([Id] ASC)
);



