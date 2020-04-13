using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
   
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;


        public CustomersController()
        {
            _context= new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ViewResult Index()
        {

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            //var customers = GetCustomers();
            return View(customers);
        }
        //[Route("Customers/Action")]
        // GET: Customers

        public ActionResult Details(int? id)
        {
            var customer = _context.Customers.Include(c =>c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer {Id = 1, Name = "John Smith"},
        //        new Customer {Id = 2, Name = "Mary Williams"}
        //    };
        //}

        //public ActionResult ActionCustomers()
        //{
        //    var movie = new Movie() {Id = 1, Name = "Shrek"};
        //    var viewCustomers = new CustomerViewModel();

        //    viewCustomers.Customer = new List<Customer>();
        //    viewCustomers.Movie = movie;


        //    var customerList = viewCustomers.Customer;
            
        //    customerList.Add(new Customer {Name= "Marco"});
        //    customerList.Add(new Customer { Name = "Silvia" });

            
          

        //    return View(viewCustomers);
            
        //}
    }
}