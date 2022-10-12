using BugTracker.Api.Models.Projects;

namespace BugTracker.Api.Services.Projects.Extensions
{
    public static class ProjectSearchExtensions
    {
        public static IQueryable<Project> WithDescriptionContaining(this IQueryable<Project> projects, string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                return projects.AsQueryable();
            }

            return projects.Where(x => x.Description.Contains(description));
        }

        public static IQueryable<Project> WithNameContaining(this IQueryable<Project> projects, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return projects.AsQueryable();
            }

            return projects.Where(x => x.Name.Contains(name));
        }
    }
}
