using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_dotNet_Application.Models;
using First_dotNet_Application.ViewModels;

namespace First_dotNet_Application.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        //public ActionResult CustomerIndex()
        //{

        //    var customers = new List<Customer>
        //    {
        //        new Customer { Name = "Customer 1" },
        //        new Customer { Name = "Customer 2" }
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Customers = customers
        //    };

        //    return View(viewModel);
        //}


        public ActionResult Customers()
        {

            var movie = new Movie() { Name = "Bladerunner" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}