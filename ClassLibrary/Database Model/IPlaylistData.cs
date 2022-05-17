using ClassLibrary.Database_Model;

namespace ClassLibrary
{
    public interface IPlaylistData
    {
        void DeletePlaylist(Playlist playlist);
        Task<List<Playlist>> GetClientPlaylists(User user);
        Task<List<Playlist>> GetPlaylists();
        Task<List<Playlist>> GetResults(string keyword);
        Task InsertPlaylist(Playlist playlist, User user);
        Task<List<Playlist>> GetLatestPlaylistInserted(Playlist playlist, User user);
        Task<List<Playlist>> GetPlaylist(int playlistId);
        Task UpdateTitle(Playlist playlist);
        void UpdateNewTitle(Playlist playlist);
        void UpdateType(Playlist playlist, string typePlaylist);
        Task<List<PlaylistVideos>> VideosIdInPlaylist(Playlist playlist);
        Task<List<Video>> VideosPlaylist(List<PlaylistVideos> videosIdList);
        List<Video> VideosPlaylistSync(List<PlaylistVideos> videosIdList);
        List<PlaylistVideos> VideosIdInPlaylistSync(Playlist playlist);
        void UpdateDate(Playlist playlist);
    }
}