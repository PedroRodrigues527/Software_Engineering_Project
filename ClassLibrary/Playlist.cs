using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Playlist
    {

        public int NumberOfVideos { get; set; }
        public int MaximumOfVideos { get; set; }
        public string Title { get; set; }
        public string DataCreation { get; set; }

        public Playlist( int numberOfVideos , int maximumOfVideos , string title , string dataCreation)
        {
            NumberOfVideos = numberOfVideos;
            MaximumOfVideos = maximumOfVideos;
            Title = title;
            DataCreation = dataCreation;
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
