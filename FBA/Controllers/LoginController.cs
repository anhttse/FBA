﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FBA.Extension;
using FBA.Models;
using FBA.Models.RegisterModel;

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
                var rs = db.SystemUsers.FirstOrDefault(x => string.Equals(x.Username, user.UserName.Trim()) && string.Equals(x.Password, user.Password.Trim()));
                if (rs != null)
                {
                    Session[Common.UserSession] = $"{rs.Id}_{rs.Username}";
                    return RedirectToAction("Index", "Home");
                }

                return RedirectToAction("Index", "Login");

            }
        }

        [HttpGet, AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
        [AllowAnonymous, HttpPost]
        public ActionResult Register(UserRegisterModel user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new FBLEntities())
                {
                    if (db.SystemUsers.Any(x => string.Equals(user.UserName, x.Username)))
                    {
                        user.Password = "";
                        user.ConfirmPassword = "";
                        //user.ErrorMessage = "Username already exist.";
                        return View(user);
                    }
                    if (!string.Equals(user.Password, user.ConfirmPassword))
                    {
                        user.Password = "";
                        user.ConfirmPassword = "";
                        //user.ErrorMessage = "Password does not match the confirm password.";
                        return View(user);
                    }
                    var salt = Utilities.SaltGenerate(32);
                    var us = db.SystemUsers.Add(new SystemUser() { Username = user.UserName, Password = (user.Password+salt).ToSHA(),Salt = salt});
                    db.SaveChanges();
                    if (us == null)
                    {
                        user.Password = null;
                        user.ConfirmPassword = null;
                        //user.ErrorMessage = "Something was wrong!";
                        return View(user);
                    }
                    Session[Common.UserSession] = $"{us.Id}_{us.Username}";
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();

        }
    }
}