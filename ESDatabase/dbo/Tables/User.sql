CREATE TABLE [dbo].[User] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Username] NCHAR (16)    COLLATE Latin1_General_CS_AS NOT NULL,
    [Email]    NVARCHAR (50) COLLATE Latin1_General_CS_AS NOT NULL,
    [Password] NCHAR (16)    COLLATE Latin1_General_CS_AS NOT NULL,
    [Biography] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [UC_Person] UNIQUE NONCLUSTERED ([Username] ASC)
);

