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
    }
}
