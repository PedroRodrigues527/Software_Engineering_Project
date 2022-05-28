using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    public class Playlist : Item, IPlaylist
    {
        [Required]
        public new int Id { get; set; }
        [NotMapped]
        public int NumberOfVideos { get; set; }
        [NotMapped]
        public int MaximumOfVideos { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Column(TypeName = "nchar(16)")]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public int PersonId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Column(TypeName = "nchar(10)")]
        public string DateCreation { get; set; }
        [Required]
        [Column(TypeName = "nchar(16)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public EnumPlaylistType Type { get; set; } = EnumPlaylistType.PRIVATE;

        public bool isOpen() => Type == EnumPlaylistType.PUBLIC;
    }
}
