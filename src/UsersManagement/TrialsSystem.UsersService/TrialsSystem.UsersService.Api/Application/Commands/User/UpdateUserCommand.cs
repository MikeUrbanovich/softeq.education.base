using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.User
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateUserCommand : IRequest<UpdateUserResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="cityId"></param>
        /// <param name="birthDate"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        public UpdateUserCommand(
            string id,
            string name,
            string surname,
            string cityId,
            DateTime birthDate,
            decimal? weight,
            decimal? height)
        {
            Id = id;
            Name = name;
            Surname = surname;
            CityId = cityId;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Id { get; }

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
        public string CityId { get; }

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
    }
}