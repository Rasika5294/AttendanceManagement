using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Attendance_Management_System.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AttendanceManagementContext _context; //reference of DbContext
        public EmployeeRepository(AttendanceManagementContext context) //Dependancy Injection
        {
            this._context = context;
        }
        //This function Returns List of all Employees
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        //This function Returns  Employee By its Id
        public Employee GetEmployeeById(int id)
        {
            var result = _context.Employees.Where(employee => employee.EmpId == id).SingleOrDefault();

            return result;

        }
        


    }
}
