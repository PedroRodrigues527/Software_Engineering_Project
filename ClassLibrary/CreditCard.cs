using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CreditCard : ICreditCard, IItem
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string HolderName { get; set; }
        public string ExpirationDate { get; set; }
        public int Pin { get; set; }
        public double Balance { get; set; }

        public bool IsPaymentPositive(double amount)
        {
            return Balance < amount;
        }
       
    }
}
