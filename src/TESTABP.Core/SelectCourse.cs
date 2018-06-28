using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace TESTABP
{
    [Table("AppSelectCourse")]
    public class SelectCourse : Entity, IHasCreationTime
    {
        [Required]
        public string PersonId { get; set; }

        [Required]
        public string CourseId { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
