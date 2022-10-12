using csharp_boolflix.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace csharp_boolflix.Controllers
{
    public class GenreController : Controller
    {
        private BoolflixDbContext _db;

        public GenreController()
        {
            _db = new BoolflixDbContext();
        }

        [HttpGet]
        public IActionResult Create()
        {
            Genre genre = new Genre();
            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Store(Genre genreData)
        {
            if (!ModelState.IsValid)
            {
                return View(genreData);
            }

            Genre createGenre = new Genre();
            createGenre.Name = genreData.Name;

            _db.Add(createGenre);
            _db.SaveChanges();

            return RedirectToAction("Genre", "Editor");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Genre updateGenre = _db.Genres.Where(genre => genre.Id == id).FirstOrDefault();
            return View(updateGenre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Genre genreData)
        {
            Genre updateGenre = _db.Genres.Where(genres => genres.Id == id).FirstOrDefault();
            if (!ModelState.IsValid)
            {
                return View("Edit", genreData);
            }

            updateGenre.Name = genreData.Name;
            _db.SaveChanges();
            return RedirectToAction("Genre", "Editor");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _db.Remove(_db.Genres.Where(genres => genres.Id == id).FirstOrDefault());
            _db.SaveChanges();
            return RedirectToAction("Genre", "Editor");
        }


    }
}
