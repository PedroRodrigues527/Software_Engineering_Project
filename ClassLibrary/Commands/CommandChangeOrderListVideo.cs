using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandChangeOrderListVideo : ICommand
    {
        public List<Video> ListVideos;
        public List<Video> OldListVideos;
        public IPlaylistData PlaylistData;
        public IVideoData VideoData;

        public CommandChangeOrderListVideo(List<Video> listVideos, List<Video> oldListVideos, IPlaylistData playlistData, IVideoData videoData)
        {
            ListVideos = listVideos;
            PlaylistData = playlistData;
            OldListVideos = oldListVideos;
            VideoData = videoData;
        }

        public void Execute()
        {
            foreach(Video video in ListVideos)
            {
                VideoData.UpdateOrder(video);
            }

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
        }
    }
}
