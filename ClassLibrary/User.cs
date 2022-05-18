using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    public class User : Item, IUser
    {
        [Required]
        public new int Id { get; set; }
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
        [Range(typeof(bool), "true", "true")]
        public bool IsValid { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(150, ErrorMessage = "Biography must be 150 characters or less.")]
        public string Biography { get; set; }
        public PlanPayment Plan { get; set; } = PlanPayment.FREE;
        public string DateExpirationPlan { get; set; }

        public int MaxVideos() => ((int)Plan) * 10;
        public int MaxPlaylists() => ((int)Plan);
    }
}
