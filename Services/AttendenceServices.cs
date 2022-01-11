using Attendance_Management_System.Models;
using Attendance_Management_System.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Services
{
    public class AttendenceServices : IAttendenceServices
    {
        private readonly IAttendanceRepository _iattendanceRepository;//Reference of AttendanceRepository
        public AttendenceServices(IAttendanceRepository iattendanceRepository)
        {
            this._iattendanceRepository = iattendanceRepository;
        }
        public int AddEmployeeInTime(Attendance intime)
        {
            return _iattendanceRepository.AddEmployeeInTime(intime);
        }

        public int AddEmployeeOutTime(int emp_id, string outtime, string todaysdate)
        {
            return _iattendanceRepository.AddEmployeeOutTime(emp_id, outtime, todaysdate);
        }
    }
}
