using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Database_Model
{
    public class PlaylistVideos
    {
        public int IdPlaylist { get; set; }
        public int IdVideo { get; set; }
        public int Order { get; set; }
    }
}
