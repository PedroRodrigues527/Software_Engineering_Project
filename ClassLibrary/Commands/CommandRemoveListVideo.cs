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
        public IVideoData VideoData;
        public Playlist PlaylistEdit;

        public CommandRemoveListVideo(List<Video> Listvideos, Video urlVideo, IVideoData videoData, Playlist playlistEdit)
        {
            ListVideos = Listvideos;
            UrlVideo = urlVideo;
            VideoData = videoData;
            PlaylistEdit = playlistEdit;
        }

        public void Execute()
        {
            //Remove Video
            VideoData.RemoveVideo(UrlVideo, PlaylistEdit);
            ListVideos.Remove(UrlVideo);
            for(int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
            }
        }

        public void Redo()
        {
            //Remove again from playlist
            Execute();
        }

        public void Undo()
        {
            //Add video to playlist
            UrlVideo = (VideoData.InsertVideo(UrlVideo)).First();
            VideoData.InsertVideoInPlaylist(UrlVideo, PlaylistEdit);
            ListVideos.Add(UrlVideo);
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
            }
        }
        
    }
}
