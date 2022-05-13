using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    public class Playlist : IItem
    {
        [Required]
        public int Id { get; set; }
        public int NumberOfVideos { get; set; }
        public int MaximumOfVideos { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string PersonUsername { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string DataCreation { get; set; }
        [Required]
        public EnumPlaylistType Type { get; set; } = EnumPlaylistType.PRIVATE;

        public Playlist() { }
        public Playlist( int numberOfVideos , int maximumOfVideos , string title , string dataCreation)
        {
            NumberOfVideos = numberOfVideos;
            MaximumOfVideos = maximumOfVideos;
            Title = title;
            DataCreation = dataCreation;
        }

        public bool isOpen()
        {
            return Type == EnumPlaylistType.PUBLIC;
        }


        //NAO CHAMAR DIRETAMENTE new Playlist() FAZER
        //TALVEZ FACTORY PATTERN!
        public Playlist CreatePlaylist()
        {
            Console.WriteLine( "Removing videos..." );
            return new Playlist( 0 , 10 , "NEW_PLAYLIST_TESTE" , "10/5/2022" );
        }

        public void DeletePlaylist()
        {
            Console.WriteLine( "Deleting playlist..." );
        }

        public void OrderVideos()
        {
            Console.WriteLine( "Ordering videos..." );
        }

        public void PlayPlaylist()
        {
            Console.WriteLine( "Playing playlist..." );
        }

        public void AddVideo()
        {
            Console.WriteLine( "Adding videos..." );
        }

        public void RemoveVideos()
        {
            Console.WriteLine( "Removing videos..." );
        }

    }
}
