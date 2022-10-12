using BugTracker.Api.Models.Projects;

namespace BugTracker.Api.Services.Projects.Extensions
{
    public static class ProjectDtoExtensions
    {
        public static ProjectDto ToProjectDto(this Project user)
        {
            return new ProjectDto
            {
                Name = user.Name,
                Description = user.Description,
                OwnerId = user.OwnerId,
                OwnerName = user.User!.Name
            };
        }
    }
}
