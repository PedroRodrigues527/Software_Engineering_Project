CREATE TABLE [dbo].[Playlist] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Title]     NCHAR (16)   COLLATE Latin1_General_CS_AS NOT NULL,
    [PersonId]    INT  NOT NULL,
    [DataCreation] NCHAR(10) NOT NULL, 
    CONSTRAINT [PK_Playlist] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [UC_Playlist] UNIQUE NONCLUSTERED ([Title] ASC), 
);

