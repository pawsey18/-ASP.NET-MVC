using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BSDemo.Models
{
    public class Book
    {
        public int Id { get; set; }
        // this defines that relationship
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Synopsis { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        // one book can have many authors, representing that with icollection
        public virtual Author Author { get; set; }
    }
}