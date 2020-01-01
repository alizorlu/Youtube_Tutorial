using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Öğretmenin Adı Soyadı")]
        public string NameSurname { get; set; }
        [DisplayName("Ünvanı")]
        [MaxLength(50)]
        public string Tag { get; set; }
        public virtual ICollection<Lesson> MeLessons { get; set; }
    }
}
