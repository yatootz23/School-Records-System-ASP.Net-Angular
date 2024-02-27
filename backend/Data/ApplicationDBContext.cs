using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class ApplicationDBContext(DbContextOptions options) : IdentityDbContext<Account>(options)
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Account>(entity => { entity.ToTable("Accounts"); });
            builder.Entity<Student>(entity => { entity.ToTable("Student"); });
            builder.Entity<Teacher>(entity => { entity.ToTable("Teacher"); });

            builder.Entity<Student>()
            .HasOne(p => p.Section)
            .WithMany(b => b.Students)
            .HasForeignKey(p => p.SectionId);

            builder.Entity<Grade>()
            .HasOne(p => p.Student)
            .WithMany(b => b.Grades)
            .HasForeignKey(p => p.StudentId);

            builder.Entity<Class>()
            .HasOne(p => p.Teacher)
            .WithMany(b => b.Classes)
            .HasForeignKey(p => p.TeacherId);

            builder.Entity<Teacher>()
            .HasOne(p => p.Section)
            .WithOne(b => b.Teacher)
            .HasForeignKey<Teacher>(p => p.SectionId);

            builder.Entity<Grade>()
            .HasOne(p => p.Teacher)
            .WithMany(b => b.Grades);

            builder.Entity<Grade>()
            .HasOne(p => p.Subject);

            builder.Entity<Class>()
            .HasOne(p => p.Subject);

            builder.Entity<Class>()
            .HasOne(p => p.Section)
            .WithMany(b => b.Classes)
            .HasForeignKey(p => p.SectionId);

            base.OnModelCreating(builder);

            List<IdentityRole> roles = [
                new IdentityRole{
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole{
                    Name = "Teacher",
                    NormalizedName = "TEACHER"
                },
                new IdentityRole{
                    Name = "Student",
                    NormalizedName = "STUDENT"
                }
            ];
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}