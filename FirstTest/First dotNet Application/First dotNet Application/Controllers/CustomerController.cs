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



            var customers = GetCustomers();



            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}

