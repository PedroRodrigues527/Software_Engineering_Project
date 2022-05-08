using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    public class SyncAccount
    {
        private string email { get; set; }
        private string password { get; set; }

        public void changePassword()
        {
            Console.WriteLine( "Changing password from SyncAccount" );
        }

        public void syncronize()
        {
            Console.WriteLine( "Syncronize account from SyncAccount" );
        }
    }
}
