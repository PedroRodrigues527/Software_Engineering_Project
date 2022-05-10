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

        public string SarchVideo( string title );

        public string SearchPlaylist(string title);
    
    }
}
