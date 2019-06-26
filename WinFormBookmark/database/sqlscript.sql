CREATE TABLE [dbo].[Bookmark] (
    [Name]    VARCHAR (500)  NOT NULL,
    [Type]    VARCHAR (50)   NULL,
    [Status]  VARCHAR (15)   NULL,
    [Minimum] INT            NULL,
    [Maximum] INT            NULL,
    [Current] VARCHAR (5)    NULL,
    [Info]    VARCHAR (1000) NULL
);

