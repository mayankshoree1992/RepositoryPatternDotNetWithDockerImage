using Assignment.Model;

namespace Assignment.Data.Repository
{
    public interface ITeacherRepo
    {
        public Task<Teacher> AddTeacher(Teacher teacher);
        public Task<List<Teacher>> GetTeachers(Filter filters);
        public Task<Teacher> GetTeacherById(int id);
    }
}
