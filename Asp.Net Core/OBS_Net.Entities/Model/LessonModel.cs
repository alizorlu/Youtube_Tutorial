using Microsoft.AspNetCore.Mvc.Rendering;
using OBS_Net.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS_Net.Entities.Model
{
    public class LessonModel
    {
        public Lesson Lesson { get; set; }
        public List<SelectListItem> TeacherList { get; set; }
    }
}
