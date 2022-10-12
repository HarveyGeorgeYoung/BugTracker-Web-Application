using BugTracker.Api.Models.Users;
using BugTracker.Api.Services.Users.Commands;

namespace BugTracker.Api.Services.Users.Interfaces
{
    public interface ISearchUserService
    {
        public Task<List<UserDto>> ExecuteAsync(UserSearchCommand command);
    }
}
