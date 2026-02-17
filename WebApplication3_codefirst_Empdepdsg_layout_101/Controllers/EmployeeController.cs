using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3_codefirst_Empdepdsg_layout_101.Data;
using System.Data.Entity;
using WebApplication3_codefirst_Empdepdsg_layout_101.Models;
using System.ComponentModel.DataAnnotations;

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
        public ActionResult Upsert(int? id)
        {
            ViewBag.deplist = context.Departments.ToList();
            ViewBag.dsglist = context.Designations.ToList();
            Employee employee = new Employee();
            if (id == null) return View(employee);//create
            //edit
            employee = context.Employees.Find(id.GetValueOrDefault());
            if (employee == null) return HttpNotFound();
            return View(employee);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Upsert(Employee employee)
        {
            if (employee == null) return HttpNotFound();
            if (!ModelState.IsValid) return View(employee);
            if (employee.Id == 0)
            {
                context.Employees.Add(employee);
            }
            else
            {
                var employeeFromDb = context.Employees.Find(employee.Id);
                if (employeeFromDb == null) return HttpNotFound();
                employeeFromDb.Name = employee.Name;
                employeeFromDb.Address = employee.Address;
                employeeFromDb.Salary = employee.Salary;
                employeeFromDb.DepartmentId = employee.DepartmentId;
                employeeFromDb.DesignationId = employee.DesignationId;
            }
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Details(int id)
        {
            var employeeInDb = context.Employees.Include(e => e.Department).Include(e => e.Designation).FirstOrDefault(e => e.Id == id);
            if (employeeInDb == null) return HttpNotFound();
            return View(employeeInDb);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var employeeInDb = context.Employees.Find(id);
            if (employeeInDb == null) return HttpNotFound();
            context.Employees.Remove(employeeInDb);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}