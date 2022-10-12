using BugTracker.Api.Models.Projects;
using BugTracker.Api.Services.Projects;
using BugTracker.Api.Services.Projects.Commands;
using BugTracker.Api.Services.Projects.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Api.Controllers
{
    [ApiController]
    [Route("projects")]
    public class ProjectController : ControllerBase
    {
        private readonly IAddProjectService _addProjectService;
        private readonly IDeleteProjectService _deleteProjectService;
        private readonly ISearchProjectService _searchProjectService;

        public ProjectController(
            IAddProjectService addProjectService,
            ISearchProjectService searchProjectService,
            IDeleteProjectService deleteProjectService)
        {
            _addProjectService = addProjectService;
            _searchProjectService = searchProjectService;
            _deleteProjectService = deleteProjectService;
        }

        [HttpPost]
        public async Task<int> Add([FromBody] ProjectDto projectDto)
        {
            return await _addProjectService.ExecuteAsync(projectDto);
        }

        [HttpGet]
        public async Task<List<ProjectDto>> Search([FromQuery] ProjectSearchCommand command)
        {
            return await _searchProjectService.ExecuteAsync(command);
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _deleteProjectService.ExecuteAsync(id);
        }
    }
}
