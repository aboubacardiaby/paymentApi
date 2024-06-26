using Paymentapi2;

namespace PaymentApi.Repos
{
    public interface IRepository
    {
        Task<List<Payment>> GetAll();
    }
}
