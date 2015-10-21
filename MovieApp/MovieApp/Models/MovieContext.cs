using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieApp.Models
{
    public class MovieContext : DbContext 
    {
        public DbSet<Movie> Movies { set; get; }
    }
}