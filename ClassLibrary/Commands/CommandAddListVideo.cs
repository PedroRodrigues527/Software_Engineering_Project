using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandAddListVideo : ICommand
    {
        public void Execute()
        {
            //Add video to playlist
            throw new NotImplementedException();
        }

        public void Redo()
        {
            //Add Video again from playlist
            throw new NotImplementedException();
        }

        public void Undo()
        {
            //Remove video from playlist
            throw new NotImplementedException();
        }
    }
}
