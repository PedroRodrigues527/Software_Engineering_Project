
namespace ClassLibrary
{
    public interface IVideoData
    {
        List<Video> FindVideo(Video video);
        List<Video> GetVideos();
        List<Video> InsertVideo(Video video);
        void InsertVideoInPlaylist(Video video, Playlist playlist);
        void RemoveVideo(Video video, Playlist playlist);
        void UpdateOrder(Video video);
    }
}