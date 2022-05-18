namespace ClassLibrary
{
    public class Video : Item
    {
        public string ChannelName { get; set; }
        public string VideoId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool IsDragOver { get; set; }
        public string Thumbnail { get; set; }
    }
}
