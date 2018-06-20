using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace TESTABP.Web.Controllers {
    public class HomeController : TESTABPControllerBase {
        private readonly IPersonAppService _personAppService;

        public HomeController(IPersonAppService personAppService) {
            _personAppService = personAppService;
        }
        public ActionResult Index() {
            if (HttpContext.Request.Cookies["User"]==null)
            {
                return View("Login");
            }
            else
            {
                return View();
            }
        }
      
        public async Task<IActionResult> Login(Person person) {
            var personlogin = _personAppService.GetPersonByUserId(person.UserId);
            if (personlogin==null)
            {
                return View("Login");
            }
            else
            {
                var claims=new List<Claim>
                {
                    new Claim("UserId",personlogin.UserId),
                };
                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties{};
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                return View("Index");
            }
        }

        public ActionResult About() {
            return View();
        }

        public ActionResult TaskList() {
            return View();
        }
    }
}
