﻿using MVC_Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Student.Controllers
{
    public class StudentController : Controller
    {

        List<Student> seznam = new List<Student>()
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
        // GET: Student
        public ActionResult Index()
        {
            return View(seznam);
        }
        public ActionResult TestRedni()
        {
            Student x = new Student()
            { StudentId = 9, StudentName = "Miha", Age = 22 };
            return View(x);
        }
        public ActionResult Edit(int id)
        {
            var std = (from a in seznam
                      where a.StudentId == id
                      select a).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(Student std)
        {

            if (ModelState.IsValid)
            {
                Student a = std;
                // zapiši spremembe v bazo
                return RedirectToAction("Index");
            }
            return View(std);
        }
    }
}