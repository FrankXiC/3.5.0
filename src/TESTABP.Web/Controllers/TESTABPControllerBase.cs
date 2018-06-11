using Abp.AspNetCore.Mvc.Controllers;

namespace TESTABP.Web.Controllers
{
    public abstract class TESTABPControllerBase: AbpController
    {
        protected TESTABPControllerBase()
        {
            LocalizationSourceName = TESTABPConsts.LocalizationSourceName;
        }
    }
}