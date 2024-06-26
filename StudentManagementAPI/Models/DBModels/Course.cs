﻿using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models.DBModels
{
    public class Course
    {
        [Key]
        public string CourseCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Course name is required.")]
        [StringLength(100, ErrorMessage = "Course name cannot exceed 100 characters.")]
        public string CourseName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Course credit is required.")]
        [Range(1, 10, ErrorMessage = "Course credit must be between 1 and 10.")]
        public int CourseCredit { get; set; }

        public ICollection<Assignment>? Assignments { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
        public ICollection<CourseOffering>? CourseOfferings { get; set; }
    }
}
