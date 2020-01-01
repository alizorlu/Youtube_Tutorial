using Microsoft.AspNetCore.Mvc.Rendering;
using OBS_Net.Entities.Model;
using OBS_Net.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBS_Net.BL.LessonManager
{
    public interface ILessonManager
    {
        IQueryable<Lesson> All();
        Lesson Create(Lesson lesson);

        List<SelectListItem> GetSelectList();
        LessonModel GetCreateModel();
    }
}
