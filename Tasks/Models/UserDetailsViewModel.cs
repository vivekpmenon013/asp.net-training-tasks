using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Tasks.CustomValidators;

namespace Tasks.Models
{
    public class UserDetailsViewModel
    {
        [Display(Name = "Username")]
        [RegularExpression(@"^(?=.{6,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", ErrorMessage = "Username should contain 6-20 characters")]
        [Required]
        public string Username { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [ValidateDateRange]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        public string Nationality { get; set; }
       
        public IEnumerable<SelectListItem> Countries => new[]
        {
            new SelectListItem {Text = "Poland", Value = "Poland"},
            new SelectListItem {Text = "Germany", Value = "Germany"},
            new SelectListItem {Text = "France", Value = "France"},
            new SelectListItem {Text = "Japan", Value = "Japan"},
            new SelectListItem {Text = "China", Value = "China"},
            new SelectListItem {Text = "Israel", Value = "Israel"},
            new SelectListItem {Text = "Other", Value = "Other"}
        };

        [Required]
        public string Country { get; set; }

        [Required]
        public string SkillSet { get; set; }
    }
}