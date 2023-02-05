using AutoMapper;
using MediatR;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.User
{
    /// <summary>
    /// 
    /// </summary>
    public class UsersQueryHandler : IRequestHandler<UsersQuery, IEnumerable<GetUsersResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public UsersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<GetUsersResponse>> Handle(UsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _unitOfWork.Users.GetAllAsync();

            return _mapper.Map<IEnumerable<GetUsersResponse>>(users);
        }
    }
}