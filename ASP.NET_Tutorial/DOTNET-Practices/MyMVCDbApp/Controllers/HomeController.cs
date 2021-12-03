using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMvc.Models;
using MyDbMvc.Db.DbOperations;

namespace MyMVCDbApp.Controllers
{
    public class HomeController : Controller
    {
        StudentRepository studrepo = null;
        //Create Constructor
        public HomeController()
        {
            studrepo = new StudentRepository();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentModel model)
        {
            if(ModelState.IsValid)
            {
                int studid = studrepo.AddEmployee(model);
                if(studid>0)
                {
                    ModelState.Clear();
                    ViewBag.IsSuccess = "Data Added Successfully";
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult GetAllRecords()
        {
            var result = studrepo.GetAllStudent();
            return View(result);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var result = studrepo.GetOneStudent(id);
            return View(result);
        }

        public ActionResult Edit(int id)
        {
            var result = studrepo.GetOneStudent(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                studrepo.UpdateStudent(model.Id, model);
                return RedirectToAction("GetAllRecords");
            }
            return View();
        }

        //Without Using Delete template
        public ActionResult Delete(int id)
        {
            studrepo.DeleteStudent(id);
            return RedirectToAction("GetAllRecords");
        }

        //OR Using Delete template
        /*[HttpGet]
        public ActionResult Delete(int id)
        {
            var result = studrepo.GetOneStudent(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Delete(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                studrepo.DeleteStudent(model.Id);
                return RedirectToAction("GetAllRecords");
            }
            return View();
        }*/

        //------------------------------------------------------------
        public ActionResult Index()
        {
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