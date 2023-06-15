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
    public class DepartmentService:IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
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
