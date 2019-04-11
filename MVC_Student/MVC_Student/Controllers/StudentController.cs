using MVC_Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Student.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var seznam = new List<Student>()
            {
                new Student(){StudentId=1,StudentName="John",Age=18},
                new Student(){StudentId=2,StudentName="Steve",Age=19},
                new Student(){StudentId=3,StudentName="Bill",Age=20},
                new Student(){StudentId=4,StudentName="Ron",Age=21},
                new Student(){StudentId=5,StudentName="Rob",Age=22},
                new Student(){StudentId=6,StudentName="Kriss",Age=19},
                new Student(){StudentId=7,StudentName="Bob",Age=21},
                new Student(){StudentId=8,StudentName="Angel",Age=21}
            };
            return View(seznam);
        }
        public ActionResult TestRedni()
        {
            Student x = new Student()
            { StudentId = 9, StudentName = "Miha", Age = 22 };
            return View(x);
        }
    }
}