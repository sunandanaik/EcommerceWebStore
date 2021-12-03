using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace DependencyInjectApp.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee emp = null;
        private IStudent stud = null;

        //Now to introduce Dependency Injection
        public HomeController(IEmployee iemp,IStudent istud)
        {
            emp = iemp;
            stud = istud;
            //emp = new Employee();
            
        }
        public string CountEmployee()
        {
            int count = emp.GetTotalEmployees();
            bool data = stud.IsStudent();
            return "Total Employees are :"+count+ " And is a Student ?:"+data;
        }
        public ActionResult Index()
        {
            //int count = emp.GetTotalEmployees();
            return View();
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