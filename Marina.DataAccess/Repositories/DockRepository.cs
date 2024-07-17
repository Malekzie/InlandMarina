﻿using Marina.DataAccess.Data;
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
            // Fetch the dock and include its slips as an EF Core query
            var dock = await _db.Dock
                                .Include(d => d.Slips)
                                .FirstOrDefaultAsync(d => d.ID == dockId);

            if (dock == null)
            {
                return new PaginatedList<Slip>(new List<Slip>(), 0, pageIndex, pageSize);
            }

            // Query slips as an EF Core IQueryable
            var slipsQuery = _db.Slips.Where(s => s.DockId == dockId).AsQueryable();

            return await PaginatedList<Slip>.CreateAsync(slipsQuery, pageIndex, pageSize);
        }
    }
}
