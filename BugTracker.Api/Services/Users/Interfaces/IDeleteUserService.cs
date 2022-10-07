using BugTracker.Api.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Api.Services.Users
{
    public interface IDeleteUserService
    {
        public Task<bool> ExecuteAsync(int id);
    }
}
