using Microsoft.AspNetCore.Mvc.Rendering;
using OBS_Net.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS_Net.Entities.Model
{
    public class LessonForStudentModel
    {
        public LessonForStudent LessonForStudent { get; set; }

        public List<SelectListItem> StudentList { get; set; }
        public List<SelectListItem> LessonList { get; set; }
    }
}
