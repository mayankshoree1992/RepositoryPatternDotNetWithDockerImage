using Assignment.Model;

namespace Assignment.Service
{
    public interface ITeacher
    {
        public Task<Teacher> GetTeacherById(int Id);
        public Task<List<Teacher>> GetTeachers(Filter filters);
        public Task<Teacher> AddTeacher(Teacher teacher);
    }
}
