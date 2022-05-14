using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandRemoveListVideo : ICommand
    {
        public List<Video> Playlist { get; }
        public Video UrlVideo;

        public CommandRemoveListVideo(List<Video> playlist, Video urlVideo)
        {
            UrlVideo = urlVideo;
            Playlist = playlist;
        }

        public void Execute()
        {
            //Remove Video
            Playlist.Remove(UrlVideo);
            for(int i = 0; i < Playlist.Count(); i++)
            {
                Playlist[i].Order = i;
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
            Playlist.Add(UrlVideo);
            for (int i = 0; i < Playlist.Count(); i++)
            {
                Playlist[i].Order = i;
            }
        }
        
    }
}
