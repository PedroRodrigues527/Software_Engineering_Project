using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    public class User : ICreditCard
    {

        public string userName { get; set; }
        
        public string email { get; set; }
        public string password { get; set; }

        public string biography { get; set; }

        public string youtubeAccount { get; set; }

        public PlanPayment Plan { get; set; }


        //Interface variables 
        public int maxPlaylist { get; set; }
        public int number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string holderName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string expirationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int pin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public User( PlanPayment plan ) => Plan = plan;

        public void changeBiography( )
        {
            Console.WriteLine( "Changing bio" );
        } 
        public void changePassword( )
        {
            Console.WriteLine( "Changing bio" );
        }
        public void updatePlan( )
        {
            Console.WriteLine( "Updating plan" );
        }
        public void canclePlan( )
        {
            Console.WriteLine( "Canceling plan" );
        }

        //Interface Method
        public void payment()
        {
            throw new NotImplementedException();
        }
    }
}
