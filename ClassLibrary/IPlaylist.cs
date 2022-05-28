namespace ClassLibrary
{
    public interface IPlaylist
    {
        string DateCreation { get; set; }
        int Id { get; set; }
        int MaximumOfVideos { get; set; }
        int NumberOfVideos { get; set; }
        int PersonId { get; set; }
        string Title { get; set; }
        EnumPlaylistType Type { get; set; }

        bool isOpen();
    }
}