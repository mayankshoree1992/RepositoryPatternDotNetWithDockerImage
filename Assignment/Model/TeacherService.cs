using Assignment.Data.Repository;
using Assignment.Service;

namespace Assignment.Model
{
    public class TeacherService : ITeacher
    {

        private readonly ITeacherRepo _teacherRepo;

        public TeacherService(ITeacherRepo teacherRepo)
        {
            _teacherRepo = teacherRepo; 
        }

        public Task<Teacher> AddTeacher(Teacher teacher)
        {
            var result = _teacherRepo.AddTeacher(teacher);
            return result;
        }

        public Task<Teacher> GetTeacherById(int id)
        {
            var result = _teacherRepo.GetTeacherById(id);
            return result;
        }

        public Task<List<Teacher>> GetTeachers(Filter filters)
        {
            var result = _teacherRepo.GetTeachers(filters);
            return result;
        }
    }
}
