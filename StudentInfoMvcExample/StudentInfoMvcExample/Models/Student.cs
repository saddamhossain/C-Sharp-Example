using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentInfoMvcExample.Models
{
    public class Student
    {
        public int StudentId { set; get;}

        [Display(Name ="Registration Number")]
        public string RegNo { set; get; }
        public string Name { set; get; }

    }
}