using CollegeManagement.BusinessLayer.ViewModels;
using CollegeManagement.DataLayer;
using CollegeManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.BusinessLayer.Services.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly CollegeDbContext _collegeDbContext;
        public StudentRepository(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
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
