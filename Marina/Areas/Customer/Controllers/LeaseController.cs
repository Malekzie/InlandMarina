using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Marina.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = "Customer")]
    public class LeaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
