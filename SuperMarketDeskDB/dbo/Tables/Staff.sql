CREATE TABLE [dbo].[Staff] (
    [Id]          INT          NOT NULL,
    [FirstName]   VARCHAR (15) NULL,
    [LastName]    VARCHAR (15) NULL,
    [Contact]     VARCHAR (10) NULL,
    [Email]       VARCHAR (50) NULL,
    [Gender]      BIT          NULL,
    [Department]  VARCHAR (15) NULL,
    [Designation] VARCHAR (15) NULL,
    [City]        VARCHAR (20) NULL,
    [Pincode]     VARCHAR (6)  NULL,
    [JoinedDate]  DATETIME     NULL,
    [Status]      BIT          NULL,
    [CreatedDate] DATETIME     NULL,
    [CreatedBy]   INT          NULL,
    [UpdatedDate] DATETIME     NULL,
    [UpdatedBy]   INT          NULL,
    CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED ([Id] ASC)
);



