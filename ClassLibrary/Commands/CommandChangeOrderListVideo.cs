﻿using ClassLibrary.Database_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandChangeOrderListVideo : ICommand
    {
        public List<Video> NewListVideos;
        public List<Video> OldListVideos;
        public List<Video> ListVideos { get; set; }
        public IPlaylistData PlaylistData;
        public IVideoData VideoData;
        public Playlist PlaylistEdit;

        public CommandChangeOrderListVideo(List<Video> newListVideos, List<Video> oldListVideos, IPlaylistData playlistData, IVideoData videoData, List<Video> listVideos, Playlist playlistEdit)
        {
            NewListVideos = newListVideos;
            PlaylistData = playlistData;
            OldListVideos = oldListVideos;
            VideoData = videoData;
            ListVideos = listVideos;
            PlaylistEdit = playlistEdit;
        }

        public void Execute()
        {
            ListVideos.Clear();
            foreach (Video video in NewListVideos)
            {
                VideoData.UpdateOrder(video);
                ListVideos.Add(video);
            }
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
            }

        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            //Set order before swap
            ListVideos.Clear();
            foreach (Video video in OldListVideos)
            {
                VideoData.UpdateOrder(video);
                ListVideos.Add(video);
            }
            for (int i = 0; i < ListVideos.Count; i++)
            {
                ListVideos[i].Order = i;
            }

        }
    }
}
