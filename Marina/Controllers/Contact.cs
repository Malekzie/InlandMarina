using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Marina.Controllers
{
    [AllowAnonymous]
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
