using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace OnlineExamSystem.DataServicesLayer
{
    public class ExamDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Classes { get; set; }


        public DbSet<Test> Tests { get; set; }

        // review needed
        public DbSet<Question> Questions { get; set; }
        public DbSet<TestTaker> TestTakers { get; set; }
        public DbSet<StudentAnswerResponse> StudentAnswerResponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies()
                              .UseSqlServer(@"Server=tcp:db.dutlearning.koding.tk,1433;Database=OnlineExamSystem_Dev2;User ID=sa;Password=68RsyRjLfc5uqSsGYA3x;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassStudent>()
                .HasKey(cs => new { cs.ClassId, cs.UserId });

            modelBuilder.Entity<ClassStudent>()
                .HasOne(cs => cs.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(cs => cs.ClassId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ClassStudent>()
                .HasOne(cs => cs.Student)
                .WithMany(u => u.ClassStudents)
                .HasForeignKey(cs => cs.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Class>()
                .HasOne(c => c.OwnedTeacher)
                .WithMany()
                .HasForeignKey(c => c.OwnedTeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Question>()
                .HasOne(t => t.Test)
                .WithMany()
                .HasForeignKey(t => t.TestId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
