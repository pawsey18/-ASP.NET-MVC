using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FlexMovies.Models;


namespace FlexMovies.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext() :base("MovieContextDB")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}