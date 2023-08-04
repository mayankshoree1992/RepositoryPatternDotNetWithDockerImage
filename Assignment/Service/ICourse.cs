using Assignment.Model;

namespace Assignment.Service
{
    public interface ICourse
    {
        public Task<Course> GetCourseById(int Id);
        public Task<List<Course>> GetCourses(Filter filters);
        public Task<Course> AddCourse(RequestCourse course);
    }
}
