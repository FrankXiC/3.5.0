using Abp.Modules;
using Abp.Reflection.Extensions;
using TESTABP.Localization;

namespace TESTABP {
    public class TESTABPCoreModule : AbpModule {
        public override void PreInitialize() {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            TESTABPLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize() {
            IocManager.RegisterAssemblyByConvention(typeof(TESTABPCoreModule).GetAssembly());
        }
    }
}