using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_dotNet_Application.Models;
using First_dotNet_Application.ViewModels;

namespace First_dotNet_Application.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Bladerunner" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Tester McTesterson", Id = 1 },
                new Customer { Name = "Teddy Bridgewater", Id = 2 }

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //return Content("Hello World");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "THE ROCK" },
                new Movie { Id = 2, Name = "Cat in the Hat" }
            };
        }

        public ActionResult Movies()
        {
            var movieList = GetMovies();
            return View(movieList);
        }

    }
}