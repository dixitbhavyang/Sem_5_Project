CREATE TABLE [dbo].[Customer] (
    [Id]        INT          NOT NULL,
    [FirstName] VARCHAR (15) NULL,
    [LastName]  VARCHAR (15) NULL,
    [ContactNo] VARCHAR (10) NULL,
    [Email]     VARCHAR (50) NULL,
    [Gender]    BIT          NULL,
    [City]      VARCHAR (15) NULL,
    [Pincode]   VARCHAR (6)  NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC)
);



