using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Attendance_Management_System.Repository
{
    public interface IEmployeeRepository
    {

       Task <IEnumerable<Employee>> GetAllEmployees();
        
       Task <Employee> GetEmployeeById(int id);
       Task <Employee> CheckIfEmployeeisValid(string email, string password);
       Task<IEnumerable<PublicHoliday>> GetAllPublicHolydays();


    }
}
