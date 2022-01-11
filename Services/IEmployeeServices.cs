using Attendance_Management_System.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Attendance_Management_System.Services
{
    public interface IEmployeeServices
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
         
        Task<IEnumerable<PublicHoliday>> GetAllPublicHolydays();
        Task <Employee> CheckIfEmployeeisValid(string email, string password);
    }
}
