using CORSANDMediaTR.Models;
using CORSANDMediaTR.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CORSANDMediaTR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository _studentRepository)
        {
            studentRepository = _studentRepository;
        }
        [HttpGet]
        public async Task<List<StudentDetail>> GetStudentListAsync()
        {
            var student= await studentRepository.GetStudentListAsync();
            return student;
        }
        [HttpPost]
        public async Task<StudentDetail> AddStudentAsync(StudentDetail studentDetail)
        {
            var student = await studentRepository.AddStudent(studentDetail);
            return student;
        }
        [HttpGet("GetStudentDetail")]
        public async Task<StudentDetail> GetStudentDetail(int id)
        {
            var student = await studentRepository.GetStudentDetailAsync(id);
            return student;
        }
        [HttpDelete]
        public async Task<int> DeleteStudent(int id)
        {
            var student = await studentRepository.DeleteStudent(id);
            return student;
        }
        [HttpPut]
        public async Task<int> UpdateStudent(StudentDetail studentDetail)
        {
            var student = await studentRepository.UpdateStudent(studentDetail);
            return student;
        }
    }
}