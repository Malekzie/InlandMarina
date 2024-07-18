using Marina.Models;

namespace Marina.DataAccess.Repositories.IRepository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        void Update(Customer obj);
    }
}
