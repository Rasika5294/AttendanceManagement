using Attendance_Management_System.Models;

namespace Attendance_Management_System.Services
{
    public interface IAttendenceServices
    {
        int AddEmployeeInTime(Attendance intime);
        int AddEmployeeOutTime(int emp_id, string outtime, string todaysdate);
    }
}
