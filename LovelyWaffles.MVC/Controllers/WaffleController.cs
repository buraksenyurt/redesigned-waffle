using LovelyWaffles.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LovelyWaffles.MVC.Controllers
{
    public class WaffleController : Controller
    {
        private readonly WaffleDbContext _context;

        public WaffleController(WaffleDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var waffles = _context.Waffles.ToList();
            return View(waffles);
        }
    }
}
