using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlexMovies.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}