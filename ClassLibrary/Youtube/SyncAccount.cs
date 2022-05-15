using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Youtube
{
    public class SyncAccount
    {
        private string email { get; set; }
        private string password { get; set; }

        public SyncAccount( string _email , string _password )
        {
            email = _email;
            password = _password;
        }

        public void ChangePassword()
        {
            Console.WriteLine( "Changing password from SyncAccount" );
        }

        public void Syncronize()
        {
            Console.WriteLine( "Syncronize account from SyncAccount" );
        }
    }
}
