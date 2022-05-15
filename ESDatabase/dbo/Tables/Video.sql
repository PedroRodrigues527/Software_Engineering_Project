CREATE TABLE [dbo].[Video] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [VideoId]      NVARCHAR(11) COLLATE Latin1_General_CS_AS NOT NULL,
    [Title]    NVARCHAR(MAX) COLLATE Latin1_General_CS_AS NULL,
    [ChannelName]   NVARCHAR(MAX) COLLATE Latin1_General_CS_AS NULL,
    [Thumbnail]   NVARCHAR(MAX) COLLATE Latin1_General_CS_AS NULL,
    [Order]    INT           NULL,
    CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED ([ID] ASC)
);

