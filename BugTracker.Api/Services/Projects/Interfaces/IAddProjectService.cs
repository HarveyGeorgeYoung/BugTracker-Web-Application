using BugTracker.Api.Models.Projects;

namespace BugTracker.Api.Services.Projects
{
    public interface IAddProjectService
    {
        public Task<int> ExecuteAsync(ProjectDto project);
    }
}
