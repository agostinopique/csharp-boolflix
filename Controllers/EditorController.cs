using csharp_boolflix.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class EditorController : Controller
    {
        private BoolflixDbContext _db;

        public EditorController()
        {
            _db = new BoolflixDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Film()
        {
            return View();
        }

        public IActionResult TVSeries()
        {
            return View();
        }

        public IActionResult Actors()
        {
            return View();
        }

        public IActionResult Genre()
        {
            return View();
        }

        public IActionResult Features()
        {
            List<Feature> features = _db.Features.ToList();
            return View(features);
        }
    }
}
