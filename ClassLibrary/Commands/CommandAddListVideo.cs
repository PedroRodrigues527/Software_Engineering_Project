using ClassLibrary.Database_Model;

namespace ClassLibrary.Commands
{
    public class CommandAddListVideo : ICommand
    {
        public List<Video> ListVideos { get; }
        public Playlist PlaylistEdit;
        public Video VideoAdded;
        public IVideoData VideoDatabase;

        public CommandAddListVideo(List<Video> listVideos, Video videoAdded, IVideoData videoDatabase, Playlist playlistEdit)
        {
            VideoAdded = videoAdded ?? throw new ArgumentNullException(nameof(VideoAdded));
            ListVideos = listVideos;
            VideoDatabase = videoDatabase;
            PlaylistEdit = playlistEdit;
        }

        public void Execute()
        {
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
                VideoDatabase.UpdateOrder(ListVideos[i]);
                if (VideoAdded.Id == ListVideos[i].Id)
                    VideoAdded.Order = i;
            }

            VideoAdded = (VideoDatabase.InsertVideo(VideoAdded)).First();
            VideoDatabase.InsertVideoInPlaylist(VideoAdded, PlaylistEdit);
            ListVideos.Insert(VideoAdded.Order, VideoAdded);

            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
                VideoDatabase.UpdateOrder(ListVideos[i]);
            }
        }
        public void Redo()
        {
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
                VideoDatabase.UpdateOrder(ListVideos[i]);
                if (VideoAdded.Id == ListVideos[i].Id)
                    VideoAdded.Order = i;
            }

            VideoAdded = (VideoDatabase.InsertVideoUndo(VideoAdded)).First();
            VideoDatabase.InsertVideoInPlaylist(VideoAdded, PlaylistEdit);
            ListVideos.Insert(VideoAdded.Order, VideoAdded);

            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
                VideoDatabase.UpdateOrder(ListVideos[i]);
            }
        }
        public void Undo()
        {
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
                VideoDatabase.UpdateOrder(ListVideos[i]);
                if (VideoAdded.Id == ListVideos[i].Id)
                    VideoAdded.Order = i;
            }

            VideoDatabase.RemoveVideo(VideoAdded, PlaylistEdit);
            ListVideos.RemoveAt(VideoAdded.Order);

            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
                VideoDatabase.UpdateOrder(ListVideos[i]);
            }
        }
    }
}
