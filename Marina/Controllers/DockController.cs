using Marina.DataAccess.Repositories.IRepository;
using Marina.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Marina.Controllers
{
    public class DockController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DockController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> LoadDocksAndSlips(int dockId, int pageIndex = 1, int pageSize = 5)
        {
            var docks = await _unitOfWork.Dock.GetDocksWithSlips();
            if (!docks.Any())
            {
                return NotFound("No docks found.");
            }

            var dock = docks.FirstOrDefault(d => d.ID == dockId);

            if (dock == null)
            {
                return NotFound($"Dock with ID {dockId} not found.");
            }

            var paginatedSlips = await _unitOfWork.Dock.GetSlipsWithPagination(dockId, pageIndex, pageSize);

            var viewModel = new DockViewModel
            {
                Docks = docks,
                SelectedDock = dock,
                PaginatedSlips = paginatedSlips
            };

            return PartialView("_DocksAndSlips", viewModel);
        }

        public async Task<IActionResult> Index(int? dockId, int pageIndex = 1, int pageSize = 5)
        {
            var docks = await _unitOfWork.Dock.GetDocksWithSlips();
            if (!docks.Any())
            {
                return NotFound("No docks found.");
            }

            var selectedDockId = dockId ?? docks.First().ID;
            var dock = docks.FirstOrDefault(d => d.ID == selectedDockId);

            if (dock == null)
            {
                return NotFound($"Dock with ID {selectedDockId} not found.");
            }

            var paginatedSlips = await _unitOfWork.Dock.GetSlipsWithPagination(selectedDockId, pageIndex, pageSize);

            var viewModel = new DockViewModel
            {
                Docks = docks,
                SelectedDock = dock,
                PaginatedSlips = paginatedSlips
            };

            return View(viewModel);
        }
    }
}
