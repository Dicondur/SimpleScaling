using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ASimpleAnalogueScaling.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate()
        {
           
            ViewBag.Message = "Given an values for Scaled Min & Max and Raw Min & Max the Scaled value for input is calculated.";

            ViewBag.ScaledMin = "0";

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]// To prevent CSRF Attack
        public ActionResult Calculate(Table inputFromForm) //
        {
            float? ScaledMin = inputFromForm.ScaledMin;
            float? ScaledMax = inputFromForm.ScaledMax;
            float? IPCurrentMin = inputFromForm.IPCurrentMin;
            float? IpCurrentMax = inputFromForm.IpCurrentMax;
            decimal? RawMin = inputFromForm.RawMin;
            decimal? RawMax  = inputFromForm.RawMax;

            





            if (ModelState.IsValid)
            {
                using (TempDBEntities dc = new TempDBEntities()) //Maps to Name of the App_data database created earlier
                {
                    
                    ViewBag.Rate = inputFromForm.Rate;

                    dc.Tables.Add(inputFromForm);
                    dc.SaveChanges();
                }
            }
            else
            {
                ViewBag.Message = "Failed! Please try again";
            }

            return View(inputFromForm);
        }





        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}