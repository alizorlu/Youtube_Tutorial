using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using OBS_Net.DAL.ORM.EFCore;
using OBS_Net.Entities.Tables;

namespace OBS_Net.BL.TeacherManager
{
    public class TeacherManager : ITeacherManager
    {
        private readonly IObsNetRepository<Teacher> _repository;
        public TeacherManager(IObsNetRepository<Teacher> repository)
        {
            _repository = repository;
        }
        public Teacher Create(Teacher teacher)
        {
            _repository.Create(teacher);
            return teacher;
        }

        public List<Teacher> Get()
        {
            return _repository.Get();
        }

        public Teacher GetCreateModel()
        {
            return new Teacher
            {
                Id = Guid.NewGuid()
            };
        }

        public List<SelectListItem> GetSelectList()
        {
            List<SelectListItem> result = _repository.Get()
                .Select(sa => new SelectListItem()
                {
                    Text = $"{sa.Tag} {sa.NameSurname}",
                    Value = sa.Id.ToString()
                }).ToList();
            return result;
        }
    }
}
