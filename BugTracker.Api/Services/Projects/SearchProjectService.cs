using BugTracker.Api.Application.Data;
using BugTracker.Api.Models.Projects;
using BugTracker.Api.Services.Projects.Commands;
using BugTracker.Api.Services.Projects.Extensions;
using BugTracker.Api.Services.Projects.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Api.Services.Users
{
    public class SearchProjectService : ISearchProjectService
    {
        private readonly DataContext _context;

        public SearchProjectService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<ProjectDto>> ExecuteAsync(ProjectSearchCommand command)
        {
            return await _context.Projects
                .WithEmailContaining(command.Email!)
                .WithNameContaining(command.Name!)
                .Select(x => x.ToProjectDto())
                .ToListAsync();
        }
    }
}
