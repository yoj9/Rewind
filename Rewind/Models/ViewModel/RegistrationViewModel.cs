using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rewind.Models.ViewModel
{
    public class RegistrationViewModel
    {
        [Display(Name = "User name")]
        [Required(ErrorMessage = "User name is requried")]
        [StringLength(15, ErrorMessage = "Minimum length 5", MinimumLength = 5)]
        public string reg_username { get; set; }


        [Key]
        public int reg_id { get; set; }

        [Display(Name = "First name")]
        [Required(ErrorMessage = "First name is requried")]
        [StringLength(15, ErrorMessage = "Minimum length 5", MinimumLength = 5)]
        public string reg_FN { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is requried")]
        [StringLength(15, ErrorMessage = "Minimum length 5", MinimumLength = 5)]
        public string reg_LN { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime reg_dob { get; set; }

        [Display(Name = "Sex")]
        [Required(ErrorMessage = "Sex is required")]
        public string reg_sex { get; set; }

        [Required(ErrorMessage = "Password is requried")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string reg_pwd { get; set; }

        public int reg_status { get; set; }
    }
}