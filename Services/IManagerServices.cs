using Attendance_Management_System.Models;
using System.Threading.Tasks;

namespace Attendance_Management_System.Services
{
    public interface IManagerServices
    {
        Task<Manager> CheckIfManagerisValid(string email, string password);
        Task <Manager> GetManagerById(int id);

    }
}
