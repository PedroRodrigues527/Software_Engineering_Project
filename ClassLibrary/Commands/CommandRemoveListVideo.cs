using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandRemoveListVideo : ICommand
    {
        public List<Video> ListVideos { get; }
        public Video UrlVideo;
        public IVideoData VideoDatabase;
        public Playlist PlaylistEdit;

        public CommandRemoveListVideo(List<Video> listVideos, Video urlVideo, IVideoData videoDatabase, Playlist playlistEdit)
        {
            ListVideos = listVideos;
            UrlVideo = urlVideo;
            VideoDatabase = videoDatabase;
            PlaylistEdit = playlistEdit;
        }

        public void Execute()
        {
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
                VideoDatabase.UpdateOrder(ListVideos[i]);
                if (UrlVideo.Id == ListVideos[i].Id)
                    UrlVideo.Order = i;
            }

            VideoDatabase.RemoveVideo(UrlVideo, PlaylistEdit);
            ListVideos.RemoveAt(UrlVideo.Order);

            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
                VideoDatabase.UpdateOrder(ListVideos[i]);
            }
        }
        public void Redo()
        {
            Execute();
        }
        public void Undo()
        {
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
                VideoDatabase.UpdateOrder(ListVideos[i]);
                if (UrlVideo.Id == ListVideos[i].Id)
                    UrlVideo.Order = i;
            }

            UrlVideo = (VideoDatabase.InsertVideoUndo(UrlVideo)).First();
            VideoDatabase.InsertVideoInPlaylist(UrlVideo, PlaylistEdit);
            ListVideos.Insert(UrlVideo.Order, UrlVideo);

            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
                VideoDatabase.UpdateOrder(ListVideos[i]);
            }
        }

    }
}
