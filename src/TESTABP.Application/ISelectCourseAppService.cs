using System.Collections.Generic;
using System.Threading.Tasks;

namespace TESTABP
{
    public interface ISelectCourseAppService
    {
        Task<List<SelectCourseInput>>GetSelectedCourseByPersonId(string personId);
        Task<SelectCourse> CreateSelectCourse(SelectCourseInput selectCourse);
        Task<string> DeleteSelectedCourse(int id);
    }
}