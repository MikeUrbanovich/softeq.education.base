using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Validation
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateDeviceRequestValidator : AbstractValidator<CreateDeviceRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public CreateDeviceRequestValidator()
        {
            RuleFor(u => u.Model)
                .Must(name => !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(name.Trim()))
                .WithMessage("The Model should not be empty or whitespace.");

            RuleFor(u => u.FirmwareVersion)
                .Must(surname => !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(surname.Trim()))
                .WithMessage("The FirmwareVersion should not be empty or whitespace.");

            RuleFor(u => u.SerialNumber)
                .Must(surname => !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(surname.Trim()))
                .WithMessage("The SerialNumber should not be empty or whitespace.");
        }
    }
}