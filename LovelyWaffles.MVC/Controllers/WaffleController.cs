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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Waffle waffle)
        {
            var waffleId = _context.Waffles.Select(w => w.WaffleId).Max() + 1;
            waffle.WaffleId = waffleId;
            _context.Waffles.Add(waffle);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var waffle = _context.Waffles.Find(id);
            return View(waffle);
        }

        [HttpPost]
        public IActionResult Edit(Waffle waffle)
        {
            _context.Waffles.Update(waffle);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
