CREATE TABLE [dbo].[PlaylistVideo] (
    [IDPlaylist]       INT           NOT NULL,
    [IDVideo]          INT           NOT NULL, 
    CONSTRAINT [FK_Playlist] FOREIGN KEY ([IDPlaylist]) REFERENCES [Playlist]([ID]),
    CONSTRAINT [FK_Video] FOREIGN KEY ([IDVideo]) REFERENCES [Video]([ID]),
);

