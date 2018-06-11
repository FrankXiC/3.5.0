using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TESTABP {
    [DependsOn(
        typeof(TESTABPCoreModule),
        typeof(AbpAutoMapperModule))]
    public class TESTABPApplicationModule : AbpModule {
        public override void Initialize() {
            IocManager.RegisterAssemblyByConvention(typeof(TESTABPApplicationModule).GetAssembly());
        }
    }
}