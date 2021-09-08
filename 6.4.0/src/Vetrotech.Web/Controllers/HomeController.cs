using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Vetrotech.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : VetrotechControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}