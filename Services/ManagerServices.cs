using Attendance_Management_System.Models;
using Attendance_Management_System.Repository;
using System.Threading.Tasks;

namespace Attendance_Management_System.Services
{
    public class ManagerServices : IManagerServices
    {
        private readonly IManagerRepository _imanagerRepository;
        public ManagerServices(IManagerRepository imanagerRepository)
        {
            this._imanagerRepository = imanagerRepository;
        }

        
       

        public async Task <Manager> GetManagerById(int id)
        {
            return await _imanagerRepository.GetManagerById(id);
        }

       public async Task<Manager> CheckIfManagerisValid(string email, string password)
        {
            return await _imanagerRepository.CheckIfManagerisValid(email, password);
        }
    }
}
