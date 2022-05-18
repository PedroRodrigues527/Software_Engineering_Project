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

        public Task<List<Playlist>> GetPlaylists() => _db.LoadData<Playlist, dynamic>(
            "select * " +
            "from dbo.[Playlist]", new { });

        public Task InsertPlaylist(Playlist playlist, User user) => _db.SaveData(
            $"insert into dbo.[Playlist] (Title, PersonId, DateCreation) " +
            $"values ('{playlist.Title}', '{user.Id}', '{DateTime.Now.Date.ToString("yyyyMMdd")}');", playlist);

        public Task<List<Playlist>> GetClientPlaylists(User user) => _db.LoadData<Playlist, dynamic>(
            $"SELECT * " +
            $"FROM dbo.[Playlist] " +
            $"WHERE [PersonId] = '{user.Id}';", new { });

        public Task<List<Playlist>> GetPlaylist(int playlistId) => _db.LoadData<Playlist, dynamic>(
            $"SELECT * " +
            $"FROM dbo.[Playlist] " +
            $"WHERE [ID] = '{playlistId}';", new { });

        public void DeletePlaylist(Playlist playlist) => _db.SaveData(
            $"DELETE FROM dbo.[Playlist] " +
            $"WHERE [ID]='{playlist.Id}';", playlist);

        public Task<List<Playlist>> GetLatestPlaylistInserted(Playlist playlist, User user) => _db.LoadData<Playlist, dynamic>(
            $"insert into dbo.[Playlist] (Title, PersonId, DateCreation) " +
            $"values ('{playlist.Title}', '{user.Id}', '{DateTime.Now.Date.ToString("yyyyMMdd")}');\n" +
            $"SELECT * FROM dbo.[Playlist] WHERE [ID] = SCOPE_IDENTITY();", new { });

        public Task UpdateTitle(Playlist playlist) => _db.SaveData(
            $"UPDATE dbo.[Playlist] " +
            $"SET [Title] = '{playlist.Id}' " +
            $"WHERE [ID] = '{playlist.Id}';", playlist);

        public void UpdateNewTitle(Playlist playlist) => _db.SaveDataSync(
            $"UPDATE dbo.[Playlist] " +
            $"SET [Title] = '{playlist.Title}' " +
            $"WHERE [ID] = '{playlist.Id}';", playlist);

        public void UpdateType(Playlist playlist, string typePlaylist) => _db.SaveDataSync(
            $"UPDATE dbo.[Playlist] " +
            $"SET [Type] = '{typePlaylist}' " +
            $"WHERE [ID] = '{playlist.Id}';", playlist);

        public Task<List<PlaylistVideos>> VideosIdInPlaylist(Playlist playlist) => _db.LoadData<PlaylistVideos, dynamic>(
            $"SELECT * " +
            $"FROM dbo.[PlaylistVideo] " +
            $"WHERE [IDPlaylist] = '{playlist.Id}';", new { });

        public List<PlaylistVideos> VideosIdInPlaylistSync(Playlist playlist) => _db.LoadDataSync<PlaylistVideos, dynamic>(
            $"SELECT * " +
            $"FROM dbo.[PlaylistVideo] " +
            $"WHERE [IDPlaylist] = '{playlist.Id}';", new { });

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

        public List<Video> VideosPlaylistSync(List<PlaylistVideos> videosIdList)
        {
            string sql = $"SELECT * FROM dbo.[Video] WHERE [ID] IN (";
            foreach (PlaylistVideos videoInPlaylist in videosIdList)
            {
                sql += $"{videoInPlaylist.IdVideo}, ";
            }
            sql = sql.Remove(sql.Length - 2);
            sql += ");";

            return _db.LoadDataSync<Video, dynamic>(sql, new { });
        }

        public Task<List<Playlist>> GetResults(string keyword) => _db.LoadData<Playlist, dynamic>(
            $"Select * " +
            $"From dbo.[Playlist] " +
            $"Where [Title] LIKE '%{keyword}%' AND [Type] = 'PUBLIC'", new { });

        public void UpdateDate(Playlist playlist) => _db.SaveDataSync(
            $"UPDATE dbo.[Playlist] " +
            $"SET [DateCreation] = '{playlist.DateCreation}' " +
            $"WHERE [ID] = '{playlist.Id}';", playlist);
    }
}
