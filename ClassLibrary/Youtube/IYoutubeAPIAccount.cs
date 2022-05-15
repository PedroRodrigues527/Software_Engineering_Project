using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Youtube
{
    interface IYoutubeAPIAccount
    {

        string  Email { get; }
        string  Password { set; }

        public void ChangeAcccount();

        public void Syncronize();

        public void SearchAccount();

    }
}
