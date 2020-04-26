using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Academies
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public Guid CourseId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Slug { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public long Length { get; set; }

        [Required]
        public long TotalSteps { get; set; }


        public string Updated { get; set; }

        [Required]
        public string Steps { get; set; }
    }
}