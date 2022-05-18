
namespace ClassLibrary
{
    public interface IVideoData
    {
        List<Video> GetVideos();
        List<Video> InsertVideo(Video video);
        List<Video> InsertVideoUndo(Video video);
        void InsertVideoInPlaylist(Video video, Playlist playlist);
        void RemoveVideo(Video video, Playlist playlist);
        void UpdateOrder(Video video);
        void DeleteUnusedVideos();
    }
}