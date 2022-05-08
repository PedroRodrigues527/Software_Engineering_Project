using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_livraria
{
    public class User
    {

        public string userName { get; set; }
        
        public string email { get; set; }
        public string password { get; set; }

        public string biography { get; set; }

        public string youtubeAccount { get; set; }

        //public PlanPayment plan { get; set; }
        public int maxPlaylist { get; set; }   

    
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


        
    
    }
}
