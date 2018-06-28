using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using System.Text;
using System.Xml;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace TESTABP {
    [Table("AppPersons")]
    public class Person : Entity, IHasCreationTime {
        public const int MaxNameLength = 32;

        [Required]
        [MaxLength(MaxNameLength)]
        public string UserId { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public DateTime CreationTime { get; set; }

        public string Sex { get; set; }

        [EmailAddress]
        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Person() {

        }

        public Person(string name) {
            Name = name;
        }
    }
}
