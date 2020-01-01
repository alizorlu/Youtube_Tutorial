using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBS_Net.BL.TeacherManager;
using OBS_Net.Entities.Tables;

namespace OBS_Net.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherManager _teacher;
        public TeacherController(ITeacherManager teacher)
        {
            _teacher = teacher;
        }
        public IActionResult Index()
        {
            List<Entities.Tables.Teacher> result = _teacher.Get();
            return View(result);
        }
        public IActionResult Create()
        {
            var model = _teacher.GetCreateModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            if (base.TryValidateModel(teacher))
            {
                _teacher.Create(teacher);
                return RedirectToAction("Index");
            }
            return View(teacher);
        }
    }
}