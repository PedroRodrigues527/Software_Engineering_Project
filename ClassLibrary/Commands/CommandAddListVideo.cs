using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandAddListVideo : ICommand
    {
        public List<Video> ListVideos { get; }
        public Playlist PlaylistEdit;
        public Video VideoAdded;
        public IVideoData VideoDatabase;
        
        public CommandAddListVideo(List<Video> listVideos, Video videoAdded, IVideoData videoDatabase, Playlist playlistEdit)
        {
            VideoAdded = videoAdded ?? throw new ArgumentNullException(nameof(VideoAdded));
            ListVideos = listVideos;
            VideoDatabase = videoDatabase;
            PlaylistEdit = playlistEdit;
        }

        public void Execute()
        {
            VideoAdded = (VideoDatabase.InsertVideo(VideoAdded)).First();
            VideoDatabase.InsertVideoInPlaylist(VideoAdded, PlaylistEdit);
            ListVideos.Add(VideoAdded);
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
            }
        }
        public void Redo()
        {
            //Add Video again from playlist
            Execute();
        }
        public void Undo()
        {
            VideoDatabase.RemoveVideo(VideoAdded, PlaylistEdit);
            ListVideos.Remove(VideoAdded);
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
            }
        }
    }
}
