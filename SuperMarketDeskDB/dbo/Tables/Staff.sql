CREATE TABLE [dbo].[Staff] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (15)  NULL,
    [LastName]     VARCHAR (15)  NULL,
    [Phone]        VARCHAR (10)  NULL,
    [Email]        VARCHAR (150) NULL,
    [Gender]       BIT           CONSTRAINT [DF_Staff_Gender] DEFAULT ((1)) NULL,
    [Address]      VARCHAR (200) NULL,
    [DepartmentId] INT           NULL,
    [Salary]       DECIMAL (9)   NULL,
    [JoinDate]     DATETIME      NULL,
    [CreatedDate]  DATETIME      NULL,
    [CreatedBy]    INT           NULL,
    [LastUpdated]  DATETIME      NULL,
    [UpdatedBy]    INT           NULL,
    [Status]       BIT           CONSTRAINT [DF_Staff_Status] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([Id]),
    CONSTRAINT [FK__Staff__CreatedBy__2DB1C7EE] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK__Staff__UpdatedBy__2EA5EC27] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[Users] ([Id])
);





