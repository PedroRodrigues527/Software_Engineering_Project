using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandChangeOrderListVideo : ICommand
    {
        public List<Video> ListVideos { get; }
        public List<Video> OldListVideos { get; }
        public Playlist PlaylistEdit;
        public IPlaylistData PlaylistData;
        
        public CommandChangeOrderListVideo(List<Video> listVideos, List<Video> oldListVideos, IPlaylistData playlistData, Playlist playlistEdit)
        {
            ListVideos = listVideos;
            PlaylistData = playlistData;
            PlaylistEdit = playlistEdit;
            OldListVideos = oldListVideos;
        }

        public void Execute()
        {
            
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
            }
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            //Set order before swap
        }
    }
}
