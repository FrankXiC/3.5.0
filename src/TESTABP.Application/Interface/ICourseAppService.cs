using System.Collections.Generic;
using System.Threading.Tasks;

namespace TESTABP
{
    public interface ICourseAppService
    {
        Task<List<Course>> GetAll();
        Task<List<Course>> GetCoursesList();
        Task<Course> GetCourseById(int id);
        Task<Course> EditCourseById(CourseCreateInput input);
        Task<Course> CreateCourse(CourseCreateInput input);
        Task<Course> DeleteCourseById(int id);
    }
}