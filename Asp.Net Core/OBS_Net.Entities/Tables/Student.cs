using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OBS_Net.Entities.Tables
{
    public enum GradeStudent
    {
        [Description("1.Sınıf")]
        OneGrade=1,
        [Description("2.Sınıf")]
        TwoGrade=2,
        [Description("3.Sınıf")]
        ThreeGrade=3,
        [Description("4.Sınıf")]
        FourGrade=4
    }

    [Table("Tbl_Students",Schema ="Obs")]
    public class Student
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(150)]
        [MinLength(10)]
        public string NameSurname { get; set; }
        [EnumDataType(typeof(GradeStudent))]
        [Required]
        public GradeStudent Grade { get; set; }
        public string StudentNu { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual ICollection<LessonForStudent> MyLessons { get; set; }
    }
}
