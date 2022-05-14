using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandAddListVideo : ICommand
    {
        public List<string> Playlist { get; }
        public string UrlVideo;
        
        public CommandAddListVideo(string _UrlVideo)
        {
            UrlVideo = _UrlVideo;
        }

        public void Execute()
        {
            //Add video to playlist
            Playlist.Add(UrlVideo);
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
        }
    }
}
