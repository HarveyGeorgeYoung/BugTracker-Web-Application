using BugTracker.Api.Services.Users;
using BugTracker.Api.Services.Users.Interfaces;

namespace BugTracker.Api.Application.DependencyInjection
{
    public static class ApplicationServiceCollection
    {
        public static IServiceCollection AddApplicationServiceCollection(this IServiceCollection services)
        {
            return services
                .AddUserServices();
        }

        public static IServiceCollection AddUserServices(this IServiceCollection services)
        {
            return services
                .AddTransient<IAddUserService, AddUserService>()
                .AddTransient<ISearchUserService, SearchUserService>()
                .AddTransient<IDeleteUserService, DeleteUserService>();
        }
    }
}
