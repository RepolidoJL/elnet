using Microsoft.AspNetCore.Mvc;
using REPOLIDO_MachineProblem1.Models;
using System.Collections.Generic;

namespace REPOLIDO_MachineProblem1.Controllers
{
    public class StudentHonorsController : Controller
    {
        private static List<StudentHonor> honorList = new List<StudentHonor>();

        public IActionResult Index()
        {
            return View(honorList);
        }

        [HttpPost]
        public IActionResult Index(StudentHonor student)
        {
            if (ModelState.IsValid)
            {
                if (student.Grade >= 98)
                    student.Honor = "Summa Cum Laude";
                else if (student.Grade >= 95)
                    student.Honor = "Magna Cum Laude";
                else if (student.Grade >= 90)
                    student.Honor = "Cum Laude";
                else
                    student.Honor = "No Honor";

                honorList.Add(student);
            }

            return View(honorList);
        }
    }
}
