using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NTierArchitecture.Service.IServices;
using NTierArchitecture.Service.Common.DTOs;

namespace NTierArchitecture.Presentation.WebAPI.Controllers
{
    [ApiController]
    public class UserController : ApiControllerBase<UserController>
    {
        private readonly IUserService _userService;

        public UserController(
            ILogger<UserController> logger,
            IUserService userService
        ) : base(logger)
        {
            _userService = userService;
        }

        [HttpGet(Name = "GetAll")]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogWarning("uyarı GetAll");
            return Ok(await _userService.GetAll());
        }

        [HttpPost(Name = "Add")]
        public async Task<IActionResult> Add(UserDTO userDTO)
        {
            try
            {
                return Ok(await _userService.Add(userDTO));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,"Add user failed");
                return Ok(false);
            }
        }
    }
}
