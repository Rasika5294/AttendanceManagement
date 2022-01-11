using Attendance_Management_System.Models;
using Attendance_Management_System.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Attendance_Management_System.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository _iemployeeRepository;
        public EmployeeServices(IEmployeeRepository iemployeeRepository)
        {
            this._iemployeeRepository = iemployeeRepository;
        }
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _iemployeeRepository.GetAllEmployees();
        }
        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _iemployeeRepository.GetEmployeeById(id);
        }

        public async Task<Employee> CheckIfEmployeeisValid(string email, string password)
        {
            return await _iemployeeRepository.CheckIfEmployeeisValid(email, password);
        }

        public async Task<IEnumerable<PublicHoliday>> GetAllPublicHolydays()
        {
            return await _iemployeeRepository.GetAllPublicHolydays();
        }

       

       
    }
}
