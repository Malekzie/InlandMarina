using Marina.DataAccess.Data;
using Marina.DataAccess.Repositories.IRepository;
using Marina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marina.DataAccess.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly MarinaDbContext _db;

        public CustomerRepository(MarinaDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(Customer obj)
        {
            _db.Update(obj);
        }
    }
}
