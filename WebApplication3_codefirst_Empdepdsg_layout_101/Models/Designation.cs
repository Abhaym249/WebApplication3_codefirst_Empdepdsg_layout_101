using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3_codefirst_Empdepdsg_layout_101.Models
{
    public class Designation
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}