using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TESTABP.EntityFrameworkCore
{
    [DependsOn(
        typeof(TESTABPCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class TESTABPEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TESTABPEntityFrameworkCoreModule).GetAssembly());
        }
    }
}