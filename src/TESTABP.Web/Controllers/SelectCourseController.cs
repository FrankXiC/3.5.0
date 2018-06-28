using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TESTABP.Web.Controllers {
    public class SelectCourseController : AbpController {
        private readonly IPersonAppService _personAppService;
        private readonly ICourseAppService _courseAppService;
        private readonly ISelectCourseAppService _selectCourseAppService;

        public SelectCourseController(IPersonAppService personAppService, ICourseAppService courseAppService, ISelectCourseAppService selectCourseAppService) {
            _personAppService = personAppService;
            _courseAppService = courseAppService;
            _selectCourseAppService = selectCourseAppService;
        }

        public async Task<ActionResult> SelectCourseList() {
            if (!HttpContext.User.Identity.IsAuthenticated) {
                return View("../Home/Login");
            }
            else {
                var SCList = await _selectCourseAppService.GetSelectedCourseByPersonId(HttpContext.User.Claims.First().Value);
                return View("SelectCourseList", SCList);
            }
        }

        public async Task<ActionResult> SelectCourseCreate() {
            if (!HttpContext.User.Identity.IsAuthenticated) {
                return View("../Home/Login");
            }
            else {
                var personId = HttpContext.User.Claims.First().Value;
                var person = await _personAppService.GetPersonByUserId(personId);
                var courseList = await _courseAppService.GetCoursesList();
                ViewData["person"] = person.Name;
                ViewData["personId"] = person.UserId;
                ViewData["courseList"] = courseList;
                return View();
            }
        }

        // GET: SelectCourse/Create
        public async Task<ActionResult> Create(string personId, string courseId) {
            SelectCourseInput selectCourse = new SelectCourseInput() { PersonUserId = personId, CourseId = courseId };
            SelectCourse scNew = await _selectCourseAppService.CreateSelectCourse(selectCourse);
            return RedirectToAction("SelectCourseList", "SelectCourse");
        }

        public async Task<ActionResult> DeleteSelectedCourse(int id)
        {
            var status = await _selectCourseAppService.DeleteSelectedCourse(id);
            return RedirectToAction("SelectCourseList", "SelectCourse");
        }
    }
}
