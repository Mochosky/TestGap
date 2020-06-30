using Appointments.Models;
using System.Threading.Tasks;

namespace Appointments.Services.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<User> LoginAsync(LoginRequest request);
    }
}
