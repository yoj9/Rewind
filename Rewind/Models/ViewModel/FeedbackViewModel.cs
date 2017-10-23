using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rewind.Models.ViewModel
{
    public class FeedbackViewModel
    {
        [Key]
        public int feedback_id { get; set; }

        public string feedback_username { get; set; }

        [Display(Name = "Comments")]
        [Required(ErrorMessage = "Please enter comments")]
        [StringLength(maximumLength:100, ErrorMessage = "Minimum length 5", MinimumLength = 5)]
        public string feedback_comments { get; set; }

        public DateTime feedback_date { get; set; }


    }
}