using BugTracker.Api.Application.Data;
using BugTracker.Api.Models.Users;
using BugTracker.Api.Services.Users.Commands;
using BugTracker.Api.Services.Users.Extensions;
using BugTracker.Api.Services.Users.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Api.Services.Users
{
    public class SearchUserService : ISearchUserService
    {
        private readonly DataContext _context;

        public SearchUserService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<UserDto>> ExecuteAsync(UserSearchCommand command)
        {
            return await _context.Users
                .WithEmailContaining(command.Email!)
                .WithNameContaining(command.Name!)
                .Select(x => x.ToUserDto())
                .ToListAsync();
        }
    }
}
