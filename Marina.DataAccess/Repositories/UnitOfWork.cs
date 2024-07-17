using Marina.DataAccess.Data;
using Marina.DataAccess.Repositories.IRepository;
using System.Threading.Tasks;

namespace Marina.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MarinaDbContext _db;

        public UnitOfWork(MarinaDbContext db)
        {
            _db = db;
            Dock = new DockRepository(_db);
        }

        public IDockRepository Dock { get; private set; }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
