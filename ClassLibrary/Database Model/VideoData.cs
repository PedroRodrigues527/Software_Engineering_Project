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

        public List<Video> GetVideos()
        {
            string sql = "select * from dbo.[Video]";

            return _db.LoadDataSync<Video, dynamic>(sql, new { });
        }

        public List<Video> FindVideo(Video video)
        {
            string sql = $"select * from dbo.[Video] where [VideoId] = '{video.VideoId}' AND [Order] = '{video.Order}';";

            return _db.LoadDataSync<Video, dynamic>(sql, new { });
        }

        public List<Video> InsertVideo(Video video)
        {
            string sql = @"insert into dbo.[Video] (VideoId, Title, ChannelName, Thumbnail, [Order])
                           values (@VideoId, @Title, @ChannelName, @Thumbnail, @Order); " +
                           $"SELECT * FROM dbo.[Video] WHERE [ID] = SCOPE_IDENTITY();";

            return _db.LoadDataSync<Video, dynamic>(sql, video);
        }

        public void InsertVideoInPlaylist(Video video, Playlist playlist)
        {
            string sql = $"insert into dbo.[PlaylistVideo] (IDPlaylist, IDVideo) values ('{playlist.Id}','{video.Id}');";

            _db.SaveDataSync(sql, new { });
        }

        public void RemoveVideo(Video video, Playlist playlist)
        {
            string sql = $"DELETE FROM dbo.[PlaylistVideo] WHERE [IDPlaylist]='{playlist.Id}' AND [IDVideo]='{video.Id}';\n" +
                $"DELETE FROM dbo.[Video] WHERE [ID] ='{video.Id}';";

            _db.SaveDataSync(sql, new { });
        }

        public void UpdateOrder(Video video)
        {
            string sql = $"UPDATE dbo.[Video] SET [Order] = '{video.Order}' WHERE [ID] = '{video.Id}';";

            _db.SaveData(sql, new { });
        }
    }
}
