using BugTracker.Api.Models.Users;
using BugTracker.Api.Services.Users;
using BugTracker.Api.Services.Users.Commands;
using BugTracker.Api.Services.Users.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IAddUserService _addUserService;
        private readonly IDeleteUserService _deleteUserService;
        private readonly ISearchUserService _searchUserService;

        public UserController(
            IAddUserService addUserService,
            ISearchUserService searchUserService,
            IDeleteUserService deleteUserService)
        {
            _addUserService = addUserService;
            _searchUserService = searchUserService;
            _deleteUserService = deleteUserService;
        }

        [HttpPost]
        public async Task<int> Add([FromBody] UserDto userDto)
        {
            return await _addUserService.ExecuteAsync(userDto);
        }

        [HttpGet]
        public async Task<List<UserDto>> Search([FromQuery] UserSearchCommand command)
        {
            return await _searchUserService.ExecuteAsync(command);
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _deleteUserService.ExecuteAsync(id);
        }
    }
}
