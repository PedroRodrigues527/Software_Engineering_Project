using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandRemoveListVideo : ICommand
    {
        public List<string> Playlist { get; }
        public string UrlVideo;

        public CommandRemoveListVideo(string _UrlVideo)
        {
            UrlVideo = _UrlVideo;
        }

        public void Execute()
        {
            //Remove Video
            Playlist.Remove(UrlVideo);
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
        }
        
    }
}
