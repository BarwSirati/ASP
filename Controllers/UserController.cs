using Backend.Services.UserService;
using Microsoft.AspNetCore.Http;
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
        public async Task<ActionResult<List<Users>>> GetUsers()
        {
            return Ok(_userService.GetUsers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUser(int id)
        {
            var result = _userService.GetUser(id);
            if (result is null)
                return NotFound("User not found");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Users>> AddUser([FromBody]Users user)
        {
            var result = _userService.AddUser(user);
            return Ok(result);
        }
    }
}
