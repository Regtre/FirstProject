using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }

        public DateOnly ReleaseDate { get; set; }
        public DateOnly DateAdded { get; set; }

        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }
        public string? Url { get; set; }
    }
}