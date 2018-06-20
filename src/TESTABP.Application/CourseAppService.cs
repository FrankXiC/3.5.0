using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TESTABP {
    public class CourseAppService : TESTABPAppServiceBase, ICourseAppService {

        private readonly IRepository<Course> _courseRepository;

        public CourseAppService(IRepository<Course> courseRepository) {
            _courseRepository = courseRepository;
        }

        public async Task<List<Course>> GetAll() {
            var course = await _courseRepository.GetAll().OrderByDescending(t => t.CreationTime)
                .ToListAsync();
            return course;
        }

        public List<Course> GetCoursesList() {
            var course = _courseRepository.GetAll().OrderByDescending(t => t.CreationTime).ToList();
            return course;
        }

        public async Task<Course> GetCourseById(int id) {
            var course = await _courseRepository.GetAsync(id);
            return course;
        }

        public async Task<Course> EditCourseById(Course input) {
            var course = await _courseRepository.UpdateAsync(input);
            return course;
        }

        public async Task<Course> CreateCourse(Course input) {
            var course = ObjectMapper.Map<Course>(input);
            await _courseRepository.InsertAsync(course);
            return course;
        }

        public async Task<Course> DeleteCourseById(int id) {

            var Course = await _courseRepository.GetAsync(id);
            if (Course != null) {
                await _courseRepository.DeleteAsync(id);
            }

            return Course;
        }
    }
}
