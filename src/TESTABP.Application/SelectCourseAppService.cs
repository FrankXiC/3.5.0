using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TESTABP {
    public class SelectCourseAppService : TESTABPAppServiceBase, ISelectCourseAppService {

        private readonly IRepository<SelectCourse> _SCRepository;
        private readonly IRepository<Person> _personRepository;
        private readonly IRepository<Course> _courseRepository;
        public SelectCourseAppService(IRepository<SelectCourse> SCRepository, IRepository<Person> personRepository, IRepository<Course> courseRepository) {
            _SCRepository = SCRepository;
            _personRepository = personRepository;
            _courseRepository = courseRepository;
        }

        public async Task<List<SelectCourseInput>> GetSelectedCourseByPersonId(string personId) {
            var person = await _personRepository.GetAll().Where(t => t.UserId == personId).ToListAsync();
            var course = await _courseRepository.GetAll().ToListAsync();
            var sCourse = await _SCRepository.GetAll().Where(t => t.PersonId == personId).OrderByDescending(t => t.CreationTime).ToListAsync();
            var personSelectedCourse = from sc in sCourse
                                       join p in person on sc.PersonId equals p.UserId
                                       join c in course on sc.CourseId equals c.CourseId
                                       select new { sc.Id, sc.PersonId, PersonName = p.Name, sc.CourseId, CourseName = c.Name, c.Score, c.Teacher };

            return personSelectedCourse.Select(item => new SelectCourseInput {
                Id = item.Id,
                PersonName = item.PersonName,
                PersonUserId = item.PersonId,
                CourseId = item.CourseId,
                CourseName = item.CourseName,
                Score = item.Score,
                Teacher = item.Teacher
            })
                .ToList();
        }

        public async Task<SelectCourse> CreateSelectCourse(SelectCourseInput input) {
            var sCourse = new SelectCourse() { PersonId = input.PersonUserId, CourseId = input.CourseId };
            var scNew = await _SCRepository.InsertAsync(sCourse);
            return scNew;
        }

        public async Task<string> DeleteSelectedCourse(int id) {
            var status = string.Empty;
            await _SCRepository.DeleteAsync(id);
            return status;
        }

    }
}
