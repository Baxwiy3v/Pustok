using Microsoft.AspNetCore.Mvc;

namespace Peskit.Controllers
{
    public class DepartmanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
