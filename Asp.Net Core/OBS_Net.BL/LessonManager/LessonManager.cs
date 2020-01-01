using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OBS_Net.BL.TeacherManager;
using OBS_Net.DAL.ORM.EFCore;
using OBS_Net.Entities.Model;
using OBS_Net.Entities.Tables;

namespace OBS_Net.BL.LessonManager
{
    public class LessonManager : ILessonManager
    {
        private readonly IObsNetRepository<Lesson> _repository;
        private readonly ITeacherManager _teacher;
        public LessonManager(IObsNetRepository<Lesson> repository,ITeacherManager teacher)
        {
            _repository = repository;
            _teacher = teacher;
        }
        public IQueryable<Lesson> All()
        {
            return _repository.GetQuery();
        }

        public Lesson Create(Lesson lesson)
        {
            _repository.Create(lesson);
            return lesson;
        }

        public LessonModel GetCreateModel()
        {
            LessonModel model = new LessonModel();
            model.Lesson = new Lesson() { Id = Guid.NewGuid() };
            model.TeacherList = _teacher.GetSelectList();
            return model;
        }

        public List<SelectListItem> GetSelectList()
        {
            return _repository.GetQuery()
                .Include(sa => sa.Teacher)
                 .Select(sa => new SelectListItem()
                 {
                     Text = $"{sa.Code}-{sa.Name} # {sa.Teacher.NameSurname}",
                     Value = sa.Id.ToString()
                 }).ToList();
        }
    }
}
