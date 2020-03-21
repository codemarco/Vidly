using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
   
    public class CustomersController : Controller
    {
        //[Route("Customers/Action")]
        // GET: Customers
        public ActionResult ActionCustomers()
        {
            var movie = new Movie() {Id = 1, Name = "Shrek"};
            var viewCustomers = new CustomerViewModel();

            viewCustomers.Customer = new List<Customer>();
            viewCustomers.Movie = movie;


            var customerList = viewCustomers.Customer;
            
            customerList.Add(new Customer {Name= "Marco"});
            customerList.Add(new Customer { Name = "Silvia" });

            
          

            return View(viewCustomers);
            
        }
    }
}