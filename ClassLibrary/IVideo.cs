namespace ClassLibrary
{
    public interface IVideo
    {
        string ChannelName { get; set; }
        bool IsDragOver { get; set; }
        int Order { get; set; }
        string Thumbnail { get; set; }
        string Title { get; set; }
        string VideoId { get; set; }
    }
}