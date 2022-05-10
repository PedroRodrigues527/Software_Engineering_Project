using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    public class Playlist
    {

        public int _numberOfVideos { get; set; }
        public int _maximumOfVideos { get; set; }
        public string _title { get; set; }
        public string _dataCreation { get; set; }

        public Playlist( int numberOfVideos , int maximumOfVideos , string title , string dataCreation)
        {
            _numberOfVideos = numberOfVideos;
            _maximumOfVideos = maximumOfVideos;
            _title = title;
            _dataCreation = dataCreation;
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
