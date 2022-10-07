using FluentValidation;

namespace BugTracker.Api.Models.Users
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
