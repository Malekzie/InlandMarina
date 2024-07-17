using Microsoft.AspNetCore.Mvc;

namespace Marina.Areas.Anon.Controllers
{
    [Area("Anon")]
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
