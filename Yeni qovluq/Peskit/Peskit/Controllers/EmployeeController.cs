using Microsoft.AspNetCore.Mvc;

namespace Peskit.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
