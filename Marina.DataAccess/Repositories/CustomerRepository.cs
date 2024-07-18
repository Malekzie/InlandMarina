﻿using Marina.DataAccess.Data;
using Marina.DataAccess.Repositories.IRepository;
using Marina.Models;

namespace Marina.DataAccess.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly MarinaDbContext _db;

        public CustomerRepository(MarinaDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Customer obj)
        {
            _db.Update(obj);
        }
    }
}
