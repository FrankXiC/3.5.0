using Abp.AspNetCore.Mvc.Views;

namespace TESTABP.Web.Views
{
    public abstract class TESTABPRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected TESTABPRazorPage()
        {
            LocalizationSourceName = TESTABPConsts.LocalizationSourceName;
        }
    }
}
