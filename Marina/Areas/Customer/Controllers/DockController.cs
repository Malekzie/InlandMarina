using Marina.DataAccess.Repositories.IRepository;
using Marina.Models;
using Marina.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Marina.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class DockController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DockController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [AllowAnonymous]
        public async Task<IActionResult> LoadDocksAndSlips(int? dockId, int pageIndex = 1, int pageSize = 8)
        {
            var docks = await _unitOfWork.Dock.GetDocksWithSlips();
            if (!docks.Any())
            {
                return NotFound("No docks found.");
            }

            Dock dock = null;
            PaginatedList<Slip> paginatedSlips;

            if (dockId.HasValue && dockId > 0)
            {
                dock = docks.FirstOrDefault(d => d.ID == dockId.Value);
                if (dock == null)
                {

                   return NotFound($"Dock with ID {dockId} not found.");
                }
                paginatedSlips = await _unitOfWork.Dock.GetSlipsWithPagination(dockId.Value, pageIndex, pageSize);
            }
            else
            {
                paginatedSlips = await _unitOfWork.Dock.GetAllSlipsWithPagination(pageIndex, pageSize);
            }

            var viewModel = new DockViewModel
            {
                Docks = docks,
                SelectedDock = dock,
                PaginatedSlips = paginatedSlips
            };

            return PartialView("_DocksAndSlips", viewModel);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(int? dockId, int pageIndex = 1, int pageSize = 8)
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
