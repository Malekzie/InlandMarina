using Marina.DataAccess.Data;
using Marina.DataAccess.Repositories.IRepository;
using Marina.Models;
using Marina.Utils;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Marina.DataAccess.Repositories
{
    public class DockRepository : Repository<Dock>, IDockRepository
    {
        private readonly MarinaDbContext _db;

        public DockRepository(MarinaDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Dock obj)
        {
            _db.Update(obj);
        }

        public async Task<IEnumerable<Dock>> GetDocksWithSlips()
        {
            return await _db.Dock.Include(d => d.Slips).ToListAsync();
        }

        public async Task<PaginatedList<Slip>> GetSlipsWithPagination(int dockId, int pageIndex, int pageSize)
        {
            try
            {
                // Fetch slips with their leases
                var slipsQuery = _db.Slips
                                    .Where(s => s.DockId == dockId)
                                    .Include(s => s.Leases);

                // Log the generated SQL query for debugging
                var sqlQuery = slipsQuery.ToQueryString();

                return await PaginatedList<Slip>.CreateAsync(slipsQuery, pageIndex, pageSize);
            }
            catch (Exception ex)
            {
                // Log the exception details
                Console.WriteLine($"Error: {ex.Message}");
                // Rethrow or handle the exception as needed
                throw;
            }
        }


    }
}
