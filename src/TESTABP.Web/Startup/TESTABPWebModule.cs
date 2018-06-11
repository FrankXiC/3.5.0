using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TESTABP.Configuration;
using TESTABP.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace TESTABP.Web.Startup
{
    [DependsOn(
        typeof(TESTABPApplicationModule), 
        typeof(TESTABPEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class TESTABPWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public TESTABPWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(TESTABPConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<TESTABPNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(TESTABPApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TESTABPWebModule).GetAssembly());
        }
    }
}