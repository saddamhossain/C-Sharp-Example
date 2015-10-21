using HelloWorldMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMvc.Controllers
{
    public class DepartmentController : Controller
    {
    
       public ActionResult DepartmentList()
        {
            DepartmentContainer aContainer = new DepartmentContainer();
            return View(aContainer.GetAllDept());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department aDepartment)
        {
            return View();
        }






    }
}