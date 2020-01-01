using OBS_Net.Entities.Model;
using OBS_Net.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBS_Net.BL.LessonForStudentManager
{
    public interface ILessonForStudentManager
    {
        IQueryable<LessonForStudent> GetAll();

        LessonForStudent Create(LessonForStudent model);

        LessonForStudentModel GetCreateModel();
    }
}
