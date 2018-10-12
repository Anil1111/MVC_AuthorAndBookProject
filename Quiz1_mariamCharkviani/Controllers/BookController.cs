using Goodreads.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiz1_mariamCharkviani.Controllers
{
    public class BookController : Controller
    {
         private readonly BookRepository _repository = new BookRepository();
        // GET: Book
        public ActionResult Index()
        {
            return View(_repository);
        }
        public ActionResult Details(int id)
        {
            var books = _repository.GetBooks().SingleOrDefault(b => b.Id == id);

            if (books == null)
                return HttpNotFound();

            return View(books);
        }
    }
}