using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Video : IItem
    {
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public string VideoId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool IsDragOver { get; set; }
        public string Thumbnail { get; set; }
    }
}
