using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
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
                .HasOne(f => f.Teacher)
                .WithMany(m => m.MeLessons)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Teacher>()
                .HasMany(sa => sa.MeLessons)
                .WithOne(f => f.Teacher);
            modelBuilder.Entity<Student>()
                .HasMany(sa => sa.MyLessons)
                .WithOne(sa => sa.Student);

        }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonForStudent> LessonForStudents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        
    }
}
