using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.User
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateUserCommand : IRequest<CreateUserResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="cityId"></param>
        /// <param name="birthDate"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <param name="genderId"></param>
        public CreateUserCommand(
            string email,
            string name,
            string surname,
            Guid cityId,
            DateTime birthDate,
            decimal? weight,
            decimal? height,
            Guid genderId)
        {
            Email = email;
            Name = name;
            Surname = surname;
            CityId = cityId;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
            GenderId = genderId;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Surname { get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid CityId { get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Weight { get; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Height { get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid GenderId { get; }
    }
}