using Assignment.Model;

namespace Assignment.Data.Repository
{
    public interface ICourseRepo
    {
        public Task<Course> AddCourse(Course course);
        public Task<List<Course>> GetCourses(Filter filters);
        public Task<Course> GetCourseById(int id);
    }
}
