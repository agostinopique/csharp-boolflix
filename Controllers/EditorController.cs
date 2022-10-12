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
            List<Film> film = _db.Films.ToList();
            return View(film);
        }

        public IActionResult TVSeries()
        {
            return View();
        }

        public IActionResult Actor()
        {
            List<Actor> actors = _db.Actors.ToList();
            return View(actors);
        }

        public IActionResult Genre()
        {
            List<Genre> genres = _db.Genres.ToList();
            return View(genres);
        }

        public IActionResult Features()
        {
            List<Feature> features = _db.Features.ToList();
            return View(features);
        }
    }
}
