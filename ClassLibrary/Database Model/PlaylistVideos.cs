using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Database_Model
{
    [Keyless]
    public class PlaylistVideos : IPlaylistVideos
    {
        public int IdPlaylist { get; set; }
        public int IdVideo { get; set; }
    }
}
