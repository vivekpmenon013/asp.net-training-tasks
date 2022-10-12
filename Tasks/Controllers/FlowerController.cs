using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasks.Models;

namespace Tasks.Controllers
{
    public class FlowerController : Controller
    {
        // GET: Flower
        public ActionResult Index()
        {
            ViewBag.Task = "Task 21 - RadioList";
            FlowerViewModel fvm = new FlowerViewModel();
            return View(fvm);
        }

        [HttpPost]
        public ActionResult Index(FlowerViewModel fvm)
        {
            ViewBag.Task = "Task 21 - RadioList";
            return View(fvm);
        }
    }
}