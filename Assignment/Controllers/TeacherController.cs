using Assignment.Model;
using Assignment.Service;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public TeacherController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet]
        public async Task<List<Teacher>> GetTeachers([FromQuery] Filter filters)
        {
            var data = await _teacher.GetTeachers(filters);
            return data;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Teacher> GetTeacherById(int id)
        {
            var data = await _teacher.GetTeacherById(id);
            return data;
        }

        [HttpPost]
        public async Task<Teacher> AddTeacher(Teacher teacher)
        {
            var data = await _teacher.AddTeacher(teacher);
            return data;
        }
    }
}