using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
    public class ArithmeticOperationsViewModel
    {
        [Display(Name = "Enter First Number")]
        [Required(ErrorMessage = "*First Number is required.")]
        public double FirstNumber { get; set; }

        [Display(Name = "Enter Second Number")]
        [Required(ErrorMessage = "*Second Number is required.")]
        public double SecondNumber { get; set; }
        public double Result { get; set; }
    }
}