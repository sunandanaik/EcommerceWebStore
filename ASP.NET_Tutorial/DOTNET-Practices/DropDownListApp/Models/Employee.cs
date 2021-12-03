using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DropDownListApp.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        public HttpPostedFileBase file { get; set; }
    }
}