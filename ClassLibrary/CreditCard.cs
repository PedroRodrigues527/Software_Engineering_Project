using System.ComponentModel.DataAnnotations;

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
        public string ExpirationDate { get; set; }
        [Required]
        public int Pin { get; set; }
        [Required]
        public double Balance { get; set; }

        public bool IsPaymentPositive(double amount) => Balance < amount;
    }
}
