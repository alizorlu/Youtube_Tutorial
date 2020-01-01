using Microsoft.AspNetCore.Mvc.Rendering;
using OBS_Net.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS_Net.BL.TeacherManager
{
    public interface ITeacherManager
    {
        List<Teacher> Get();

        Teacher Create(Teacher teacher);

        Teacher GetCreateModel();

        List<SelectListItem> GetSelectList();
    }
}
