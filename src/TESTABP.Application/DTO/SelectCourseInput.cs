using System;

namespace TESTABP
{
    public class SelectCourseInput
    {
        public int Id { get; set; }
        public string PersonUserId { get; set; }
        public string PersonName { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public int Score { get; set; }
    }
}