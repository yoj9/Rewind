using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rewind.Models.DB;
using Rewind.Models.ViewModel;

namespace Rewind.Controllers
{
    public class FileUploadController : Controller
    {
        public ActionResult UploadMultimedia()
        {
            var model = new FileUploadViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult UploadMultimedia(FileUploadViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return  View(model);
            }

            byte[] uploadedFile = new byte[model.file_multimedia.InputStream.Length];
            model.file_multimedia.InputStream.Read(uploadedFile, 0, uploadedFile.Length);

           // fileUpload(uploadedFile);


            // now you could pass the byte array to your model and store wherever 
            // you intended to store it

            return Content("Thanks for uploading the file");
        }
    }
}
