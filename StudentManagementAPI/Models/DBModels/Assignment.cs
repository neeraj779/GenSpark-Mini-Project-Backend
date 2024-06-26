﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementAPI.Models.DBModels
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }

        [ForeignKey("CourseCode")]
        public string CourseCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Due date is required.")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime DueDate { get; set; }

        public Course? Course { get; set; }
        public ICollection<Submission>? Submissions { get; set; }
    }
}
