using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoPark2020;
using GoPark2020.Models;

namespace GoPark2020.Controllers
{
    public class ReserveSpotController : Controller
    {
        private GoParkContext db = new GoParkContext();
        // GET: ReserveSpot
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        public ActionResult SignIn()
        {
            return View();
        }
        // POST: User/Create
        //[HttpPost]
        //public ActionResult CreateUser(GoParkDB2020.Models.User model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            using (var ctx = new GoParkContext())
        //            {
        //                var user = new GoParkDB2020.Models.User
        //                {
        //                    FirstName = model.FirstName,
        //                    RequiresHandicapAccomodation = model.RequiresHandicapAccomodation,
        //                    PassportNumber = model.PassportNumber
        //                };
        //                ctx.Users.Add(user);
        //                ctx.SaveChanges();

                        //return RedirectToAction("SignUp",);
        //            }
        //        }
        //        else
        //        {
        //            return View(model);
        //        }
        //    }
        //    catch
        //    {
        //    }

        //    return View(model);
        //}

        public ActionResult SignUp()
        {
            return View();

        }

        public ActionResult ConfirmAccount()
        {
            return View();
        }
        public ActionResult ReserveSpot()
        {
            return View();
        }
        public ActionResult ConfirmSpot()
        {
            return View();
        }
    }
}
