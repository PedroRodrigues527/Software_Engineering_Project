using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Video : IYoutubeAPIVideos
    {

        public string Artist { get; set; }
        public string DataCreating { get; set; }
        public string Url { get; set; }
        public string Title => throw new NotImplementedException();

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
