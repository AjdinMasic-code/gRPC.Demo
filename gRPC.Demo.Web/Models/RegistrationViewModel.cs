using System;
using System.ComponentModel.DataAnnotations;

namespace gRPC.Demo.Web.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [Display(Name = "First name:")]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name:")]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Business name:")]
        [MinLength(3)]
        public string BusinessName { get; set; }

        [Required]
        [Display(Name = "Years in business:")]
        public int YearsInBusiness { get; set; }

        [Required]
        [Display(Name = "Is this company currently active?")]
        public bool IsActive { get; set; }
    }
}
