using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TarekVaiApp.Models
{
    public class Employee
    {
        public int EmployeeId { set; get; }

        [Display(Name ="Name")]
        [Required(ErrorMessage ="name is required")]
        public string Name { set; get; }

        [Display(Name = "Father Name")]
        [Required(ErrorMessage = "father name is required")]
        public string FatherName { set; get; }

        [Display(Name = "Mother Name")]
        [Required(ErrorMessage = "mother name is required")]
        public string MotherName { set; get; }

        [Display(Name = "Mobile No")]
        [Required(ErrorMessage = "mobile no is required")]
        public string MobileNumber { set; get; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "address is required")]
        public string Address { set; get; }

    }
}