using Attendance_Management_System.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Attendance_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveController : ControllerBase
    {
        private readonly ILeaveServices _ileaveServices;
        public LeaveController(ILeaveServices ileaveServices)
        {
                this._ileaveServices = ileaveServices;
        }
      
        [HttpGet]
        [Route("ShowLeavesTakenByEmployee/{emp_id}")]//This is rout for ShowLeavesTakenByEmployee Method
        public async Task <IActionResult> ShowLeavesTakenByEmployee(int emp_id)
        {
            try
            {
                return new ObjectResult(await _ileaveServices.ShowLeavesTakenByEmployee(emp_id));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpGet]
        [Route("ShowTotalLeavesOfEmployee/{emp_id}")]//This is rout for ShowLeavesTakenByEmployee  Method
        public async Task <IActionResult> ShowTotalLeavesOfEmployee(int emp_id)
        {
            try
            {
                return new ObjectResult(await _ileaveServices.ShowTotalLeavesOfEmployee(emp_id));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

       
        [HttpGet]
        [Route("GetEmployeeByLeaveApproved")] //This is route for GetEmployeeByLeaveApproved method.
        public async Task<IActionResult> GetEmployeeByLeaveApproved()
        {
            try
            {
                return new ObjectResult(await _ileaveServices.GetEmployeeByLeaveApproved());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpGet]
        [Route("GetEmployeeByPendingLeaveRequest")] //This is route for GetEmployeeByPendingLeaveRequest method.
        public async Task<IActionResult> GetEmployeeByPendingLeaveRequest()
        {
            try
            {
                return new ObjectResult(await _ileaveServices.GetEmployeeByPendingLeaveRequest());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
                return null ;
            }
        }
        [HttpGet]
        [Route("ShowRemainingLeavesOfEmployee")] //This is route for ShowRemainingLeavesOfEmployee method.
        public async Task <IActionResult> ShowRemainingLeavesOfEmployee(int emp_id)
        {
            try
            {
                return new ObjectResult(await _ileaveServices.ShowRemainingLeavesOfEmployee(emp_id));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
                return null;
            }
        }


    }
}
