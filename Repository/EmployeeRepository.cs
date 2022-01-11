using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            var result = await _context.Employees.Where(employee => employee.EmpId == id).SingleOrDefaultAsync();

            return result;

        }

        public async Task <Employee> CheckIfEmployeeisValid(string email, string password)
        {
            return await _context.Employees.Where(manager => manager.EmpEmail == email && manager.EmpPassword == password).SingleOrDefaultAsync();
        }

       
        //This function Returns  Employee By its Id
       

        public async Task<IEnumerable<PublicHoliday>> GetAllPublicHolydays()
        {
            return await this._context.PublicHolidays.ToListAsync();
        }

        
    }
}
