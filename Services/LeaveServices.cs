using Attendance_Management_System.Models;
using Attendance_Management_System.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Attendance_Management_System.Services
{
    public class LeaveServices : ILeaveServices
    {
        private readonly ILeaveRepository _leaveRepository;
        public LeaveServices(ILeaveRepository leaveRepository)
        {
            this._leaveRepository = leaveRepository;
        }

        public int AddLeaveRequest(Leave leave)
        {
            return _leaveRepository.AddLeaveRequest(leave);
        }

        public int ApproveLeaveRequest(Leave leave)
        {
            return _leaveRepository.ApproveLeaveRequest(leave);
        }

        public async Task<IEnumerable<Leave>> GetEmployeeByLeaveApproved()
        {
            return await _leaveRepository.GetEmployeeByLeaveApproved();
        }

        public async Task<IEnumerable<Leave>> GetEmployeeByPendingLeaveRequest()
        {
            return await _leaveRepository.GetEmployeeByPendingLeaveRequest();
        }

        public async Task <Employee> ShowLeavesTakenByEmployee(int emp_id)
        {
            return await _leaveRepository.ShowLeavesTakenByEmployee(emp_id);
        }

        public async Task <int> ShowRemainingLeavesOfEmployee(int emp_id)
        {
            return await _leaveRepository.ShowRemainingLeavesOfEmployee(emp_id);
        }

        public async Task <Employee> ShowTotalLeavesOfEmployee(int emp_id)
        {
            return await _leaveRepository.ShowTotalLeavesOfEmployee(emp_id);
        }
    }
}
