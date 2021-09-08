using Abp.Web.Mvc.Views;

namespace Vetrotech.Web.Views
{
    public abstract class VetrotechWebViewPageBase : VetrotechWebViewPageBase<dynamic>
    {

    }

    public abstract class VetrotechWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected VetrotechWebViewPageBase()
        {
            LocalizationSourceName = VetrotechConsts.LocalizationSourceName;
        }
    }
}