using CollegeManagement.BusinessLayer.Interfaces;
using CollegeManagement.BusinessLayer.ViewModels;
using CollegeManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CollegeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService= departmentService;
        }
      
       
        [HttpPost]
        [Route("Create-Department")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateDepartment([FromBody] DepartmentViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        
        [HttpPut]
        [Route("Update-Department")]
        public async Task<IActionResult> UpdateDepartment([FromBody] DepartmentViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("Delete-Department")]
        public async Task<IActionResult> DeleteDepartment(long departmentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        
        [HttpGet]
        [Route("Get-Department-By-Id")]
        public async Task<IActionResult> GetDepartmentById(long departmentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("Search-Department-By-Name")]
        public async Task<IActionResult> SearchDepartmentByName(long departmentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("Get-All-Departments")]
        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
       
    }
}
