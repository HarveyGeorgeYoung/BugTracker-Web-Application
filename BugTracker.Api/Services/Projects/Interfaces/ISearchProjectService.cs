using BugTracker.Api.Models.Projects;
using BugTracker.Api.Services.Projects.Commands;

namespace BugTracker.Api.Services.Projects.Interfaces
{
    public interface ISearchProjectService
    {
        public Task<List<ProjectDto>> ExecuteAsync(ProjectSearchCommand command);
    }
}
