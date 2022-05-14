using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class CommandRemoveListVideo : ICommand
    {
        public void Execute()
        {
            //Remove Video
            throw new NotImplementedException();
        }

        public void Redo()
        {
            //Remove again from playlist
            throw new NotImplementedException();
        }

        public void Undo()
        {
            //Add video to playlist
            throw new NotImplementedException();
        }
    }
}
