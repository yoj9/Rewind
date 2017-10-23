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
    public class FeedbackController : Controller
    {
        // GET: Feedback/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Feedback/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "feedback_id,feedback_username,feedback_comments,feedback_date")] FeedbackViewModel feedbackViewModel)
        {
            if (ModelState.IsValid)
            {
                using (ImageBrowserEntities db = new ImageBrowserEntities())
                {
                    db.FeedbackViewModels.Add(feedbackViewModel);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View();
        }


    }
}
