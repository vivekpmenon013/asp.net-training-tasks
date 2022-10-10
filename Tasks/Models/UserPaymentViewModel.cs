using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Tasks.CustomValidators;
using ExpressiveAnnotations.Attributes;

namespace Tasks.Models
{
    public enum PaymentMode
    {
        Cash,
        Credit
    }
    public class UserPaymentViewModel
    {
        [Display(Name = "Username")]
        [RegularExpression(@"^(?=.{6,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", ErrorMessage = "Username should contain 6-20 characters")]
        [Required]
        public string Username { get; set; }

        [Display(Name = "Select the Payment Mode")]
        [Required(ErrorMessage = "Please select the required Payment Mode")]
        public PaymentMode SelectedPaymentMode { get; set; }

        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Amount is not in the expected format")]
        [Required(ErrorMessage = "Please enter the Amount")]
        public double Amount { get; set; }

        [Display(Name = "Card Number")]
        [RequiredIf("SelectedPaymentMode == PaymentMode.Credit", ErrorMessage = "Please enter the Card Number")]
        public string CreditCardNumber { get; set; }

        [RequiredIf("SelectedPaymentMode == PaymentMode.Credit", ErrorMessage = "Please enter the CVV")]
        [Display(Name = "CVV")]
        [RegularExpression(@"^[0-9]{3,4}$", ErrorMessage = "CVV is not in the expected format")]
        public string CVV { get; set; }

        [Display(Name = "MM")]
        public List<SelectListItem> ExpiryDateMonthList { get; set; }
        [Display(Name = "YYYY")]
        public List<SelectListItem> ExpiryDateYearList { get; set; }

        [RequiredIf("SelectedPaymentMode == PaymentMode.Credit", ErrorMessage = "Please select the month of expiry")]
        public string SelectedMonth { get; set; }

        [RequiredIf("SelectedPaymentMode == PaymentMode.Credit", ErrorMessage = "Please select the year of expiry")]
        public string SelectedYear { get; set; }
    }
}