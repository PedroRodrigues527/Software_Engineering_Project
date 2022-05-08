using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    interface IYoutubeAPIAccount
    {

        string email { get; }
        string password { set; }

        public void changeAcccount();

        public void syncronize();

        public void searchAccount();

    }
}
