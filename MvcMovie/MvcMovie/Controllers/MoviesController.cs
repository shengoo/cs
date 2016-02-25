using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;
using System.Linq;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/

        MovieDBContext db = new MovieDBContext();

        public ActionResult Index()
        {
            var movies = from m in db.Movies
                         where m.ReleaseDate > new DateTime(1984, 6, 1)
                         select m;

            return View(movies.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(newMovie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newMovie);
            }
        }

    }
}
