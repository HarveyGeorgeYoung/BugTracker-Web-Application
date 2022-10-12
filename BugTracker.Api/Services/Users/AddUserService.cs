using BugTracker.Api.Application.Data;
using BugTracker.Api.Models.Users;
using BugTracker.Api.Services.Users.Validator;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BugTracker.Api.Services.Users
{
    public class AddUserService : IAddUserService
    {
        private readonly DataContext _context;

        public AddUserService(DataContext context)
        {
            _context = context;
        }   

        public async Task<int> ExecuteAsync(UserDto userDto)
        {
            User user = new User();
            UserValidator validator = new UserValidator();

            user = new User
            {
                Name = userDto.Name,
                Email = userDto.Email,
                DateOfBirth = userDto.DateOfBirth
            };

            validator.ValidateAndThrow(user);

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return user.Id;
        }
    }
}
