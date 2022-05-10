using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    public class User : ICreditCard
    {

        public string _userName { get; set; }
        
        public string _email { get; set; }
        public string _password { get; set; }

        public string _biography { get; set; }

        public string _youtubeAccount { get; set; }

        public PlanPayment _Plan { get; set; }

        //Interface variables 
        public int maxPlaylist { get; set; }
        public int number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string holderName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string expirationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int pin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public User( PlanPayment plan ) => _Plan = plan;

        public User(string userName, string email, string password, string biography, string youtubeAccount, PlanPayment plan)
        {
            _userName = userName;
            _email = email;
            _password = password;
            _biography = biography;
            _youtubeAccount = youtubeAccount;
            _Plan = plan;
        }

        public void ChangeBiography( )
        {
            Console.WriteLine( "Changing bio" );
        } 
        public void ChangePassword( )
        {
            Console.WriteLine( "Changing bio" );
        }
        public void UpdatePlan( )
        {
            Console.WriteLine( "Updating plan" );
        }
        public void CanclePlan( )
        {
            Console.WriteLine( "Canceling plan" );
        }

        //Interface Method
        public void Payment()
        {
            throw new NotImplementedException();
        }
    }
}
