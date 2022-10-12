using BugTracker.Api.Models.Users;

namespace BugTracker.Api.Services.Users.Extensions
{
    public static class UserSearchExtensions
    {
        public static IQueryable<User> WithEmailContaining(this IQueryable<User> users, string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return users.AsQueryable();
            }

            return users.Where(x => x.Email.Contains(email));
        }

        public static IQueryable<User> WithNameContaining(this IQueryable<User> users, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return users.AsQueryable();
            }

            return users.Where(x => x.Name.Contains(name));
        }
    }
}
