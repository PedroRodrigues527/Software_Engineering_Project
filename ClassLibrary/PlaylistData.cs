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
            string sql = $"insert into dbo.[Playlist] (Title, PersonUsername, DataCreation) values ({playlist.Title}, {user.Username}, {localDate});";

            return _db.SaveData(sql, playlist);
        }

        public Task<List<Playlist>> GetClientPlaylists(User user)
        {
            string sql = $"SELECT * FROM dbo.[Playlist] WHERE [PersonUsername]='{user.Username.Trim()}';";

            return _db.LoadData<Playlist, dynamic>(sql, new { });
        }
    }
}
