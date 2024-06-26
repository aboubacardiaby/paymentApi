

namespace PaymentApi.Repos
{
    public class Repository:IRepository
    {
        List<Payment> _paymentList;

        public  async Task<List<Payment>> GetAll()
        {
            _paymentList = new List<Payment>();

            DateTime date = DateTime.Now;
            _paymentList.Add(new Payment()
            {
                Amount = "50",
                CardNumber = "445114",
                CVV = "685",
                ExpiryDate = DateTime.Now.ToString(),
                Id = "1",
                Name = "Perry Edwards",
                CreatedDate = date

            });

            //_paymentList.Add(new Payment()
            //{
            //    Amount  = 
            //})
            return _paymentList;
        }
    }
}
