﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineExamSystem.DataServicesLayer;

#nullable disable

namespace OnlineExamSystem.Migrations
{
    [DbContext(typeof(ExamDbContext))]
    [Migration("20230510135758_d")]
    partial class d
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.School.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnedTeacherId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("OwnedTeacherId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.School.ClassStudent", b =>
                {
                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ClassStudentId")
                        .HasColumnType("int");

                    b.HasKey("ClassId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ClassStudent");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.School.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("AccRole")
                        .HasColumnType("int");

                    b.Property<string>("AvatarURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InfoUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumericIdentification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnswerId"));

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("Hint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Mark")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.StudentAnswerResponse", b =>
                {
                    b.Property<int>("StudentAnswerResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentAnswerResponseId"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("SelectedOption")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("StudentAnswerResponseId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId");

                    b.ToTable("StudentAnswerResponses");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestId"));

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("JoinPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.TestTaker", b =>
                {
                    b.Property<int>("TestTakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestTakerId"));

                    b.Property<int>("CorrectAnswerCount")
                        .HasColumnType("int");

                    b.Property<float>("FinalScore")
                        .HasColumnType("real");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("StudentUserId")
                        .HasColumnType("int");

                    b.Property<int>("SubmitedAnswerCount")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int>("TimeTakenSeconds")
                        .HasColumnType("int");

                    b.HasKey("TestTakerId");

                    b.HasIndex("StudentUserId");

                    b.HasIndex("TestId");

                    b.ToTable("TestTakers");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.School.Class", b =>
                {
                    b.HasOne("OnlineExamSystem.DataServicesLayer.Model.School.User", "OwnedTeacher")
                        .WithMany()
                        .HasForeignKey("OwnedTeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("OwnedTeacher");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.School.ClassStudent", b =>
                {
                    b.HasOne("OnlineExamSystem.DataServicesLayer.Model.School.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineExamSystem.DataServicesLayer.Model.School.User", "Student")
                        .WithMany("ClassStudents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.Answer", b =>
                {
                    b.HasOne("OnlineExamSystem.DataServicesLayer.Model.Tests.Question", null)
                        .WithMany("AnswerOptions")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.Question", b =>
                {
                    b.HasOne("OnlineExamSystem.DataServicesLayer.Model.Tests.Test", null)
                        .WithMany("Questions")
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.StudentAnswerResponse", b =>
                {
                    b.HasOne("OnlineExamSystem.DataServicesLayer.Model.Tests.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineExamSystem.DataServicesLayer.Model.Tests.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineExamSystem.DataServicesLayer.Model.School.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Test");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.TestTaker", b =>
                {
                    b.HasOne("OnlineExamSystem.DataServicesLayer.Model.School.User", "Student")
                        .WithMany()
                        .HasForeignKey("StudentUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineExamSystem.DataServicesLayer.Model.Tests.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.School.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.School.User", b =>
                {
                    b.Navigation("ClassStudents");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.Question", b =>
                {
                    b.Navigation("AnswerOptions");
                });

            modelBuilder.Entity("OnlineExamSystem.DataServicesLayer.Model.Tests.Test", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
