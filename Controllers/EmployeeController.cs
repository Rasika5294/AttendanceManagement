
using Attendance_Management_System.Models;
using Attendance_Management_System.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Attendance_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _iemployeeServices;

        public EmployeeController(IEmployeeServices iemployeeServices)
        {
            this._iemployeeServices = iemployeeServices;
        }

        [HttpGet]
        [Route("GetAllEmployees")]//This is rout for GetAllEmployees Method
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                return new ObjectResult(await _iemployeeServices.GetAllEmployees());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpGet]
        [Route("GetEmployeeById/{id}")]//This is rout for GetEmployeeByID Method
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            try
            {
                return new ObjectResult(await _iemployeeServices.GetEmployeeById(id));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpGet]
        [Route("CheckIfEmployeeisValid/{email}/{password}")]
        public async Task<IActionResult>CheckIfEmployeeisValid(string email, string password)
        {
            try
            {
                return new ObjectResult(await _iemployeeServices.CheckIfEmployeeisValid(email, password));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
        
        [HttpGet]
        [Route("GetAllPublicHolydays")]//This is rout for GetAllPublicHolydays Method
        //This is a call to GetAllEmployees Method
        public async Task<IActionResult> GetAllPublicHolydays()
        {
            try
            {
                return new ObjectResult(await _iemployeeServices.GetAllPublicHolydays());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }










    }

}
