using System;
using System.Collections.Generic;
using System.Text;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Domain.Uow;
using Abp.Runtime.Caching;
using Abp.Zero.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace TESTABP.Role {
    class RoleManager : AbpRoleManager<Role, Person> {
        public RoleManager(
            AbpRoleStore<Role, Person> store, 
            IEnumerable<IRoleValidator<Role>> roleValidators, 
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            ILogger<AbpRoleManager<Role, Person>> logger, 
            IPermissionManager permissionManager, 
            ICacheManager cacheManager, 
            IUnitOfWorkManager unitOfWorkManager, 
            IRoleManagementConfig roleManagementConfig) 
            : base(store, 
                roleValidators, 
                keyNormalizer, 
                errors, 
                logger, 
                permissionManager, 
                cacheManager, 
                unitOfWorkManager, 
                roleManagementConfig) {
        }
    }
}
