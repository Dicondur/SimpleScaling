using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;


namespace ScalingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HandleError]
        public ActionResult Calculate()
        {
           
            ViewBag.Message = "Given values for Scaled Min & Max and Raw Min & Max, the Scaled/Raw current value is calculated.";          
            return View();
        }


    
        
        [HandleError]
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

        

            return View(inputFromForm);
        }





        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(string name)
        {
            ViewBag.Message = "Your contact page.";
            //ViewData["Name"] = name; //ViewData sample use @ViewData["Name"] in cshtml to view.
            if (name != null)
            {
                ViewBag.Message = "Hi " + name + ", thanks for leaving your name.";
            }

            return View();
        }
    }
}