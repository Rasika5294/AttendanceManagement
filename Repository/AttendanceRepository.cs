using Attendance_Management_System.Models;
using Attendance_Management_System.Repository;
using System;
using System.Linq;

namespace Attendance_Management_System.Repository
{
   
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly AttendanceManagementContext _context;//Reference of DB context
        public AttendanceRepository(AttendanceManagementContext context)
        {
            this._context = context;
        }

        public int AddEmployeeInTime(Attendance intime)
        {

            _context.Attendances.Add(intime);
            _context.SaveChanges();
            return 1;
        }

        public int AddEmployeeOutTime(int emp_id, string outtime, string todaysDate)
        {
            string OT = outtime;
            string iDate = todaysDate;
            DateTime OutTime = DateTime.Parse(OT);
            DateTime oDate = DateTime.Parse(iDate);
            //Update Outtime from intime from same date
            var todaysAttendence = _context.Attendances.Where(employee => employee.EmpId == emp_id && employee.Dates == oDate).SingleOrDefault();
            todaysAttendence.OutTime = OutTime;
            _context.SaveChanges();
            return 1;

            
        }
    }
}
