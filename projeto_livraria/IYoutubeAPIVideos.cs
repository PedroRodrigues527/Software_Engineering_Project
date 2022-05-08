using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    interface IYoutubeAPIVideos
    {
        string title { get; }

        public string searchVideo( string title );

        public string searchPlaylist(string title);
    
    }
}
