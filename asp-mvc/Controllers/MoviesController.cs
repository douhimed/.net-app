using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_mvc.Models;

namespace asp_mvc.Controllers
{
    public class MoviesController : Controller
    {

        public IList<Movie> movies = new List<Movie>
        {
            new Movie(1, "WARRIOR"),
            new Movie(2, "INCEPTION"),
            new Movie(3, "WOLF ALL WALL STREET"),
            new Movie(4, "GLADIATOR"),
            new Movie(5, "8 miles"),
        };

        // GET: Movies
        public ActionResult Index()
        {
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            return View(movies[id]);
        }
    }
}