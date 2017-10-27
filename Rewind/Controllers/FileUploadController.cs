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
using Rewind.Models.EntityManager;

namespace Rewind.Controllers
{
    public class FileUploadController : Controller
    {
        public ActionResult UploadMultimedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadMultimedia(FileUploadViewModel model,HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                FileUploadManager FUM = new FileUploadManager();
                FUM.fileUpload(model, file);
            }
            return Content("Thanks for uploading the file");
        }

        public ActionResult DisplayMultimedia()
        {
            return View(FileUploadManager.GetFiles());
        }


        [HttpPost]
        public ActionResult DownloadFile(int? file_id)
        {
            if (ModelState.IsValid)
            {
                FileUploadManager FUM = new FileUploadManager();
               // return File(FUM.Download(file_id),);
                return View();
            }
            return null;
        }
    }
}
