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
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return View("../Home/Login");
            }
            else
            {
                var output = await _courseAppService.GetAll();
                return View("CourseList", output);
            }
        }
        public async Task<IActionResult> Register(CourseCreateInput inputCourse) {
            var coursenew = await _courseAppService.CreateCourse(inputCourse);
            var output = await _courseAppService.GetCoursesList();
            output.Add(coursenew);
            output.OrderByDescending(t => t.CreationTime);
            return View("CourseList", output);
        }

        public async Task<IActionResult> GetCourseById(int Id) {
            var output = await _courseAppService.GetCourseById(Id);

            return View("CourseEdit", output);
        }

        public async Task<IActionResult> CourseRegister() {
            return View("CourseCreate");
        }

        public async Task<IActionResult> EditCourseById(CourseCreateInput inputCourse) {
            var course = await _courseAppService.EditCourseById(inputCourse);
            return View("CourseEdit", course);
        }

        public async Task<IActionResult> DeleteCourseById(int id) {
            var courseDelete = await _courseAppService.DeleteCourseById(id);
            var output = await _courseAppService.GetCoursesList();
            output.Remove(courseDelete);
            return View("CourseList", output);
        }
    }
}