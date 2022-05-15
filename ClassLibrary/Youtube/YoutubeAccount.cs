using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Youtube
{
    public class YoutubeAccount : SyncAccount ,  IYoutubeAPIAccount
    {

        public string Email
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public  string Password
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public YoutubeAccount(string email, string password) : base( email, password )
        {
            Email = email;
            Password = password;
        }
        

        public void ChangeAcccount()
        {
            throw new NotImplementedException();
        }

        public void SearchAccount()
        {
            throw new NotImplementedException();
        }

        public void Syncronize()
        {
            throw new NotImplementedException();
        }
    }
}
