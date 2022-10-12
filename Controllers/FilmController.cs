using csharp_boolflix.Models;
using csharp_boolflix.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class FilmController : Controller
    {
        public BoolflixDbContext _db;
        public FilmController()
        {
            _db = new BoolflixDbContext();
        }
        public IActionResult Create()
        {
            FilmMediainfo filmMediainfo = new FilmMediainfo();
            filmMediainfo.Film = new Film();
            filmMediainfo.Features = _db.Features.ToList();
            filmMediainfo.Genres = _db.Genres.ToList();
            filmMediainfo.Actors = _db.Actors.ToList();
            return View(filmMediainfo);
        }

        public IActionResult Store(FilmMediainfo filmData)
        {
            if (!ModelState.IsValid)
            {
                filmData.Features = _db.Features.ToList();
                filmData.Genres = _db.Genres.ToList();
                filmData.Actors = _db.Actors.ToList();
                return View("Create", filmData);
            }

            List<Actor> actors = new List<Actor>();
            foreach(Actor actor in filmData.Actors)
            {
                Actor foundActor = _db.Actors.Where(actors => actor.Id == actor.Id).FirstOrDefault();
                actors.Add(foundActor);
            }
        }
    }
}
