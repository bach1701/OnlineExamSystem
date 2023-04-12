using Microsoft.EntityFrameworkCore;
using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Model
{
    public class ExamDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<TestTaker> TestTakers { get; set; }
        public DbSet<StudentAnswerResponse> StudentAnswerResponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:db.dutlearning.koding.tk,1433;Database=OnlineExamsSystem_Test4;User ID=sa;Password=68RsyRjLfc5uqSsGYA3x;TrustServerCertificate=True;");
        }
    }
}
