using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OBS_Net.BL.LessonManager;
using OBS_Net.Entities.Model;

namespace OBS_Net.Controllers
{
    public class LessonController : Controller
    {
        private readonly ILessonManager _lesson;
        public LessonController(ILessonManager lesson)
        {
            _lesson = lesson;
        }
        public IActionResult Index()
        {
            var result = _lesson.All().Include(sa => sa.Teacher).ToList();

            return View(result);
        }
        public IActionResult Create()
        {
            Entities.Model.LessonModel model = _lesson.GetCreateModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(LessonModel model)
        {
            if (base.TryValidateModel(model.Lesson))
            {
                _lesson.Create(model.Lesson);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}