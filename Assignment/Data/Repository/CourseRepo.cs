using Assignment.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.Repository
{
    public class CourseRepo : ICourseRepo
    {
        private readonly EF_DbContext _DbContext;
        public CourseRepo(EF_DbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public async Task<Course> AddCourse(Course course)
        {
            await _DbContext.Courses.AddAsync(course);
            _DbContext.SaveChanges();
            return course;
        }

        public async Task<Course> GetCourseById(int id)
        {
            var data = await _DbContext.Courses.Include(x => x.Course_Mentor).Where(x => x.Course_Id == id).FirstOrDefaultAsync();  
            return data;
        }

        public async Task<List<Course>> GetCourses(Filter filters)
        {

            var data = await _DbContext.Courses.Include(x => x.Course_Mentor).ToListAsync();
            if (!string.IsNullOrEmpty(filters.Name))
            {
                data = data.Where(x => x.Name.ToLower().Contains(filters.Name.ToLower())).ToList();
            }
            if (filters.IsActive != null)
            {
                data = data.Where(x => x.Is_Active.Equals(filters.IsActive)).ToList();
            }
            return data;
        }
    }
}
