using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApp.Models;

namespace MyMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> emp = employeeContext.Employees.ToList();
            return View(emp);
        }
        // GET: Employee
        public ActionResult Create(int id)
        {
            EmployeeContext empContext = new EmployeeContext();
            //To fetch single record
            Employee employee = empContext.Employees.Single(x => x.EmpId == id);
            /*Employee emp = new Employee()
            {
                EmpId = 101,
                Name = "John",
                Gender = "Male",
                City = "London"
            };*/
            return View(employee);
        }
    }
}