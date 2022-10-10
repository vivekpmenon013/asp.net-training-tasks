using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
    public class ListBoxSelectViewModel
    {
        [Display(Name = "Select the Product")]
        public IEnumerable<SelectListItem> Products { get; set; }

        [Display(Name = "Price of the selected product")]
        public double SelectedProductPrice { get; set; }

        [Display(Name = "Image of the selected product")]
        public string SelectedProductImage { get; set; }
    }
}