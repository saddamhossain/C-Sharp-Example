using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentInfoMvcExample.Models
{
    public class StudentDbContext : DbContext 
    {
        public DbSet<Student> students { set; get; }
    }
}