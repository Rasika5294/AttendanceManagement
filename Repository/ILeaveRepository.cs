using Attendance_Management_System.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
//using Attendance_Management_System.Models;

namespace Attendance_Management_System.Repository
{
    public interface ILeaveRepository
    {

        Task<Employee> ShowLeavesTakenByEmployee(int emp_id);
        Task<Employee> ShowTotalLeavesOfEmployee(int emp_id);
        Task <int> ShowRemainingLeavesOfEmployee(int emp_id);
        Task <IEnumerable <Leave>> GetEmployeeByLeaveApproved();
        Task<IEnumerable<Leave>> GetEmployeeByPendingLeaveRequest();
        int ApproveLeaveRequest(Leave leave);
        int AddLeaveRequest(Leave leave);    



    }
}
