using Marina.DataAccess.Data;
using Marina.DataAccess.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Marina.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MarinaDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(MarinaDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }
    }
}
