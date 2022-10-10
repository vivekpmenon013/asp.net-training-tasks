using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasks.Models;

namespace Tasks.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            UserPaymentViewModel upvm = new UserPaymentViewModel();
            

            upvm.ExpiryDateMonthList = new List<SelectListItem>();
            upvm.ExpiryDateYearList = new List<SelectListItem>();

            for (int i = 1; i <= 12; i++)
            {
                DateTime month = new DateTime(2000, i, 1);
                upvm.ExpiryDateMonthList.Add(new SelectListItem { Text = month.ToString("MM"), Value = month.ToString("MM") });
            }

            for (int i = 0; i <= 11; i++)
            {
                String year = (DateTime.Today.Year + i).ToString();
                upvm.ExpiryDateYearList.Add(new SelectListItem { Text = year, Value = year });
            }

            ViewBag.Task = "Task 19 - User Payment Details";
            return View(upvm);
        }

        [HttpPost]
        public ActionResult Validate()
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("My Error", "Invalid Data");
                return View("Index");
            }

            return View("Succe  ss");
        }

        public ActionResult Details()
        {
            var udvm = new UserDetailsViewModel();
            ViewBag.Task = "Task 18 - User Details";
            return View(udvm);
        }
        [HttpPost]
        public ActionResult SubmitDetails(UserDetailsViewModel udvm)
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("My Error", "Invalid Data");
                ViewBag.Task = "Task 18 - User Details";
                Response.Cookies["username"].Value ='';
                return View("Details", udvm);
            }
            Response.Cookies["username"].Value = udvm.Username;
            return View("Success");
        }
    }
}