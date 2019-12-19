using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OBS_Net.Entities.Tables
{
    [Table("Tbl_Lessons_Student",Schema ="Obs")]
    public class LessonForStudent
    {
        public Guid Id { get; set; }
        [ForeignKey("Student")]
        public Guid? StudentId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Lesson")]
        public Guid? LessonId { get; set; }
        public virtual Lesson Lesson { get; set; }
        [ForeignKey("Teacher")]
        public Guid? TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
