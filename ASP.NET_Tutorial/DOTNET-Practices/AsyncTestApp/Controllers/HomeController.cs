using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AsyncTestApp.Controllers
{
    public class HomeController : Controller
    {
        SampleEntities db = new SampleEntities();
        // GET: Home
        //To make async
        public async Task<ActionResult> Index()
        {
            var empList = await db.tblEmployee.ToListAsync();
            return View(empList);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(tblEmployee model)
        {
            if (ModelState.IsValid)
            {
                db.tblEmployee.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}