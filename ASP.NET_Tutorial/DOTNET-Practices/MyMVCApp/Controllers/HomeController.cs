using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Countries here is dynamic property which has to be passed to View.
            /*ViewBag.Countries= new List<string>()
            {
                "India",
                "USA",
                "UK",
                "Canada"
            };*/
            //Using ViewData method
            ViewData["Countries"] = new List<string>()
            {
                "India",
                "USA",
                "UK",
                "Canada",
                "Australia"
            };
            return View();        
        }
        public string GetDetails()
        {
            return "Getdetails AM invoked";
        }
    }
}