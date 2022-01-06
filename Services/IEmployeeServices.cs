using Attendance_Management_System.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Attendance_Management_System.Services
{
    public interface IEmployeeServices
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
    }
}
