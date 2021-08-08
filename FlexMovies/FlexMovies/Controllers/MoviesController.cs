﻿using FlexMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlexMovies.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "I know What You Did Last Summer" };

            
            //return Content("Hellooooo");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
            return View(movie);
        }
        // Action Parameters will use "id" as a default with the MapRoute in the RouteConfig.
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // Optional parameters
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy)){
                sortBy = "Name";
            }
            return Content(string.Format($"pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }


        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);

        }
    }
}