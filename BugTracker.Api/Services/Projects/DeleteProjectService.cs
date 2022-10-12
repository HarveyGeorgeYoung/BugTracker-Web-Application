using BugTracker.Api.Application.Common.Exceptions;
using BugTracker.Api.Application.Data;
using BugTracker.Api.Models.Projects;
using FluentValidation;

namespace BugTracker.Api.Services.Projects
{
    public class DeleteProjectService : IDeleteProjectService
    {
        private readonly DataContext _context;

        public DeleteProjectService(DataContext context)
        {
            _context = context;
        }   

        public async Task<bool> ExecuteAsync(int id)
        {
            var project = _context.Projects.Find(id);

            if (project == null)
            {
                throw new NotFoundException(nameof(Project));
            }

            _context.Projects.Remove(project);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
