using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandAddListVideo : ICommand
    {
        public List<Video> ListVideos { get; }
        public Playlist PlaylistEdit;
        public Video UrlVideo;
        public IVideoData VideoData;
        
        public CommandAddListVideo(List<Video> listVideos, Video urlVideo, IVideoData videoData, Playlist playlistEdit)
        {
            UrlVideo = urlVideo ?? throw new ArgumentNullException(nameof(UrlVideo));
            ListVideos = listVideos;
            VideoData = videoData;
            PlaylistEdit = playlistEdit;
        }

        public void Execute()
        {
            UrlVideo = (VideoData.InsertVideo(UrlVideo)).First();
            VideoData.InsertVideoInPlaylist(UrlVideo, PlaylistEdit);
            ListVideos.Add(UrlVideo);
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
            }
        }

        public void Redo()
        {
            //Add Video again from playlist
            Execute();
        }

        public void Undo()
        {
            VideoData.RemoveVideo(UrlVideo, PlaylistEdit);
            ListVideos.Remove(UrlVideo);
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
            }
        }
    }
}
