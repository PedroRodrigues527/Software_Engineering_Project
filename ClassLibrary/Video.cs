using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    public class Video : Item, IVideo
    {
        [Column(TypeName = "nvarchar(max)")]
        public string ChannelName { get; set; }
        [Column(TypeName = "nchar(11)")]
        public string VideoId { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Title { get; set; }
        public int Order { get; set; }
        [NotMapped]
        public bool IsDragOver { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Thumbnail { get; set; }
    }
}
