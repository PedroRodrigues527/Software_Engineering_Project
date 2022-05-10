using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    interface IYoutubeAPIAccount
    {

        string _email { get; }
        string _password { set; }

        public void ChangeAcccount();

        public void Syncronize();

        public void SearchAccount();

    }
}
