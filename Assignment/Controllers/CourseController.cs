using Assignment.Model;
using Assignment.Service;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourse _course;

        public CourseController(ICourse course)
        {
            _course = course;
        }

        [HttpGet]
        public async Task<List<Course>> GetCourses([FromQuery]Filter filters)
        {
            var data = await _course.GetCourses(filters);
            return data;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Course> GetCourseById(int id) 
        {
            var data = await _course.GetCourseById(id);
            return data ;
        }

        [HttpPost]
        public async Task<Course> AddTeacher(RequestCourse course)
        {
            var data = await _course.AddCourse(course);
            return data;
        }
    }
}
