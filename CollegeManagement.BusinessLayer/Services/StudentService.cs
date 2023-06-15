using CollegeManagement.BusinessLayer.Interfaces;
using CollegeManagement.BusinessLayer.Services.Repository;
using CollegeManagement.BusinessLayer.ViewModels;
using CollegeManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.BusinessLayer.Services
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> CreateStudent(Student student)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteStudentById(long studentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Student> GetStudentById(long studentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Student> SearchStudentByName(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Student> UpdateStudent(StudentViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
