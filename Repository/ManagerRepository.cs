using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Attendance_Management_System.Repository
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly AttendanceManagementContext _context;
        public ManagerRepository(AttendanceManagementContext context)
        {
            this._context = context;
        }

        public async Task<Manager> CheckIfManagerisValid(string email, string password)
        {
            return await _context.Managers.Where(manager => manager.ManagerEmail == email && manager.ManagerPassword == password).SingleOrDefaultAsync();
        }

        public async Task <Manager> GetManagerById(int id)
        {
            var result = await _context.Managers.Where(manager => manager.ManagerId == id).SingleOrDefaultAsync();

            return result;
        }
    }
}
