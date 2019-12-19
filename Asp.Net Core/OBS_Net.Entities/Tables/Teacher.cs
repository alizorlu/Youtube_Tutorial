using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OBS_Net.Entities.Tables
{
    [Table("Tbl_Teacher",Schema ="Obs")]
    public class Teacher
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(150)]
        [MinLength(10)]
        public string NameSurname { get; set; }
        [MaxLength(50)]
        public string Tag { get; set; }

        //[ForeignKey("MyLessons")]
        //public Guid LessonId { get; set; }
        //public virtual Lesson MyLesson { get; set; }

        public virtual ICollection<LessonForStudent> MeLessons { get; set; }
    }
}
