using BugTracker.Api.Application.Common.Exceptions;
using BugTracker.Api.Application.Data;
using BugTracker.Api.Models.Users;
using FluentValidation;

namespace BugTracker.Api.Services.Users
{
    public class DeleteUserService : IDeleteUserService
    {
        private readonly DataContext _context;

        public DeleteUserService(DataContext context)
        {
            _context = context;
        }   

        public async Task<bool> ExecuteAsync(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                throw new NotFoundException(nameof(User));
            }

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
