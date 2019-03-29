using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_mvc.Models;
using System.Data.Entity;

namespace asp_mvc.Controllers
{
    public class MoviesController : Controller
    {

        private StoreContext _context;

        public MoviesController()
        {
            _context = new StoreContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        public ActionResult New()
        {
            return View("Form");
        }

        public ActionResult Edit()
        {
            return View("Form");
        }
    }
}