using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    public class YoutubeAccount : SyncAccount ,  IYoutubeAPIAccount
    {

        public string _email => throw new NotImplementedException();

        public string _password { set => throw new NotImplementedException(); }
        
        public YoutubeAccount(string _email, string _password) : base(_email, _password)
        {
            _email = _email;
            _password = _password;
        }

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
