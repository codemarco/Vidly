using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security.Provider;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()

        {
            var movie = new Movie() {Name = "Sherk!"};
            var customers = new List<Customer>()
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }

        public ActionResult Index(int? PageIndex, string sortBy)
        {
            if (!PageIndex.HasValue) PageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}",PageIndex,sortBy));
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year+ "/"+month);
        }
        

    }
}