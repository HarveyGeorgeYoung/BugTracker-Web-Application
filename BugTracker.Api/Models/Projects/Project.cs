using BugTracker.Api.Application.Common.Shared;
using BugTracker.Api.Models.Users;

namespace BugTracker.Api.Models.Projects
{
    public class Project : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public virtual User? User { get; set; }

        public int OwnerId { get; set; }
    }
}
