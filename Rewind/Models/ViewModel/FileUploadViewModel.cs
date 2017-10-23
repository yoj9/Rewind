using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rewind.Models.ViewModel
{
    public class FileUploadViewModel
    {
        [Key]
        public int file_id { get; set; }

        public string file_filename { get; set; }

        [Column(TypeName = "image")]
        public HttpPostedFileBase file_multimedia { get; set; }

        public DateTime file_uploaddate { get; set; }

        public string file_location { get; set; }

       


       
    }
}