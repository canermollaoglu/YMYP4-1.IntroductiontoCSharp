﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _21_EFOnlineCourseDB.Context;

#nullable disable

namespace _21_EFOnlineCourseDB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240609095118_Level4")]
    partial class Level4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Course", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<Guid?>("InstructorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Exam", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("ExamDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.ExamResult", b =>
                {
                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("ExamNote")
                        .HasColumnType("tinyint");

                    b.HasKey("StudentID", "ExamID");

                    b.HasIndex("ExamID");

                    b.ToTable("ExamResult");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Instructor", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Lesson", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Registration", b =>
                {
                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentID", "CourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Student", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Course", b =>
                {
                    b.HasOne("_21_EFOnlineCourseDB.Entities.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorID");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.ExamResult", b =>
                {
                    b.HasOne("_21_EFOnlineCourseDB.Entities.Exam", "Exam")
                        .WithMany("ExamResults")
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_21_EFOnlineCourseDB.Entities.Student", "Student")
                        .WithMany("ExamResults")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Lesson", b =>
                {
                    b.HasOne("_21_EFOnlineCourseDB.Entities.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseID");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Registration", b =>
                {
                    b.HasOne("_21_EFOnlineCourseDB.Entities.Course", "Course")
                        .WithMany("Registrations")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_21_EFOnlineCourseDB.Entities.Student", "Student")
                        .WithMany("Registrations")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Course", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Exam", b =>
                {
                    b.Navigation("ExamResults");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Instructor", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("_21_EFOnlineCourseDB.Entities.Student", b =>
                {
                    b.Navigation("ExamResults");

                    b.Navigation("Registrations");
                });
#pragma warning restore 612, 618
        }
    }
}
