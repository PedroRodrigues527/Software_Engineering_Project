using ClassLibrary.Database_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PlaylistData : IPlaylistData
    {
        private readonly ISqlDataAccess _db;

        public PlaylistData(ISqlDataAccess db)
        {
            _db = db;
        }


        public Task<List<Playlist>> GetPlaylists()
        {
            string sql = "select * from dbo.[Playlist]";

            return _db.LoadData<Playlist, dynamic>(sql, new { });
        }

        public Task InsertPlaylist(Playlist playlist, User user)
        {
            string localDate = DateTime.Now.Date.ToString("yyyyMMdd");
            string sql = $"insert into dbo.[Playlist] (Title, PersonId, DateCreation) values ('{playlist.Title}', '{user.Id}', '{localDate}');";

            return _db.SaveData(sql, playlist);
        }

        public Task<List<Playlist>> GetClientPlaylists(User user)
        {
            string sql = $"SELECT * FROM dbo.[Playlist] WHERE [PersonId] = '{user.Id}';";

            return _db.LoadData<Playlist, dynamic>(sql, new { });
        }

        public Task<List<Playlist>> GetPlaylist(int playlistId)
        {
            string sql = $"SELECT * FROM dbo.[Playlist] WHERE [ID] = '{playlistId}';";

            return _db.LoadData<Playlist, dynamic>(sql, new { });
        }

        public Task DeletePlaylist(Playlist playlist)
        {
            string sql = $"DELETE FROM dbo.[Playlist] WHERE [ID]='{playlist.Id}';";

            return _db.SaveData(sql, playlist);
        }

        public Task<List<Playlist>> GetLatestPlaylistInserted(Playlist playlist, User user)
        {
            string localDate = DateTime.Now.Date.ToString("yyyyMMdd");
            string sql = $"insert into dbo.[Playlist] (Title, PersonId, DateCreation) values ('{playlist.Title}', '{user.Id}', '{localDate}');\n" +
                $"SELECT * FROM dbo.[Playlist] WHERE [ID] = SCOPE_IDENTITY();";

            return _db.LoadData<Playlist, dynamic>(sql, new { });
        }

        public Task UpdateTitle(Playlist playlist)
        {
            string sql = $"UPDATE dbo.[Playlist] SET [Title] = '{playlist.Id}' WHERE [ID] = '{playlist.Id}';";

            return _db.SaveData(sql, playlist);
        }

        public Task UpdateNewTitle(Playlist playlist)
        {
            string sql = $"UPDATE dbo.[Playlist] SET [Title] = '{playlist.Title}' WHERE [ID] = '{playlist.Id}';";

            return _db.SaveData(sql, playlist);
        }

        public Task<List<PlaylistVideos>> VideosIdInPlaylist(Playlist playlist)
        {
            string sql = $"SELECT * FROM dbo.[PlaylistVideo] WHERE [IDPlaylist] = '{playlist.Id}';";

            return _db.LoadData<PlaylistVideos, dynamic>(sql, new { });
        }

        public Task<List<Video>> VideosPlaylist(List<PlaylistVideos> videosIdList)
        {
            string sql = $"SELECT * FROM dbo.[Video] WHERE [ID] IN (";
            foreach(PlaylistVideos videoInPlaylist in videosIdList)
            {
                sql += $"{videoInPlaylist.IdVideo}, ";
            }
            sql = sql.Remove(sql.Length-2);
            sql += ");";

            return _db.LoadData<Video, dynamic>(sql, new { });
        }

        public Task<List<Playlist>> GetResults(string keyword)
        {
            string sql = $"Select * From dbo.[Playlist] Where [Title] LIKE '%{keyword}%'";
            return _db.LoadData<Playlist, dynamic>(sql, new { });
        }

    }
}
