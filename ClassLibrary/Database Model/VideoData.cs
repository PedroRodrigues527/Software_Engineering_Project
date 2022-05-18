using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class VideoData : IVideoData
    {
        private readonly ISqlDataAccess _db;

        public VideoData(ISqlDataAccess db)
        {
            _db = db;
        }

        public List<Video> GetVideos() => _db.LoadDataSync<Video, dynamic>(
            "select * " +
            "from dbo.[Video]", new { });
        public List<Video> InsertVideo(Video video) => _db.LoadDataSync<Video, dynamic>(
            @"insert into dbo.[Video] (VideoId, Title, ChannelName, Thumbnail, [Order]) 
            values (@VideoId, @Title, @ChannelName, @Thumbnail, @Order); " +
            $"SELECT * FROM dbo.[Video] WHERE [ID] = SCOPE_IDENTITY();", video);
        public List<Video> InsertVideoUndo(Video video) => _db.LoadDataSync<Video, dynamic>(
            $"SET IDENTITY_INSERT dbo.[Video] ON; \n" +
            @"insert into dbo.[Video] (ID, VideoId, Title, ChannelName, Thumbnail, [Order]) 
            values (@Id, @VideoId, @Title, @ChannelName, @Thumbnail, @Order); " +
            $"SELECT * FROM dbo.[Video] WHERE [ID] = SCOPE_IDENTITY(); " +
            $"SET IDENTITY_INSERT dbo.[Video] OFF;", video);
        public void InsertVideoInPlaylist(Video video, Playlist playlist) => _db.SaveDataSync(
            $"insert into dbo.[PlaylistVideo] (IDPlaylist, IDVideo)" +
            $" values ('{playlist.Id}','{video.Id}');", new { });
        public void RemoveVideo(Video video, Playlist playlist) => _db.SaveDataSync(
            $"DELETE FROM dbo.[PlaylistVideo] " +
            $" WHERE [IDPlaylist]='{playlist.Id}' AND [IDVideo]='{video.Id}';\n" +
            $"DELETE FROM dbo.[Video] WHERE [ID] ='{video.Id}';", new { });
        public void UpdateOrder(Video video) => _db.SaveData(
            $"UPDATE dbo.[Video]" +
            $" SET [Order] = '{video.Order}' " +
            $"WHERE [ID] = '{video.Id}';", new { });

        public void DeleteUnusedVideos() => _db.SaveDataSync(
            $"DELETE FROM dbo.[Video]" +
            $" WHERE [Id] NOT IN (SELECT [IDVideo] FROM dbo.[PlaylistVideo]);", new { });
    }
}
