﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace StudentManagementAPI.Migrations
{
    [DbContext(typeof(StudentManagementContext))]
    partial class StudentManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssignmentId"), 1L, 1);

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("Date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AssignmentId");

                    b.HasIndex("CourseCode");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<int>("CourseOfferingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("Date");

                    b.HasKey("ClassId");

                    b.HasIndex("CourseOfferingId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.ClassAttendance", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceId"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("AttendanceId");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("ClassAttendances");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Course", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CourseCredit")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CourseCode");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseCode = "CSE101",
                            CourseCredit = 3,
                            CourseName = "Introduction to Computer Science"
                        },
                        new
                        {
                            CourseCode = "CSE102",
                            CourseCredit = 3,
                            CourseName = "Data Structures"
                        },
                        new
                        {
                            CourseCode = "CSE103",
                            CourseCredit = 3,
                            CourseName = "Algorithms"
                        },
                        new
                        {
                            CourseCode = "CSE104",
                            CourseCredit = 3,
                            CourseName = "Database Management Systems"
                        },
                        new
                        {
                            CourseCode = "CSE105",
                            CourseCredit = 3,
                            CourseName = "Operating Systems"
                        },
                        new
                        {
                            CourseCode = "CSE106",
                            CourseCredit = 3,
                            CourseName = "Computer Networks"
                        },
                        new
                        {
                            CourseCode = "CSE107",
                            CourseCredit = 3,
                            CourseName = "Software Engineering"
                        },
                        new
                        {
                            CourseCode = "CSE108",
                            CourseCredit = 3,
                            CourseName = "Web Development"
                        },
                        new
                        {
                            CourseCode = "CSE109",
                            CourseCredit = 3,
                            CourseName = "Artificial Intelligence"
                        },
                        new
                        {
                            CourseCode = "CSE110",
                            CourseCredit = 3,
                            CourseName = "Machine Learning"
                        },
                        new
                        {
                            CourseCode = "CSE201",
                            CourseCredit = 3,
                            CourseName = "Object-Oriented Programming"
                        });
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.CourseOffering", b =>
                {
                    b.Property<int>("CourseOfferingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseOfferingId"), 1L, 1);

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("CourseOfferingId");

                    b.HasIndex("CourseCode");

                    b.HasIndex("TeacherId");

                    b.ToTable("CourseOfferings");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentId"), 1L, 1);

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("CourseCode");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("Date");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("UserId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Submission", b =>
                {
                    b.Property<int>("SubmissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubmissionId"), 1L, 1);

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("Date");

                    b.HasKey("SubmissionId");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.HasIndex("UserId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordHashKey")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Role")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 100,
                            Password = new byte[] { 40, 63, 89, 175, 17, 110, 38, 125, 94, 137, 232, 135, 205, 127, 144, 7, 185, 145, 89, 70, 184, 135, 25, 41, 152, 0, 46, 170, 194, 241, 32, 228, 163, 110, 115, 63, 167, 24, 169, 115, 162, 73, 26, 40, 220, 194, 17, 179, 171, 171, 91, 223, 154, 157, 230, 29, 227, 36, 67, 188, 118, 201, 170, 174 },
                            PasswordHashKey = new byte[] { 36, 189, 54, 249, 161, 141, 112, 196, 39, 157, 243, 131, 227, 7, 21, 245, 145, 173, 19, 59, 72, 172, 236, 223, 200, 143, 146, 58, 92, 169, 99, 204, 51, 86, 170, 1, 9, 244, 175, 199, 115, 183, 54, 83, 230, 87, 156, 108, 173, 95, 17, 207, 73, 0, 16, 57, 133, 98, 165, 216, 130, 219, 162, 11, 16, 0, 250, 224, 41, 112, 16, 222, 198, 91, 213, 52, 204, 40, 174, 189, 139, 165, 215, 24, 0, 132, 61, 221, 44, 165, 186, 7, 7, 33, 171, 58, 84, 35, 210, 29, 180, 214, 80, 242, 11, 223, 189, 13, 212, 197, 146, 251, 118, 63, 228, 61, 173, 197, 134, 119, 194, 224, 122, 21, 152, 10, 155, 242 },
                            RegistrationDate = new DateTime(2024, 5, 28, 16, 25, 12, 114, DateTimeKind.Utc).AddTicks(9792),
                            Role = 0,
                            Status = "Active",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Assignment", b =>
                {
                    b.HasOne("StudentManagementAPI.Models.DBModels.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("CourseCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Class", b =>
                {
                    b.HasOne("StudentManagementAPI.Models.DBModels.CourseOffering", "CourseOffering")
                        .WithMany("Classes")
                        .HasForeignKey("CourseOfferingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseOffering");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.ClassAttendance", b =>
                {
                    b.HasOne("StudentManagementAPI.Models.DBModels.Class", "Class")
                        .WithMany("ClassAttendances")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudentManagementAPI.Models.DBModels.Student", "Student")
                        .WithMany("ClassAttendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.CourseOffering", b =>
                {
                    b.HasOne("StudentManagementAPI.Models.DBModels.Course", "Course")
                        .WithMany("CourseOfferings")
                        .HasForeignKey("CourseCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementAPI.Models.DBModels.Teacher", "Teacher")
                        .WithMany("CourseOfferings")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Enrollment", b =>
                {
                    b.HasOne("StudentManagementAPI.Models.DBModels.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudentManagementAPI.Models.DBModels.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Student", b =>
                {
                    b.HasOne("StudentManagementAPI.Models.DBModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Submission", b =>
                {
                    b.HasOne("StudentManagementAPI.Models.DBModels.Assignment", "Assignment")
                        .WithMany("Submissions")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudentManagementAPI.Models.DBModels.Student", "Student")
                        .WithMany("Submissions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Teacher", b =>
                {
                    b.HasOne("StudentManagementAPI.Models.DBModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Assignment", b =>
                {
                    b.Navigation("Submissions");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Class", b =>
                {
                    b.Navigation("ClassAttendances");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Course", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("CourseOfferings");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.CourseOffering", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Student", b =>
                {
                    b.Navigation("ClassAttendances");

                    b.Navigation("Enrollments");

                    b.Navigation("Submissions");
                });

            modelBuilder.Entity("StudentManagementAPI.Models.DBModels.Teacher", b =>
                {
                    b.Navigation("CourseOfferings");
                });
#pragma warning restore 612, 618
        }
    }
}
