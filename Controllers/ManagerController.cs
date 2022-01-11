using Attendance_Management_System.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Attendance_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManagerServices _imanagerServices;
        public ManagerController(IManagerServices imanagerServices)
        {
            this._imanagerServices = imanagerServices;
        }
        [HttpGet]
        [Route("CheckIfManagerIsValid/{email}/{password}")]
        public async Task<IActionResult> CheckIfManagerIsValid(string email, string password)
        {
            try
            {
                return new ObjectResult(await _imanagerServices.CheckIfManagerisValid(email, password));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        } 
        

    [HttpGet]
        [Route("GetManagerById/{id}")]//This is rout for GetManagerByID Method
        public async Task<IActionResult> GetManagerById(int id)
        {
            try
            {
                return new ObjectResult(await _imanagerServices.GetManagerById(id));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
                return null;
            }
        }
       
}
}
