using Microsoft.AspNetCore.Mvc;
using REPOLIDO_MachineProblem1.Models;
using System.Collections.Generic;

namespace REPOLIDO_MachineProblem1.Controllers
{
    public class StudentProfileController : Controller
    {
        private static List<StudentProfile> studentList = new List<StudentProfile>();

        public IActionResult Index()
        {
            return View(studentList);
        }

        [HttpPost]
        public IActionResult Index(StudentProfile student)
        {
            if (ModelState.IsValid)
            {
                studentList.Add(student);
            }

            return View(studentList);
        }
    }
}
