using Microsoft.AspNetCore.Mvc;

namespace TESTABP.Web.Controllers
{
    public class HomeController : TESTABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}