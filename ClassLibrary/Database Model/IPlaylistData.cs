using ClassLibrary.Database_Model;

namespace ClassLibrary
{
    public interface IPlaylistData
    {
        Task DeletePlaylist(Playlist playlist);
        Task<List<Playlist>> GetClientPlaylists(User user);
        Task<List<Playlist>> GetPlaylists();
        Task InsertPlaylist(Playlist playlist, User user);
        Task<List<Playlist>> GetLatestPlaylistInserted(Playlist playlist, User user);
        Task<List<Playlist>> GetPlaylist(int playlistId);
        Task UpdateTitle(Playlist playlist);
        Task<List<PlaylistVideos>> VideosIdInPlaylist(Playlist playlist);
        Task<List<Video>> VideosPlaylist(List<PlaylistVideos> videosIdList);
    }
}