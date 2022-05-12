CREATE TABLE [dbo].[Video] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Title]     NCHAR (16)    COLLATE Latin1_General_CS_AS NULL,
    [Editor]    NCHAR(16) COLLATE Latin1_General_CS_AS NULL,
    CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED ([ID] ASC)
);

