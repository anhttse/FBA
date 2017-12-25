using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FBA.Extension;
using FBA.Models;

namespace FBA.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(User user)
        {
            using (var db = new FBLEntities())
            {
                var rs = db.SystemUsers.FirstOrDefault(x=>string.Equals(x.Username,user.UserName.Trim())&&string.Equals(x.Password,user.Password.Trim()));
                if (rs != null)
                {
                    Session[Common.UserSession] = $"{rs.Id}_{rs.Password}";
                    return RedirectToAction("Index","Home");
                }

                return RedirectToAction("Index","Login");

            }
        }
    }
}