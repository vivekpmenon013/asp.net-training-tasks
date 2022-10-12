using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasks.Models;

namespace Tasks.Controllers
{
    public class DigitsController : Controller
    {
        // GET: Digits
        public ActionResult Index()
        {
            ViewBag.Task = "Task 22 - Find Unique Digits in 9 digit number";
            return View();
        }

        [HttpPost]
        public ActionResult Index(DigitViewModel dvm)
        {
            ViewBag.Task = "Task 22 - Find Unique Digits in 9 digit number";
            var list = dvm.Number.ToString().Select(c => int.Parse(c.ToString())).ToList();
            List<int> myList = list.Distinct().ToList();
            dvm.UniqueDigits = string.Join("", myList);
            return View(dvm);
        }
    }
}