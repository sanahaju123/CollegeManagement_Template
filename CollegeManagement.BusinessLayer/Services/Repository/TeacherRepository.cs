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
    public class TeacherRepository:ITeacherRepository
    {
        private readonly CollegeDbContext _collegeDbContext;
        public TeacherRepository(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }

        public async Task<Teacher> CreateTeacher(Teacher teacher)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteTeacherById(long teacherId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachers()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Teacher> GetTeacherById(long teacherId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Teacher> SearchTeacherByName(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Teacher> UpdateTeacher(TeacherViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
