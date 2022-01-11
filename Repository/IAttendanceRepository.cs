using Attendance_Management_System.Models;

namespace Attendance_Management_System.Repository
{
    public interface IAttendanceRepository
    {
        int AddEmployeeInTime(Attendance intime);
        int AddEmployeeOutTime(int emp_id, string outtime, string todaysdate);
    }
}
