namespace BugTracker.Api.Models.Users
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime? DateOfBirth { get; set; }
    }
}
