using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TESTABP.Web.Startup;
namespace TESTABP.Web.Tests {
    [DependsOn(
        typeof(TESTABPWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class TESTABPWebTestModule : AbpModule {
        public override void PreInitialize() {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize() {
            IocManager.RegisterAssemblyByConvention(typeof(TESTABPWebTestModule).GetAssembly());
        }
    }
}