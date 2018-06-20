using System.Collections.Generic;
using System.Threading.Tasks;

namespace TESTABP
{
    public interface ICourseAppService
    {
        Task<List<Course>> GetAll();
        List<Course> GetCoursesList();
        Task<Course> GetCourseById(int id);
        Task<Course> EditCourseById(Course input);
        Task<Course> CreateCourse(Course input);
        Task<Course> DeleteCourseById(int id);
    }
}