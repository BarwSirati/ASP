using Backend.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<ActionResult<List<GetUserDto>>> GetUsers()
        {
            return Ok(await _userService.GetUsers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetUserDto>> GetUser(int id)
        {
            var result = _userService.GetUser(id);
            if (result is null)
                return NotFound("User not found");
            return Ok(await result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> AddUser([FromBody]AddUserDto user)
        {
            var result = _userService.AddUser(user);
            return Ok(await result);
        }
    }
}
