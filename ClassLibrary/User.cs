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
        [Column(TypeName = "nchar(16)")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "Password must be 16 characters or less.")]
        [DataType(DataType.Password)]
        [Column(TypeName = "nchar(16)")]
        public string Password { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "Confirm Password must be 16 characters or less.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The Password Confirmation does not match.")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [Required]
        [Range(typeof(bool), "true", "true")]
        [NotMapped]
        public bool IsValid { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(150, ErrorMessage = "Biography must be 150 characters or less.")]
        [Column(TypeName = "nvarchar(150)")]
        public string Biography { get; set; }
        [Column(TypeName = "nchar(16)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public PlanPayment Plan { get; set; } = PlanPayment.FREE;
        [Column(TypeName = "nchar(10)")]
        public string DateExpirationPlan { get; set; }

        public int MaxVideos() => ((int)(5 * Math.Pow((int)Plan, 2) + 35 * ((int)Plan) + 10)) * 10;
        public int MaxPlaylists() => (int)(5 * Math.Pow((int)Plan, 2) + 35 * ((int)Plan) + 10);
    }
}
