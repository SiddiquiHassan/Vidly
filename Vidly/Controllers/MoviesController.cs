using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
          
            var movie = new Movie() { Name = "Shrek!", Id=90};
            var customers = new List<Customer>
            {
                new Customer{ Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            ViewData["Movie"] = movie;
            ViewBag.Movie = movie;

            return View(viewModel);
            //return Redirect("wwww.google.com");
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
            //return Content("Using Content !");
            //return HttpNotFound();
            //return new EmptyResult();
            //return Json(movie,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int id)
        {
            return Content(id.ToString());
        }

        public ActionResult Index(int? page, string sortBy)
        {
            if (!page.HasValue)
            {
                page = 567;
                sortBy = "Drama";
            }
            
            return Content(string.Format("page is {0} and sortBy is {1}", page, sortBy));
        }

        public ActionResult ByReleaseDate(int? year, byte? month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies/bygenre/{genre:minlength(4)}")]
        public ActionResult ByGenre(string genre)
        {

            return Content("desired genre is :"+ genre);
        }
    }
}