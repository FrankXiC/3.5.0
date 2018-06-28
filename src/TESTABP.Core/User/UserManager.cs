using System;
using System.Collections.Generic;
using System.Text;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.Configuration;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Organizations;
using Abp.Runtime.Caching;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace TESTABP {
    public class UserManager : AbpUserManager<Role.Role, Person> {
        public UserManager(
            AbpRoleManager<Role.Role, Person> roleManager, 
            AbpUserStore<Role.Role, Person> store, 
            IOptions<IdentityOptions> optionsAccessor, 
            IPasswordHasher<Person> passwordHasher, 
            IEnumerable<IUserValidator<Person>> userValidators, 
            IEnumerable<IPasswordValidator<Person>> passwordValidators, 
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            IServiceProvider services, 
            ILogger<UserManager<Person>> logger, 
            IPermissionManager permissionManager, 
            IUnitOfWorkManager unitOfWorkManager, 
            ICacheManager cacheManager, 
            IRepository<OrganizationUnit, long> organizationUnitRepository, 
            IRepository<UserOrganizationUnit, long> userOrganizationUnitRepository, 
            IOrganizationUnitSettings organizationUnitSettings, ISettingManager settingManager) 
            : base(roleManager, 
                store, 
                optionsAccessor, 
                passwordHasher, 
                userValidators, 
                passwordValidators, 
                keyNormalizer, 
                errors, 
                services, 
                logger, 
                permissionManager, 
                unitOfWorkManager, 
                cacheManager, 
                organizationUnitRepository, 
                userOrganizationUnitRepository, 
                organizationUnitSettings, 
                settingManager) {
        }
    }
}
