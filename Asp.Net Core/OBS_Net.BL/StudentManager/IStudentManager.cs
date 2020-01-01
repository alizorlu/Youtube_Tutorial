using OBS_Net.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBS_Net.BL.StudentManager
{
    public interface IStudentManager
    {
        List<Student> Get();
        Student Create(Student student);
    }
}
