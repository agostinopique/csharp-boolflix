using csharp_boolflix.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class ActorController : Controller
    {
        private BoolflixDbContext _db;
        public ActorController()
        {
            _db = new BoolflixDbContext();
        }

        [HttpGet]
        public IActionResult Create()
        {
            Actor actor = new Actor();
            return View(actor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Store(Actor actorData)
        {
            Actor addActor = new Actor();
            if (!ModelState.IsValid)
            {
                return View("Create", actorData);
            }
            addActor.Name = actorData.Name;
            addActor.Surname = actorData.Surname;

            _db.Add(addActor);
            _db.SaveChanges();

            return RedirectToAction("Actor", "Editor");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Actor editActor = _db.Actors.Where(actors => actors.Id == id).FirstOrDefault();

            return View(editActor);
        }

        public IActionResult Update(int id, Actor actorData)
        {
            Actor editActor = _db.Actors.Where(actors => actors.Id == id).FirstOrDefault();

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit", actorData);
            }
            editActor.Name = actorData.Name;
            editActor.Surname = actorData.Surname;
            _db.Update(editActor);
            _db.SaveChanges();

            return RedirectToAction("Actor", "Editor");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _db.Remove(_db.Actors.Where(actors => actors.Id == id).FirstOrDefault());
            _db.SaveChanges();
            return RedirectToAction("Actor", "Editor");
        }
    }
}
