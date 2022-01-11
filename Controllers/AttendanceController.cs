using Attendance_Management_System.Models;
using Attendance_Management_System.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Attendance_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendenceServices _iattendanceServices; //References of IAttendenceServices
        public AttendanceController(IAttendenceServices iattendanceServices)
        {
            this._iattendanceServices=iattendanceServices;
        }
        [HttpPost]
        [Route("AddEmployeeInTime")]
        public IActionResult AddEmployeeInTime(Attendance intime)
        {
            try
            {
                return new ObjectResult(_iattendanceServices.AddEmployeeInTime(intime));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;

            }
        }
        [HttpPost]
        [Route("AddEmployeeOutTime")]
        public IActionResult AddEmployeeOutTime(int emp_id, string outtime, string todaysdate)//update outtime
        {
            try
            {
                return new ObjectResult(_iattendanceServices.AddEmployeeOutTime(emp_id, outtime, todaysdate));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
