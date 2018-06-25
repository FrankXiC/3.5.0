using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TESTABP.Web.Controllers
{
    public class CoursesController : TESTABPControllerBase {
        private readonly ICourseAppService _courseAppService;

        public CoursesController(ICourseAppService courseAppService) {
            _courseAppService = courseAppService;
        }

        public async Task<IActionResult> CourseList()
        {
            return !HttpContext.User.Identity.IsAuthenticated ? View("../Home/Login") : View();
        }
        public async Task<IActionResult> Register(Course Input) {
            var coursenew = await _courseAppService.CreateCourse(Input);
            var output = _courseAppService.GetCoursesList();
            output.Add(coursenew);
            output.OrderByDescending(t => t.CreationTime);
            return View("CourseList", output);
        }

        public async Task<IActionResult> GetPersonById(int Id) {
            var output = await _courseAppService.GetCourseById(Id);

            return View("CourseEdit", output);
        }

        public async Task<IActionResult> CourseRegister() {
            return View("CourseCreate");
        }

        public async Task<IActionResult> EditPersonById(Course inputPerson) {
            var course = await _courseAppService.EditCourseById(inputPerson);
            return View("CourseEdit", course);
        }

        public async Task<IActionResult> DeletePersonById(int id) {
            var courseDelete = await _courseAppService.DeleteCourseById(id);
            var output = _courseAppService.GetCoursesList();
            output.Remove(courseDelete);
            return View("CourseList", output);
        }
    }
}