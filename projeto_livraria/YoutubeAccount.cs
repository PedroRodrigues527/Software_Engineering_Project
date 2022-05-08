using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    public class YoutubeAccount : SyncAccount ,  IYoutubeAPIAccount
    {
        public string email => throw new NotImplementedException();

        public string password { set => throw new NotImplementedException(); }

        public void changeAcccount()
        {
            throw new NotImplementedException();
        }

        public void searchAccount()
        {
            throw new NotImplementedException();
        }

        public void syncronize()
        {
            throw new NotImplementedException();
        }
    }
}
