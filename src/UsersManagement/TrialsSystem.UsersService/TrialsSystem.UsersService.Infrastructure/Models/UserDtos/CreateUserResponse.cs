namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

public class CreateUserResponse : CreateUserRequest
{
    public Guid Id { get; set; }
}