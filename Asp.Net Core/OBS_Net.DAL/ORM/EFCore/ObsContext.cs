using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using OBS_Net.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS_Net.DAL.ORM.EFCore
{
    public class ObsContext:DbContext
    {
        
        public ObsContext(DbContextOptions<ObsContext> options)
       : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LessonForStudent>()
                .HasOne(sa => sa.Student)
                .WithMany(sa => sa.MyLessons)
                .HasForeignKey(sa => sa.StudentId);
            modelBuilder.Entity<Lesson>()
                .HasOne(sa => sa.Teacher)
                .WithMany(sa => sa.MeLessons)
                .HasForeignKey(sa => sa.TeacherId);
        }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonForStudent> LessonForStudents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        
    }
}
