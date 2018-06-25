using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TESTABP.Web.Controllers {
    public class PeopleController : TESTABPControllerBase {
        private readonly IPersonAppService _personAppService;

        public PeopleController(IPersonAppService personAppService) {
            _personAppService = personAppService;
        }

        public async Task<IActionResult> PeopleList() {
            return !HttpContext.User.Identity.IsAuthenticated ? View("../Home/Login") : View();
        }

        public async Task<IActionResult> GetPersonById(int Id) {
            var output = await _personAppService.GetPersonById(Id);

            return View("PersonEdit", output);
        }

        public async Task<IActionResult> PersonRegister() {
            return View("PersonRegister");
        }

        public async Task<IActionResult> Register(Person Input) {
            var personnew = await _personAppService.CreatePerson(Input);
            var output = _personAppService.GetPeopleList();
            output.Add(personnew);
            output.OrderByDescending(t => t.CreationTime);
            return View("PeopleList", output);
        }

        public async Task<IActionResult> EditPersonById(Person inputPerson) {
            var person = await _personAppService.EditPersonById(inputPerson);
            return View("PersonEdit", person);
        }

        public async Task<IActionResult> DeletePersonById(int id) {
            var personDelete = await _personAppService.DeletePersonById(id);
            var output = _personAppService.GetPeopleList();
            output.Remove(personDelete);
            return View("PeopleList", output);
        }
    }
}