using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandCreateListVideo : ICommand
    {
        public CommandCreateListVideo(string url, int order)
        {
            UrlInserted = url;
            NewOrder = order;
        }

        public string UrlInserted { get; }
        public int NewOrder { get; }
        public Video? NewVideo { get; private set; }

        public void Execute()
        {
            NewVideo = new Video { Url = UrlInserted, Order = NewOrder };
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
