using FlexMovies.Models;
using FlexMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace FlexMovies.Controllers
{
    public class CustomerController : Controller
    {

        public ActionResult Customer()
        {

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new Customer
            {
                
                Customers = customers
            };
            return View(viewModel);
        }  
        
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
    }
}