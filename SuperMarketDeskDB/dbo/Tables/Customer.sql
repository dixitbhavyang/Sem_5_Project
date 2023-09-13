CREATE TABLE [dbo].[Customer] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (15)  NULL,
    [LastName]  VARCHAR (15)  NULL,
    [Phone]     VARCHAR (10)  NULL,
    [Email]     VARCHAR (200) NULL,
    [Gender]    BIT           NULL,
    [City]      VARCHAR (15)  NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC)
);





