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
           
            ViewBag.Message = "Given values for Scaled Minimun & Maximum and Raw Minimum & Maximum, the Raw current value is calculated.";          
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]// To prevent CSRF Attack
        public ActionResult Calculate(InputQuery inputFromForm) //
        {
            ViewBag.ScaledMin = inputFromForm.ScaledMin;
            ViewBag.ScaledMax = inputFromForm.ScaledMax;
            ViewBag.RawMin = inputFromForm.RawMin;
            ViewBag.RawMax = inputFromForm.RawMax;



            ViewBag.Rate = inputFromForm.Rate;
            ViewBag.Offset = inputFromForm.Offset;

            
            if (inputFromForm.RawInput != null)
            {
                ViewBag.Current = inputFromForm.RawInput;
            }
            else if (inputFromForm.ScaledInput != null)
            {
                ViewBag.Current = inputFromForm.ScaledInput;
            }
                

            ViewBag.RawResult = inputFromForm.RawResult();
            ViewBag.ScaledResult = inputFromForm.ScaledResult();

            if (ModelState.IsValid)
            {
                using (TempDBEntities1 dc = new TempDBEntities1()) //Maps to Name of the App_data database created earlier
                {
                    
                    //ViewBag.Rate = inputFromForm.Rate;

                    dc.InputQueries.Add(inputFromForm);
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