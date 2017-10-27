using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rewind.Models.EntityManager;

namespace Rewind.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection logindetails)
        {
            if (ModelState.IsValid)
            {
                RegistrationManager RM = new RegistrationManager();

                if (RM.IsUserNameExists(logindetails[0]))
                {
                  bool check =  RM.ValidateUser(logindetails[0], logindetails[1]);

                    if (check)
                    {
                        return View("UploadMultimedia");
                    }

                }
            }
            return View("");
        }

    }
}