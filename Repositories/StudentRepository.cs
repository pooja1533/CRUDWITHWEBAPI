using CORSANDMediaTR.Data;
using CORSANDMediaTR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace CORSANDMediaTR.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DbcontextClass _dbcontextClass;
        public StudentRepository(DbcontextClass dbcontextClass)
        {
            _dbcontextClass = dbcontextClass;
        }

        public async Task<StudentDetail> AddStudent(StudentDetail student)
        {
            try
            {
                var result = _dbcontextClass.students.Add(student);
                await _dbcontextClass.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<int> DeleteStudent(int id)
        {
            try
            {
                var data=_dbcontextClass.students.Where(x=>x.Id== id).FirstOrDefault();
               
                     _dbcontextClass.students.Remove(data);
                    return await _dbcontextClass.SaveChangesAsync();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<StudentDetail> GetStudentDetailAsync(int id)
        {
            return await _dbcontextClass.students.Where(x=>x.Id== id).FirstOrDefaultAsync();
        }

        public async Task<List<StudentDetail>> GetStudentListAsync()
        {
            var studentList = _dbcontextClass.students.ToListAsync();
            return await studentList;
        }

        public async Task<int> UpdateStudent(StudentDetail student)
        {
            _dbcontextClass.students.Update(student);
            return await _dbcontextClass.SaveChangesAsync();
        }
    }
}
