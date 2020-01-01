using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OBS_Net.BL.LessonForStudentManager;
using OBS_Net.Entities.Model;

namespace OBS_Net.Controllers
{
    public class LFSController : Controller
    {
        private readonly ILessonForStudentManager _lfs;
        public LFSController(ILessonForStudentManager lfs)
        {
            _lfs = lfs;
        }
        public IActionResult Index()
        {
            List<Entities.Tables.LessonForStudent> result = _lfs.GetAll()
                .Include(sa => sa.Lesson)
                .Include(sa => sa.Student).ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            var model = _lfs.GetCreateModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(LessonForStudentModel model)
        {
            if (base.TryValidateModel(model.LessonForStudent))
            {
                _lfs.Create(model.LessonForStudent);
                return RedirectToAction("Index");
            }
            var exModel = _lfs.GetCreateModel();
            model.LessonList = exModel.LessonList;
            model.StudentList = exModel.StudentList;
            return View(model);
        }
    }
}