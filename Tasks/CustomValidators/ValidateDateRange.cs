using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tasks.CustomValidators
{
    public class ValidateDateRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // your validation logic
            if (Convert.ToDateTime(value) >= Convert.ToDateTime("01/01/1900") && Convert.ToDateTime(value) <= Convert.ToDateTime("01/01/2090"))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Date should be between 1/1/1900 and 1/1/2090");
            }
        }
    }
}