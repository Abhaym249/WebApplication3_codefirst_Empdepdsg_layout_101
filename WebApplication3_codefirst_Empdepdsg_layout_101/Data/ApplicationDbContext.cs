using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication3_codefirst_Empdepdsg_layout_101.Models;

namespace WebApplication3_codefirst_Empdepdsg_layout_101.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("Constr")
        {
        }
       
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}