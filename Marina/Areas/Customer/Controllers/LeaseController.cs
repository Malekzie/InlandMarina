using Marina.DataAccess.Data;
using Marina.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Marina.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class LeaseController : Controller
    {
        private readonly MarinaDbContext _context;

        public LeaseController(MarinaDbContext context)
        {
            _context = context;
        }

        // GET: Lease/Reserve
        public IActionResult Reserve(int? slipId)
        {
            if (slipId == null)
            {
                return BadRequest("Slip ID is required");
            }

            // Fetch the slip details if a slip ID is provided
            var slip = _context.Slips
                .FirstOrDefault(s => s.ID == slipId.Value);
            if (slip == null)
            {
                return NotFound();
            }

            return View(slip); // Pass the slip object to the view
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reserve(int slipId)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account", new { area = "Identity"});
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Check if the slip is still available
            var slip = _context.Slips
                .Include(s => s.Leases)
                .FirstOrDefault(s => s.ID == slipId);

            if (slip == null || slip.Leases.Any())
            {
                // Slip is not available
                ModelState.AddModelError("", "The selected slip is no longer available.");
                return View(slip);
            }

            // Create new lease
            var lease = new Lease
            {
                SlipId = slipId,
                CustomerID = userId
            };

            _context.Leases.Add(lease);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Lease/MySlips
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account", new { area = "Identity" });
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var leases = _context.Leases
                .Include(l => l.Slip)
                .Where(l => l.CustomerID == userId)
                .ToList();

            return View(leases);
        }

        // GET: Lease/Remove
        public IActionResult Remove(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account", new { area = "Identity" });
            }

            var lease = _context.Leases
                .Include(l => l.Slip)
                .FirstOrDefault(l => l.ID == id);

            if (lease == null || lease.CustomerID != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return NotFound();
            }

            return View(lease);
        }

        // POST: Lease/Remove
        [HttpPost, ActionName("RemoveConfirm")]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveConfirmed(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account", new { area = "Identity" });
            }

            var lease = _context.Leases
                .FirstOrDefault(l => l.ID == id);

            if (lease == null || lease.CustomerID != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return NotFound();
            }

            _context.Leases.Remove(lease);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
