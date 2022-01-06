using Attendance_Management_System.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [Route("GetEmployees")]//This is rout for GetEmployees Method
        //This is a call to GetAllEmployees Method
        public IActionResult GetEmployees()
        {
            return new ObjectResult(_iemployeeServices.GetAllEmployees());
        }


        [HttpGet]
        [Route("GetEmployeeById/{id}")]//This is rout for GetEmployeeByID Method
        public IActionResult GetEmployeeById(int id)
        {
            return new ObjectResult(_iemployeeServices.GetEmployeeById(id));
        }

    }

}
