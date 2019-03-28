using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_mvc.Models;

namespace asp_mvc.Controllers
{
    public class BooksController : Controller
    {

        private IList<Book> books = new List<Book>
        {
            new Book("B001", "Book 1", 2016, 200, 230, "Description 1"),
            new Book("B002", "Book 2", 2017, 201, 350, "Desscription 2"),
            new Book("B003", "Book 3", 2018, 200, 150, "Desscription 3"),
            new Book("B004", "Book 4", 2019, 202, 50, "Desscription 4"),
        };

        public ActionResult Index()
        {
            ViewBag.SectionTitle = "List of books";
            return View(books);
        }

        public ActionResult Details(string isbn)
        {
            Book book = null;
            foreach(var b in books)
            {
                if(b.ISBN.Equals(isbn))
                {
                    book = b;
                    break;
                }
            }

            ViewBag.Book = book;
            return View("BookDetails");
        }
    }
}