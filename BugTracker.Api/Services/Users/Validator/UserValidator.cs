using BugTracker.Api.Models.Users;
using FluentValidation;

namespace BugTracker.Api.Services.Users.Validator
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {
            RuleFor(user => user.Name)
                .NotEmpty()
                .MaximumLength(12);

            RuleFor(user => user.Email)
                .NotEmpty()
                .EmailAddress();
        }
    }
}
