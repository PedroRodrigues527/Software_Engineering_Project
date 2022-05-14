using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandAddListVideo : ICommand
    {
        public List<Video> Playlist { get; }
        public Video UrlVideo;
        
        public CommandAddListVideo(List<Video> playlist, Video urlVideo)
        {
            UrlVideo = urlVideo ?? throw new ArgumentNullException(nameof(UrlVideo));
            Playlist = playlist;
        }

        public void Execute()
        {
            //Add video to playlist
            Playlist.Add(UrlVideo);
            for (int i = 0; i < Playlist.Count(); i++)
            {
                Playlist[i].Order = i;
            }
        }

        public void Redo()
        {
            //Add Video again from playlist
            Execute();
        }

        public void Undo()
        {
            //Remove video from playlist
            Playlist.Remove(UrlVideo);
            for (int i = 0; i < Playlist.Count(); i++)
            {
                Playlist[i].Order = i;
            }
        }
    }
}
