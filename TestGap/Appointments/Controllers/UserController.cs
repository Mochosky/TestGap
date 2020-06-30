using Appointments.Exceptions;
using Appointments.Models;
using Appointments.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Appointments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) => _userService = userService ??
            throw new ArgumentException(nameof(userService));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.LoginAsync(loginRequest);
                return Ok(user);
            }
            else
            {
                return BadRequest(new ErrorResponses
                {
                    ErrorCode = ErrorCodes.InvalidCredentials,
                    ErrorMessage = "Invalid Credentials."
                });
            }
        }
    }
}