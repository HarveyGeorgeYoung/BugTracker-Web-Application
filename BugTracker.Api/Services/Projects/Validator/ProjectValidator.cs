using BugTracker.Api.Models.Projects;
using FluentValidation;

namespace BugTracker.Api.Services.Projects.Validator
{
    public class ProjectValidator : AbstractValidator<Project>
    {

        public ProjectValidator()
        {
            RuleFor(user => user.Name)
                .NotEmpty()
                .MaximumLength(25);

            RuleFor(user => user.OwnerId)
                .NotEmpty();
        }
    }
}
