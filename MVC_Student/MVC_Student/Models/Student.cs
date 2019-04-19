using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Student.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [DisplayName("Ime")]
        [Required(ErrorMessage ="Ime je zahtevan podatek")]
        public string StudentName { get; set; }
        [DisplayName("Leta")]
        [Range(5,30,ErrorMessage = "Leta niso primerna")]
        public int Age { get; set; }
        
    }
}