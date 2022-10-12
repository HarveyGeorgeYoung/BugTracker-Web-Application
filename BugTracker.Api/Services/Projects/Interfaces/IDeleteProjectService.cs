using BugTracker.Api.Models.Projects;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Api.Services.Projects
{
    public interface IDeleteProjectService
    {
        public Task<bool> ExecuteAsync(int id);
    }
}
