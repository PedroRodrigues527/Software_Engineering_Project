using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    public class Playlist : Item
    {
        [Required]
        public new int Id { get; set; }
        public int NumberOfVideos { get; set; }
        public int MaximumOfVideos { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public int PersonId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string DateCreation { get; set; }
        [Required]
        public EnumPlaylistType Type { get; set; } = EnumPlaylistType.PRIVATE;

        public bool isOpen() => Type == EnumPlaylistType.PUBLIC;
    }
}
