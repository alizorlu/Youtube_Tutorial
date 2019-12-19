using System;
using System.Collections.Generic;
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
        public string Name { get; set; }
        public string Code { get; set; }
       
    }
}
