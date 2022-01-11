using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Attendance_Management_System.Repository
{
    public class LeaveRepository : ILeaveRepository
    {
       
        private readonly AttendanceManagementContext _context;//Reference of DB context
        
        public LeaveRepository(AttendanceManagementContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Leave>> GetEmployeeByLeaveApproved()
        {
           
            return await this._context.Leaves.Where(leave => leave.Status == "Approved").ToListAsync();

        }

        public async Task<IEnumerable<Leave>> GetEmployeeByPendingLeaveRequest()
        {

            return await this._context.Leaves.Where(leave => leave.Status == "Pending").ToListAsync();
        }

        public async Task <Employee> ShowLeavesTakenByEmployee(int emp_id)
        {
            var result1 = await _context.Employees.Where(employee => employee.EmpId == emp_id).SingleOrDefaultAsync();

            return result1;
        }

        public async Task <int> ShowRemainingLeavesOfEmployee(int emp_id)
        {
            var employee = await _context.Employees.Where(employee => employee.EmpId == emp_id).SingleOrDefaultAsync();
            int total_leaves= (int)employee.TotalLeaves;  
           int leaves_taken= (int)employee.LeavesTaken;
            int remaining_leaves = total_leaves - leaves_taken;
            return remaining_leaves;
        }

        public async Task<Employee> ShowTotalLeavesOfEmployee(int emp_id)
        {
            var result2 = await _context.Employees.Where(employee => employee.EmpId == emp_id).SingleOrDefaultAsync();

            return result2;
        }

        
    }
}
