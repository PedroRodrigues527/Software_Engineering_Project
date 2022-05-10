using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    public class User : ICreditCard
    {
        [Required]
        [StringLength(16, ErrorMessage = "Username must be 16 characters or less.")]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "Password must be 16 characters or less.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "Confirm Password must be 16 characters or less.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The Password Confirmation does not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Range(typeof(bool), "true", "true",
        ErrorMessage = "Please accept the Terms of Service.")]
        public bool IsValid { get; set; }

        public string Biography { get; set; }

        public string YoutubeAccount { get; set; }

        public PlanPayment Plan { get; set; }

        //Interface variables 
        public int maxPlaylist { get; set; }
        public int number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string holderName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string expirationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int pin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public User( PlanPayment plan ) => _Plan = plan;
        /*
        public User(string userName, string email, string password, string biography, string youtubeAccount, PlanPayment plan)
        {
            _userName = userName;
            _email = email;
            _password = password;
            _biography = biography;
            _youtubeAccount = youtubeAccount;
            _Plan = plan;
        }
        */

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
