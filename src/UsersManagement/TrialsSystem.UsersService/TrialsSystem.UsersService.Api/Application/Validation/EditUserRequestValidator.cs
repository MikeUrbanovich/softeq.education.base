using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Validation
{
    public class EditUserRequestValidator : AbstractValidator<UpdateUserRequest>
    {
        public EditUserRequestValidator()
        {
            RuleFor(u => u.BirthDate)
                .Must(date => date < DateTime.Now.AddYears(-18)).WithMessage("The participant should be older than 18 years.");

            RuleFor(u => u.Name)
                .Must(name => !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(name.Trim())).WithMessage("The name should not be empty or whitespace.");

            RuleFor(u => u.Surname)
                .Must(surname => !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(surname.Trim())).WithMessage("The surname should not be empty or whitespace.");

            RuleFor(u => u.Name)
                .NotEqual(u => u.Surname).WithMessage("The name should not be equal surname.");
        }
    }
}
