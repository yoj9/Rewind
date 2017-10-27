using Rewind.Models.EntityManager;
using Rewind.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Rewind.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewUser(RegistrationViewModel RVM)
        {
            if (ModelState.IsValid)
            {
                RegistrationManager regManager = new RegistrationManager();

                if (!regManager.IsUserNameExists(RVM.reg_username))
                {
                    regManager.AddUserAccount(RVM);
                    FormsAuthentication.SetAuthCookie(RVM.reg_username, false);
                    return RedirectToAction("Login", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "User name already exists");
                }
            }

            return View();

        }
    }
}