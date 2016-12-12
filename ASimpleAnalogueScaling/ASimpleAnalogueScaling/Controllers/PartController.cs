using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using ScalingApp.Models;

namespace ScalingApp.Controllers
{
    public class PartController : Controller
    {
       
        public ActionResult Details(uint id)
        {
            //SADBEntities partcontext = new SADBEntities();
            //Part FirstPart = partcontext.Parts.Single(prt => prt.PartID == id); //Return first record

            return View();
        }
    }
}