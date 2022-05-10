namespace ClassLibrary
{
    interface ICreditCard
    {
        int number { get; set; }

        string holderName { get; set; }

        string expirationDate { get; set; }

        int pin { get; set; }

        double balance { get; set; }

        public void Payment();

    }
}