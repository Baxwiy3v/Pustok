using Microsoft.AspNetCore.Mvc;

namespace Peskit.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
