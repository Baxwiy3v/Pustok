using Microsoft.AspNetCore.Mvc;
using Peskit.DAL;

namespace Peskit.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {



            return View();
        }
    }
}
