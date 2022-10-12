using BugTracker.Api.Application.Common.Shared;
using BugTracker.Api.Models.Projects;

namespace BugTracker.Api.Models.Users
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime? DateOfBirth { get; set; }

        public IEnumerable<Project>? Projects { get; set; }
    }
}
