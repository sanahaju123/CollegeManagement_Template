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
    public class DepartmentRepository:IDepartmentRepository
    {
        private readonly CollegeDbContext _collegeDbContext;
        public DepartmentRepository(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }

        public async Task<Department> CreateDepartment(Department department)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteDepartmentById(long departmentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();

        }

        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Department> GetDepartmentById(long departmentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Department> SearchDepartmentByName(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Department> UpdateDepartment(DepartmentViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
