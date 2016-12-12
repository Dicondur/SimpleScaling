using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASimpleAnalogueScaling.Models;

namespace ScalingApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee person1 = new Employee { EmpID = 101, Name = "Tesla", City = "KW" };

            return View(person1);
        }
    }
}