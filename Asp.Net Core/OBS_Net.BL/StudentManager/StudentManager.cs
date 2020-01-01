using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


        public List<Student> Get()
        {
            return _repository.Get();
        }

    }
}
