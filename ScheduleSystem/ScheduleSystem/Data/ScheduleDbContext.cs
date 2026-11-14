using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScheduleSystem.Entities;

namespace ScheduleSystem.Data
{
    public class ScheduleDbContext : DbContext
    {
        public DbSet<Audience> Audiences { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<TeacherDiscipline> TeacherDisciplines { get; set; }
        public DbSet<Curriculum> Curriculums { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        // Публичный конструктор для передачи настроек из Program.cs
        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options) : base(options) { }

        // Резервный конструктор
        protected ScheduleDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(
                    "Host=localhost;Port=5432;Database=schedule_db;Username=postgres;Password=qwerty");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Связь многие-ко-многим: Преподаватель <-> Дисциплина
            modelBuilder.Entity<TeacherDiscipline>()
                .HasOne<Teacher>()
                .WithMany()
                .HasForeignKey(td => td.TeacherId);

            modelBuilder.Entity<TeacherDiscipline>()
                .HasOne<Discipline>()
                .WithMany()
                .HasForeignKey(td => td.DisciplineId);

            // Связи для Учебного плана
            modelBuilder.Entity<Curriculum>()
                .HasOne<StudentGroup>().WithMany().HasForeignKey(c => c.GroupId);
            modelBuilder.Entity<Curriculum>()
                .HasOne<Discipline>().WithMany().HasForeignKey(c => c.DisciplineId);
            modelBuilder.Entity<Curriculum>()
                .HasOne<Teacher>().WithMany().HasForeignKey(c => c.TeacherId);

            // Связи для Расписания
            modelBuilder.Entity<Lesson>()
                .HasOne<Audience>().WithMany().HasForeignKey(l => l.AudienceId);
            modelBuilder.Entity<Lesson>()
                .HasOne<Teacher>().WithMany().HasForeignKey(l => l.TeacherId);
            modelBuilder.Entity<Lesson>()
                .HasOne<Discipline>().WithMany().HasForeignKey(l => l.DisciplineId);
            modelBuilder.Entity<Lesson>()
                .HasOne<StudentGroup>().WithMany().HasForeignKey(l => l.GroupId);
        }
    }
}