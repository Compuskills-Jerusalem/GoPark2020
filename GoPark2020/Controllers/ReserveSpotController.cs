using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoPark.Models;
using GoParkDB.DataSource;
using GoParkDB.Models;


namespace GoPark.Controllers
{
    public class ReserveSpotController : Controller
    {
        // GET: ReserveSpot
        public ActionResult Index()
        {
            GoParkDB.Models.Discount discount = new GoParkDB.Models.Discount() { };
            var dis = discount.DiscountID;
            //ViewBag.Message = "Lets see if you work.😍";

            using (var ctx = new GoParkContext())
            {
                var lines = ctx.Discounts
                    .Select(x => new GoPark.Models.Discount
                    {
                        DiscountName = x.DiscountName

                    }).ToList();




                return View(lines);
            }
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
    }
}
