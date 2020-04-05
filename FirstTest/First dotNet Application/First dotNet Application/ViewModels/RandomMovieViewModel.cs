using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using First_dotNet_Application.Models;

namespace First_dotNet_Application.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}