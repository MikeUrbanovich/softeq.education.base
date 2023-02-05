using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Validation
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateCityRequestValidator : AbstractValidator<CreateCityRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public CreateCityRequestValidator()
        {
            RuleFor(u => u.Name)
                .Must(name => !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(name.Trim()))
                .WithMessage("The name should not be empty or whitespace.");
        }
    }
}