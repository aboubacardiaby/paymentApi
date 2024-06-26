namespace PaymentApi
{
    public class Payment
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }
        public string Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
    }
}
