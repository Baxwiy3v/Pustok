using Microsoft.AspNetCore.Mvc;

namespace Peskit.Areas.Admin.Controllers
{
    [Area("admin")]
    public class PositionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
