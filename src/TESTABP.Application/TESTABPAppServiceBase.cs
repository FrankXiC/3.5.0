using Abp.Application.Services;

namespace TESTABP
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class TESTABPAppServiceBase : ApplicationService
    {
        protected TESTABPAppServiceBase()
        {
            LocalizationSourceName = TESTABPConsts.LocalizationSourceName;
        }
    }
}