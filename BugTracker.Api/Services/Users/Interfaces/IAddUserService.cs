using BugTracker.Api.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Api.Services.Users
{
    public interface IAddUserService
    {
        public Task<int> ExecuteAsync(UserDto user);
    }
}
