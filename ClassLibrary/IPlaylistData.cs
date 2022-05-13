
namespace ClassLibrary
{
    public interface IPlaylistData
    {
        Task<List<Playlist>> GetClientPlaylists(User user);
        Task<List<Playlist>> GetPlaylists();
        Task InsertPlaylist(Playlist playlist, User user);
    }
}