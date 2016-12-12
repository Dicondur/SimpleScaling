using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScalingApp.Models;

namespace ScalingApp.Controllers
{
    public class PartController : Controller
    {
       
        public ActionResult Details(uint id)
        {
            PartContext partcontext = new PartContext();
            Part FirstPart = partcontext.Parts.Single(prt => prt.PartID == id); //Return first record

            return View(FirstPart);
        }
    }
}