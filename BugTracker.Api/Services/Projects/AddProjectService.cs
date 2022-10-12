using BugTracker.Api.Application.Common.Exceptions;
using BugTracker.Api.Application.Data;
using BugTracker.Api.Models.Projects;
using BugTracker.Api.Models.Users;
using BugTracker.Api.Services.Projects.Validator;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BugTracker.Api.Services.Projects
{
    public class AddProjectService : IAddProjectService
    {
        private readonly DataContext _context;

        public AddProjectService(DataContext context)
        {
            _context = context;
        }   

        public async Task<int> ExecuteAsync(ProjectDto userDto)
        {
            Project project = new Project();
            ProjectValidator validator = new ProjectValidator();

            var user = _context.Users.Find(userDto.OwnerId);

            if (user == null)
            {
                throw new NotFoundException(nameof(User));
            }

            project = new Project
            {
                Name = userDto.Name,
                Description = userDto.Description,
                OwnerId = userDto.OwnerId
            };

            validator.ValidateAndThrow(project);

            _context.Projects.Add(project);

            await _context.SaveChangesAsync();

            return project.Id;
        }
    }
}
