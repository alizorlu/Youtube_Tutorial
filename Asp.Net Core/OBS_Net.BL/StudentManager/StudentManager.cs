using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OBS_Net.DAL.ORM.EFCore;
using OBS_Net.Entities.Tables;

namespace OBS_Net.BL.StudentManager
{
    public class StudentManager : IStudentManager
    {
        private readonly IObsNetRepository<Student> _repository;
        public StudentManager(IObsNetRepository<Student> repository)
        {
            _repository = repository;
        }
        public Student Create(Student student)
        {
            _repository.Create(student);
            return student;
        }

        public string CreateStudentNumber()
        {
            bool created = false;
            while (created==false)
            {
                string number = $"{DateTime.Now.Year}{new Random().Next(10000, 99999)}";
                var query = _repository.Get().Where(sa => sa.StudentNu.Equals(number)).ToList();
                if (query == null || query.Count() == 0)
                {
                    created = true;
                    return number;
                }
                else
                {
                    created = false;
                    continue;
                }
            }
            throw new NullReferenceException("Öğrenci numarası oluşturulamadı");
           
        }

        public List<Student> Get()
        {
            return _repository.Get();
        }

        public Student GetCreateModel()
        {
            return new Student
            {
                StudentNu = this.CreateStudentNumber(),
                RegisterDate = DateTime.Now,
                ProfileImage= "https://image.flaticon.com/icons/svg/1651/1651586.svg"
            };
        }

        public List<SelectListItem> GetSelectList()
        {
            return _repository.Get()
                 .Select(sa => new SelectListItem()
                 {
                     Text = $"{sa.StudentNu}-{sa.NameSurname}({sa.IsActive})",
                     Value = sa.Id.ToString()
                 })
                 .ToList();
        }
    }
}
