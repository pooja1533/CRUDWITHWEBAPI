using CORSANDMediaTR.Models;

namespace CORSANDMediaTR.Repositories
{
    public interface IStudentRepository
    {
        public  Task <List<StudentDetail>> GetStudentListAsync();
        public Task<StudentDetail> GetStudentDetailAsync(int id);
        public Task<StudentDetail> AddStudent(StudentDetail student);
        public Task<int> UpdateStudent(StudentDetail student);
        public Task<int> DeleteStudent(int id);
    }
}
