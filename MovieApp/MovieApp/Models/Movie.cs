using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Movie
    {
        public int MovieId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public DateTime ReleaseDate { set; get; }

    }
}