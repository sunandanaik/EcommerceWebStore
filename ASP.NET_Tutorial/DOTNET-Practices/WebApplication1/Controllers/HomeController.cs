using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    [OutputCache(Duration = 20)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult GetDate()
        {
            return View();
        }
        public ActionResult GetTime()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(Employee emp)
        {
            return Json("true",JsonRequestBehavior.AllowGet);
        }

        public ActionResult List()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Sunanda",
                    LastName = "Naik",
                    Email = "sun@mail.com",
                    description = "This is first desc."
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Steve",
                    LastName = "Smith",
                    Email = "steve@mail.com",
                    description = "This is Second desc."
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "doe@mail.com",
                    description = "This is Third desc."
                }

            };
            return View(emp);
        }

        public JsonResult Countries()
        {
            List<string> countries = new List<string>()
            {
                "India","Japan","USA","Australia"
            };
            var json = JsonConvert.SerializeObject(countries);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
        public JsonResult States()
        {
            List<string> states = new List<string>()
            {
                "Delhi","Tokyo","Washington","Sydney"
            };
            var json = JsonConvert.SerializeObject(states);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        public JsonResult City()
        {
            List<string> city = new List<string>()
            {
                "Noida","jcity","michigan","acity"
            };
            var json = JsonConvert.SerializeObject(city);
            return Json(json, JsonRequestBehavior.AllowGet);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}