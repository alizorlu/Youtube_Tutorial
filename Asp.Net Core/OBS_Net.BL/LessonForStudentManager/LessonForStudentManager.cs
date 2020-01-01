using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OBS_Net.BL.LessonManager;
using OBS_Net.BL.StudentManager;
using OBS_Net.DAL.ORM.EFCore;
using OBS_Net.Entities.Model;
using OBS_Net.Entities.Tables;

namespace OBS_Net.BL.LessonForStudentManager
{
    public class LessonForStudentManager : ILessonForStudentManager
    {
        private readonly IObsNetRepository<LessonForStudent> _repository;
        private readonly IStudentManager _student;
        private readonly ILessonManager _lesson;
        public LessonForStudentManager(
            IObsNetRepository<LessonForStudent> repository,
            IStudentManager student,
            ILessonManager lesson
            )
        {
            _lesson = lesson;
            _student = student;
            _repository = repository;
        }
        public LessonForStudent Create(LessonForStudent model)
        {
            _repository.Create(model);
            return model;
        }

        public IQueryable<LessonForStudent> GetAll()
        {
            return _repository.GetQuery();
        }

        public LessonForStudentModel GetCreateModel()
        {
            return new LessonForStudentModel
            {
                LessonForStudent = new LessonForStudent { Id = Guid.NewGuid() },
                LessonList = _lesson.GetSelectList(),
                StudentList = _student.GetSelectList()

            };
        }
    }
}
