using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    interface IYoutubeAPIVideos
    {
        string title { get; }

        public string SearchVideo( string title );

        public string SearchPlaylist(string title);
    
    }
}
