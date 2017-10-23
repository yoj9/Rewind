using Rewind.Models.DB;
using Rewind.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rewind.Models.EntityManager
{
    public class RegistrationManager
    {
        public void AddUserAccount(RegistrationViewModel user)
        {
            using (ImageBrowserEntities db = new ImageBrowserEntities())
            {
                Registration Reg = new Registration();

                Reg.firstname = user.reg_FN;
                Reg.lastname = user.reg_LN;
                Reg.email = user.Email;
                Reg.dob = user.reg_dob;
                Reg.gender = user.reg_sex;
                Reg.pwd = user.reg_pwd;
                Reg.username = user.reg_username;
        
                db.Registrations.Add(Reg);
                db.SaveChanges();


            }
        }

        public bool IsUserNameExists(string check_username)
        {
            using (ImageBrowserEntities db = new ImageBrowserEntities())
            {
                if (db.Registrations.Any(o => o.username.Equals(check_username)))
                    return true;
                else
                    return false;
            }

        }

    }
}