using Microsoft.AspNetCore.Mvc;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
