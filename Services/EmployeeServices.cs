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
        public IEnumerable<Employee> GetAllEmployees()
        {
           return _iemployeeRepository.GetAllEmployees();   
        }

        public Employee GetEmployeeById(int id)
        {
            return _iemployeeRepository.GetEmployeeById(id);
        }
    }
}
