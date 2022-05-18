using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public string ExpirationDate { get; set; }
        [Required]
        public int Pin { get; set; }
        [Required]
        public double Balance { get; set; }

        public bool IsPaymentPositive(double amount) => Balance < amount;
    }
}
