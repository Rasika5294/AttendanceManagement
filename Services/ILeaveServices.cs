//using Attendance_Management__System.Models;
using Attendance_Management_System.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Attendance_Management_System.Services
{
    public interface ILeaveServices
    {

       Task <Employee> ShowLeavesTakenByEmployee(int emp_id);
       Task <Employee> ShowTotalLeavesOfEmployee(int emp_id);
        Task<int> ShowRemainingLeavesOfEmployee(int emp_id);

        Task<IEnumerable<Leave>> GetEmployeeByLeaveApproved();
        Task<IEnumerable<Leave>> GetEmployeeByPendingLeaveRequest();
    }
}
