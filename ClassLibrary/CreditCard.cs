using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    public class CreditCard : Item, ICreditCard
    {
        [Required]
        public int Number { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string HolderName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Column(TypeName = "nvarchar(7)")]
        public string ExpirationDate { get; set; }
        [Required]
        [Column(TypeName = "smallint")]
        public int Pin { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public double Balance { get; set; }

        public bool IsPaymentPositive(double amount) => Balance > amount;
    }
}
