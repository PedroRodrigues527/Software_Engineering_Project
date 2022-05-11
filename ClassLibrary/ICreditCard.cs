namespace ClassLibrary
{
    interface ICreditCard
    {
        int Number { get; set; }

        string HolderName { get; set; }

        string ExpirationDate { get; set; }

        int Pin { get; set; }

        double Balance { get; set; }

        public void Payment();

    }
}