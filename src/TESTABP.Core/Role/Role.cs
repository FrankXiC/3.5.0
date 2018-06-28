using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Authorization.Roles;

namespace TESTABP.Role
{
    public class Role : AbpRole<Person> {
        public const int MaxDescriptionLength = 5000;

        public Role() {
        }

        public Role(int? tenantId, string displayName)
            : base(tenantId, displayName) {
        }

        public Role(int? tenantId, string name, string displayName)
            : base(tenantId, name, displayName) {
        }

        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }
    }
}
