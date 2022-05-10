using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    public class Video : IYoutubeAPIVideos
    {

        public string artist { get; set; }
        public string dataCreating { get; set; }
        public string url { get; set; }
        public string title => throw new NotImplementedException();

        public string SearchPlaylist(string title)
        {
            throw new NotImplementedException();
        }

        public string SearchVideo(string title)
        {
            throw new NotImplementedException();
        }
    }
}
