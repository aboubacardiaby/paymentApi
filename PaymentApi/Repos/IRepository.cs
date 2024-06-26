namespace PaymentApi.Repos
{
    public interface IRepository
    {
       Task< List<Payment>> GetAll();
    }
}
