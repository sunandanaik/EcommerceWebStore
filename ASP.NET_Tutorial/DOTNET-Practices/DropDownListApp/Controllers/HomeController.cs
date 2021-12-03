using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDownListApp.Models;


namespace DropDownListApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee model)
        {
            string path = Server.MapPath("~/App_Data/Files");
            string fileName = Path.GetFileName(model.file.FileName);
            string fullPath = Path.Combine(path, fileName);
            model.file.SaveAs(fullPath);
            return View();
        }

        public FileResult Download()
        {
            string path = Server.MapPath("~/App_Data/Files");
            string fileName = Path.GetFileName("apple.jpg");
            string fullPath = Path.Combine(path, fileName);
            return File(fullPath,"image/jpg","apple.jpg");
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
        public ActionResult Test()
        {
            var clist = new List<string>() { "India", "Japan", "USA", "China" };
            ViewBag.list = clist;

            //To show selected value from dropdown
            Employee emp = new Employee()
            {
                Country = "USA"
            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult Test(Employee model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Test");
            }
            var clist = new List<string>() { "India", "Japan", "USA", "China" };
            ViewBag.list = clist; //Viewbag works for only one single call
            return View();
        }
    }
}