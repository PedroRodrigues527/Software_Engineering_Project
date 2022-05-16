using ClassLibrary.Database_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandChangeOrderListVideo : ICommand
    {
        public List<Video> NewListVideos;
        public List<Video> OldListVideos;
        public List<Video> ListVideos { get; private set; }
        public IPlaylistData PlaylistData;
        public IVideoData VideoData;
        public Playlist PlaylistEdit;

        public CommandChangeOrderListVideo(List<Video> newListVideos, List<Video> oldListVideos, IPlaylistData playlistData, IVideoData videoData, List<Video> listVideos, Playlist playlistEdit)
        {
            NewListVideos = newListVideos;
            PlaylistData = playlistData;
            OldListVideos = oldListVideos;
            VideoData = videoData;
            ListVideos = listVideos;
            PlaylistEdit = playlistEdit;
        }

        public void Execute()
        {
            foreach(Video video in NewListVideos)
            {
                VideoData.UpdateOrder(video);
            }
            ListVideos = PlaylistData.VideosPlaylistSync(PlaylistData.VideosIdInPlaylistSync(PlaylistEdit));
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            //Set order before swap
            foreach (Video video in OldListVideos)
            {
                VideoData.UpdateOrder(video);
            }
            ListVideos = PlaylistData.VideosPlaylistSync(PlaylistData.VideosIdInPlaylistSync(PlaylistEdit));
        }
    }
}
