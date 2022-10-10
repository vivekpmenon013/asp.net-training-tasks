using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasks.Models;
using Tasks.Services;

namespace Tasks.Controllers
{
    public class StoreController : Controller
    {
        IStoreService ss;
        public StoreController(IStoreService ss)
        {
            this.ss = ss;
        }
        // GET: Store
        public ActionResult Index(ListBoxSelectViewModel lvm)
        {
            ViewBag.Task = "Task 18 - Listbox, Button, Image & Label";
            List<ItemModel> storeItems = this.ss.GetStoreItems();

            lvm.Products = storeItems.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Name,
                    Value = a.ID.ToString(),
                    Selected = false
                };
            });
            return View(lvm);
        }
    }
}