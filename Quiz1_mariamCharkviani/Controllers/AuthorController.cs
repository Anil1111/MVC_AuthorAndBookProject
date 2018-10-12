using Goodreads.Repositories;
using Quiz1_mariamCharkviani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiz1_mariamCharkviani.Controllers
{
    public class AuthorController : Controller
    {
        private readonly AuthorRepository _repository = new AuthorRepository();
        // GET: Author
        public ActionResult Index()
        {
            return View(_repository.GetAuthors());
        }
        public ActionResult Details(int id)
        {
            var authors = _repository.GetAuthors().SingleOrDefault(a => a.Id == id);

            if (authors == null)
                return HttpNotFound();

            return View(authors);
        }
        public ActionResult Random()
        {
            return View(_repository.GetRandomAuthor());
        }
    }
}