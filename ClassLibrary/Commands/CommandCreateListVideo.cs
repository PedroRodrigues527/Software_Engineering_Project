using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandCreateListVideo : ICommand
    {
        public CommandCreateListVideo(Video newVideoData, int order)
        {
            NewVideoData = newVideoData;
            NewOrder = order;
        }

        public Video NewVideoData { get; }
        public int NewOrder { get; }
        public Video? NewVideo { get; private set; }

        public void Execute()
        {
            NewVideo = new Video { VideoId = NewVideoData.VideoId, Title = NewVideoData.Title, ChannelName = NewVideoData.ChannelName, Thumbnail = NewVideoData.Thumbnail, Order = NewOrder };
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            NewVideo = null;
        }
    }
}
