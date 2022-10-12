using BugTracker.Api.Services.Projects;
using BugTracker.Api.Services.Projects.Interfaces;
using BugTracker.Api.Services.Users;
using BugTracker.Api.Services.Users.Interfaces;

namespace BugTracker.Api.Application.DependencyInjection
{
    public static class ApplicationServiceCollection
    {
        public static IServiceCollection AddApplicationServiceCollection(this IServiceCollection services)
        {
            return services
                .AddProjectServices()
                .AddUserServices();
        }

        public static IServiceCollection AddUserServices(this IServiceCollection services)
        {
            return services
                .AddTransient<IAddUserService, AddUserService>()
                .AddTransient<ISearchUserService, SearchUserService>()
                .AddTransient<IDeleteUserService, DeleteUserService>();
        }

        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            return services
                .AddTransient<IAddProjectService, AddProjectService>()
                .AddTransient<ISearchProjectService, SearchProjectService>()
                .AddTransient<IDeleteProjectService, DeleteProjectService>();
        }
    }
}
