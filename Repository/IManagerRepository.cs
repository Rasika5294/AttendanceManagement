using Attendance_Management_System.Models;
using System.Threading.Tasks;

namespace Attendance_Management_System.Repository
{
    public interface IManagerRepository
    {
        Task <Manager> CheckIfManagerisValid(string email, string password);
        
        Task <Manager> GetManagerById(int id);
    }
}
