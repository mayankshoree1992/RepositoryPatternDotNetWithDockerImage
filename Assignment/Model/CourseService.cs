using Assignment.Data.Repository;
using Assignment.Service;

namespace Assignment.Model
{
    public class CourseService : ICourse
    {
        private readonly ICourseRepo _courseRepo;
        private readonly ITeacher _teacherRepo;

        public CourseService(ICourseRepo courseRepo, ITeacher teacherRepo)
        {
            _courseRepo = courseRepo;
            _teacherRepo = teacherRepo;
        }
        public async Task<Course> AddCourse(RequestCourse course)
        {
            var teacherData =  await _teacherRepo.GetTeacherById(course.Course_Mentor);

            if(teacherData == null)
            {
                return null;
            }
            Course courseCourse = new Course() { 
            Course_Id = course.Course_Id,
            Description = course.Description,
            End_Date = course.End_Date,
            Is_Active = course.Is_Active,
            Name = course.Name,
            Start_Date = course.Start_Date,
            Course_Mentor = teacherData
            };
            
            var result = await _courseRepo.AddCourse(courseCourse);
            return result;
        }

        public Task<Course> GetCourseById(int id)
        {
            var result = _courseRepo.GetCourseById(id);
            return result;
        }

        public Task<List<Course>> GetCourses(Filter filters)
        {
            var result = _courseRepo.GetCourses(filters);
            return result;
        }
    }
}
