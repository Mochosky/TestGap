using Appointments.Exceptions;
using Appointments.Models;
using Appointments.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Appointments.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<User> LoginAsync(LoginRequest request)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.NormalizedEmail == u.UserName.ToUpper());

            if (await _userManager.CheckPasswordAsync(user, request.Password))
                return user;

            throw new AppointmentException("Invalid Credentials", ErrorCodes.InvalidCredentials);
        }
    }
}
