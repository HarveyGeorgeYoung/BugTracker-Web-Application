using BugTracker.Api.Models.Users;

namespace BugTracker.Api.Services.Users.Extensions
{
    public static class UserDtoExtensions
    {
        public static UserDto ToUserDto(this User user)
        {
            return new UserDto
            {
                Name = user.Name,
                Email = user.Email
            };
        }
    }
}
