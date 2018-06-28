using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TESTABP
{
    [Table("AppCourses")]
    public class Course : Entity, IHasCreationTime {
        public const int MaxNameLength = 32;

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public string CourseId { get; set; }

        public DateTime CreationTime { get; set; }
     
        public string Teacher { get; set; }
        public int Score { get; set; }

        public Course() {

        }

        public Course(string courseId) {
            CourseId = courseId;
        }
    }
}
