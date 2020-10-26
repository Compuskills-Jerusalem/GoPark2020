using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using GoPark2020.Models;
using GoParkDB2020.DataSource;
using GoParkDB2020.Models;





namespace GoPark2020.Controllers
{
    public class ReserveSpotController : Controller
    {
        // GET: ReserveSpot
        public ActionResult Index()
        {
            //GoParkDB2020.Models.Discount discount = new GoParkDB2020.Models.Discount() { };
            //var dis = discount.DiscountID;
            ////ViewBag.Message = "Lets see if you work.😍";

            //using (var ctx = new GoParkContext())
            //{
            //    var lines = ctx.Discounts
            //        .Select(x => new GoPark2020.Models.Discount
            //        {
            //            DiscountName = x.DiscountName

            //        }).ToList();




            //    return View(lines);
            //}
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }

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
