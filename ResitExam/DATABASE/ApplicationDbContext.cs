﻿using Microsoft.EntityFrameworkCore;
using ResitExam.MODEL;
namespace ResitExam.DATABASE
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Tabloları temsil eden DbSet'ler
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ResitExamObj> ResitExams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasMany<Course>(s => s.Courses).WithMany(c => c.Students);
            modelBuilder.Entity<Course>().HasOne<Instructor>(c => c.Instructor).WithMany(i => i.Courses);
            modelBuilder.Entity<Course>().HasMany<Student>(s => s.Students).WithMany(c => c.Courses);
            // Veritabanı yapılandırmalarını burada yapabilirsin (opsiyonel)
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseMySql(ServerVersion.AutoDetect("server=localhost;uid=root;pwd=1234;database=ResitExam;"));

        //}
    }
}
