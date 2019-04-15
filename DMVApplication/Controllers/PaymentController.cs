using DMVApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMVApplication.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Payment(DriversDetails model)
        {
            var Lid = model.LicenceID;
            ViewBag.LicenceID = Lid.ToString();
            
            return View("PaymentInfo");
        }

        public ActionResult PaymentSubmit(PaymentDetails pd)
        {
            if(ModelState.IsValid)
            {
                
            }
            return View("PaymentProcess");
        }
    }
}