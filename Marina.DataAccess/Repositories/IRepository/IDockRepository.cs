using Marina.Models;
using Marina.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marina.DataAccess.Repositories.IRepository
{
    public interface IDockRepository : IRepository<Dock>
    {
        void Update(Dock obj);
        Task<IEnumerable<Dock>> GetDocksWithSlips();
        Task<PaginatedList<Slip>> GetSlipsWithPagination(int dockId, int pageIndex, int pageSize);
    }
}
