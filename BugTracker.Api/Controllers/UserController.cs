using BugTracker.Api.Models.Users;
using BugTracker.Api.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IAddUserService _addUserService;
        private readonly IDeleteUserService _deleteUserService;

        public UserController(
            IAddUserService addUserService, 
            IDeleteUserService deleteUserService)
        {
            _addUserService = addUserService;
            _deleteUserService = deleteUserService;
        }

        [HttpPost]
        public async Task<int> Add([FromBody] UserDto userDto)
        {
            return await _addUserService.ExecuteAsync(userDto);
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _deleteUserService.ExecuteAsync(id);
        }
    }
}
