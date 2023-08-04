using Assignment.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.Repository
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly EF_DbContext _DbContext;
        public TeacherRepo(EF_DbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public async Task<Teacher> AddTeacher(Teacher teacher)
        {
           await _DbContext.Teachers.AddAsync(teacher);
            _DbContext.SaveChanges();
            return teacher;
        }

        public async Task<Teacher> GetTeacherById(int id)
        {
            var data = await _DbContext.Teachers.FirstOrDefaultAsync(x => x.Teacher_Id == id);
            return data;
        }

        public async Task<List<Teacher>> GetTeachers(Filter filters)
        {
            var data = await _DbContext.Teachers.ToListAsync();
            if (!string.IsNullOrEmpty(filters.Name))
            {
                data = data.Where(x => x.Name.Contains(filters.Name)).ToList();
            }
            if (filters.IsActive != null)
            {
                data = data.Where(x => x.Is_Active.Equals(filters.IsActive)).ToList();
            }
            return data;
        }
    }
}
