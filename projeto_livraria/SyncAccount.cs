using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    public class SyncAccount
    {
        private string _email { get; set; }
        private string _password { get; set; }

        public SyncAccount( string _email , string _password )
        {
            _email = _email;
            _password = _password;
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
