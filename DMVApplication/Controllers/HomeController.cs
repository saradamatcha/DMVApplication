using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DMVApplication.Models;

namespace DMVApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Renewal()
        {
            ViewBag.Message = "Driver's Licence Renewal";
            return View("Renewal");
        }

        public ActionResult Submit(DriversDetails dd)
        {
            if(ModelState.IsValid)
            {
                DriversDetailsList ddList = new DriversDetailsList();
                DriversDetails driversDetails = ddList.GetDriversDetails(dd);
                if (driversDetails != null)
                {
                    if ((driversDetails.ExpirateDate - DateTime.Now).TotalDays < 60)
                    {
                        return View("DriversDetails", driversDetails);
                        
                    }
                    else
                    
                    {
                        ModelState.AddModelError("ExpirateDate", "The expiration is more than 60 days, it should be less than 60 days");
                    }

                }
                else
                {
                    ModelState.AddModelError("DriverLastName", "The Name and LicenceID are incorrect");
                   
                }
            }
            
                return View("Renewal");
            
        }
        public ActionResult Admin()
        {
            ViewBag.Message = "Admin";

            return View();
        }
    }
}