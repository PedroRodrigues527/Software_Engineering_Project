CREATE TABLE [dbo].[Video] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Url]      NVARCHAR(MAX) COLLATE Latin1_General_CS_AS NOT NULL,
    [Title]    NVARCHAR(MAX) COLLATE Latin1_General_CS_AS NULL,
    [Editor]   NVARCHAR(MAX) COLLATE Latin1_General_CS_AS NULL,
    [Order]    INT           NULL,
    CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED ([ID] ASC)
);

