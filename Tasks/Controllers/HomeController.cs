using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasks.Models;

namespace Tasks.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Task = "Task 16 - Change Button Color on Mouse Over";
            return View();
        }

        
        public ActionResult ArithmeticOperations()
        {
            ViewBag.Task = "Task 17 - Addition or Subtraction based on selection";
            return View();
        }

        [HttpPost]
        public ActionResult ArithmeticOperations(ArithmeticOperationsViewModel avm, string command)
        {
            ViewBag.Task = "Task 17 - Addition or Subtraction based on selection";
            if (ModelState.IsValid)
            {
                double num1 = Convert.ToDouble(avm.FirstNumber);
                double num2 = Convert.ToDouble(avm.SecondNumber);
                if (command == "Addition")
                {
                    avm.Result = num1 + num2;
                } else
                {
                    avm.Result = num1 - num2;
                }
               
                return View(avm);
            } else
            {
                avm.Result = 0;
                return View(avm);
            }
            
        }
    }
}