using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace TESTABP
{
    [AutoMapTo(typeof(Course))]
    public class CourseCreateInput
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string CourseId { get; set; }

        public DateTime CreationTime { get; set; }

        public string Teacher { get; set; }
        public int Score { get; set; }
    }
}