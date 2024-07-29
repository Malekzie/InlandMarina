using Marina.Models;
using Marina.Utils;

namespace Marina.DataAccess.Repositories.IRepository
{
    public interface IDockRepository : IRepository<Dock>
    {
        void Update(Dock obj);
        Task<IEnumerable<Dock>> GetDocksWithSlips();
        Task<PaginatedList<Slip>> GetSlipsWithPagination(int dockId, int pageIndex, int pageSize);
        Task<PaginatedList<Slip>> GetAllSlipsWithPagination(int pageIndex, int pageSize);
    }
}
