using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
    public class DigitViewModel
    {
        [Required]
        [Display(Description ="Please enter a 9 digit number")]
        [RegularExpression(@"^[0-9]{9}$", ErrorMessage = "Please enter 9 digit number")]
        public long Number { get; set; }

        [Display(Description = "Unique Digits in the entered number are below")]
        public string UniqueDigits { get; set; }
    }
}