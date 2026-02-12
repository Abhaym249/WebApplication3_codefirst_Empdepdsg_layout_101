using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3_codefirst_Empdepdsg_layout_101.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public String Address { get; set; }

        public int salary { get; set; }
        //public int Edno { get; set; }
        //[ForeignKey("Edno")]
        //public Department Department { get; set; }
        //agr custom name se foreign key bna rhe ho to uska name foreign key wale property ke name se match krna chahiye
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int DesignationId { get; set; }
        public Designation Designation { get; set; }
    }
}