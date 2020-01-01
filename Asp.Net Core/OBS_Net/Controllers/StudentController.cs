using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBS_Net.BL.StudentManager;

namespace OBS_Net.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentManager _student;
        public StudentController(IStudentManager student)
        {
            _student = student;
        }

        public IActionResult Index()
        {
            var result = _student.Get();
            return View();
        }
    }
}