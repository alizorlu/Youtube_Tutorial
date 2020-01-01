using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OBS_Net.Entities.Tables
{
    [Table("Tbl_Lessons",Schema ="Obs")]
    public class Lesson
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(150)]
        [MinLength(10)]
        [DisplayName("Ders Adı")]
        public string Name { get; set; }
        [DisplayName("Ders Kodu")]
        public string Code { get; set; }

        [ForeignKey("Teacher")]
        [DisplayName("Dersin Sorumlusu")]
        public Guid? TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
