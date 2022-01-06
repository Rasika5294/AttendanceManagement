using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Attendance_Management_System.Repository
{
    public interface IEmployeeRepository
    {

        IEnumerable<Employee> GetAllEmployees();
        
        Employee GetEmployeeById(int id);
    }
}
