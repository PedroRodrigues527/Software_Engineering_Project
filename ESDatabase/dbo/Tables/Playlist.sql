CREATE TABLE [dbo].[Playlist] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NCHAR (16)    COLLATE Latin1_General_CS_AS NOT NULL,
    [ClientName]    NCHAR(16) COLLATE Latin1_General_CS_AS NOT NULL,
    CONSTRAINT [PK_Playlist] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [UC_Playlist] UNIQUE NONCLUSTERED ([Name] ASC), 
    CONSTRAINT [FK_Playlist_User] FOREIGN KEY ([ClientName]) REFERENCES [User]([Username])
);

