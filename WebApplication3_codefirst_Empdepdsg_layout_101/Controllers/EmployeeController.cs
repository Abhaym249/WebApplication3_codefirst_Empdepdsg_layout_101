using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3_codefirst_Empdepdsg_layout_101.Data;
using System.Data.Entity;

namespace WebApplication3_codefirst_Empdepdsg_layout_101.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;
        public EmployeeController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            var employeeList = context.Employees.Include(e => e.Department).Include(e => e.Designation).ToList();
            return View(employeeList);
        }
    }
}